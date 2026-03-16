using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayOS.Models.Webhooks;
using NET_CarRentalSystem.Application.Features.Webhooks.Commands.ProcessPayOsWebhookCommand;
using NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebhooksController(ISender sender, ILogger<WebhooksController> logger) : ControllerBase
{
    [HttpPost("payos")]
    [AllowAnonymous]
    public async Task<IActionResult> HandlePayOsWebhook(Webhook webhook, CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation("[Webhook] Received PayOS webhook: OrderCode={OrderCode}, Amount={Amount}", 
                webhook?.Data?.OrderCode, webhook?.Data?.Amount);
            if (webhook?.Data == null)
            {
                logger.LogError("[Webhook] Webhook data is null");
                return BadRequest(ApiResponse.ErrorResult("Invalid webhook payload"));
            }
            
            
            if (webhook.Data.OrderCode == 123 && 
                webhook.Data.Description == "VQRIO123" && 
                webhook.Data.AccountNumber == "12345678")
            {
                logger.LogInformation("[Webhook] Received PayOS test webhook - returning success");
                return Ok(new { message = "Webhook processed successfully" });
            }

            var webhookData = new PayOsWebhookData
            {
                OrderCode = webhook.Data.OrderCode,
                Amount = webhook.Data.Amount,
                Description = webhook.Data.Description,
                AccountNumber = webhook.Data.AccountNumber,
                Reference = webhook.Data.Reference,
                TransactionDateTime = webhook.Data.TransactionDateTime,
                Currency = webhook.Data.Currency,
                PaymentLinkId = webhook.Data.PaymentLinkId,
                Code = webhook.Data.Code,
                CounterAccountBankId = webhook.Data.CounterAccountBankId,
                CounterAccountBankName = webhook.Data.CounterAccountBankName,
                CounterAccountName = webhook.Data.CounterAccountName,
                CounterAccountNumber = webhook.Data.CounterAccountNumber,
                VirtualAccountName = webhook.Data.VirtualAccountName,
                VirtualAccountNumber = webhook.Data.VirtualAccountNumber
            };

            var command = new ProcessPayOsWebhookCommand
            {
                WebhookData = webhookData
            };

            var result = await sender.Send(command, cancellationToken);

            if (result)
            {
                logger.LogInformation("[Webhook] Successfully processed webhook for OrderCode={OrderCode}", webhook.Data.OrderCode);
                
                var successResponse = ApiResponse.SuccessResult(
                    new { orderCode = webhook.Data.OrderCode },
                    WebhookMessage.PayOsWebhook.Success);
                
                return Ok(successResponse);
            }

            logger.LogWarning("[Webhook] Failed to process webhook for OrderCode={OrderCode}", webhook.Data.OrderCode);
            
            var failResponse = ApiResponse.ErrorResult(
                WebhookMessage.PayOsWebhook.ProcessingError,
                StatusCodes.Status500InternalServerError);
            
            return StatusCode(StatusCodes.Status500InternalServerError, failResponse);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[Webhook] Exception processing webhook: {Message}\nStackTrace: {StackTrace}\nInnerException: {InnerException}", 
                ex.Message, 
                ex.StackTrace,
                ex.InnerException?.Message ?? "None");
            
            var errorResponse = ApiResponse.ErrorResult(
                WebhookMessage.PayOsWebhook.ProcessingError,
                StatusCodes.Status500InternalServerError,
                [ex.Message, ex.InnerException?.Message ?? string.Empty]);
            
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost("test/hiendon")]
    public Task<IActionResult> Handle()
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}

