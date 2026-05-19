using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayOS.Models.Webhooks;
using NET_CarRentalSystem.Application.Features.Webhooks.Events;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WebhooksController(
    IPublishEndpoint publishEndpoint,
    ILogger<WebhooksController> logger) : ControllerBase
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

            var webhookEvent = new PaymentWebhookEvent
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

            await publishEndpoint.Publish(webhookEvent, cancellationToken);

            logger.LogInformation("[Webhook] Published PaymentWebhookEvent to RabbitMQ. OrderCode={OrderCode}",
                webhook.Data.OrderCode);

            return Ok(ApiResponse.SuccessResult(
                new { orderCode = webhook.Data.OrderCode },
                WebhookMessage.PayOsWebhook.Success));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[Webhook] Exception publishing webhook event: {Message}", ex.Message);

            return StatusCode(StatusCodes.Status500InternalServerError,
                ApiResponse.ErrorResult(
                    WebhookMessage.PayOsWebhook.ProcessingError,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message, ex.InnerException?.Message ?? string.Empty]));
        }
    }

    [HttpPost("test/hiendon")]
    public Task<IActionResult> Handle()
    {
        return Task.FromResult<IActionResult>(Ok());
    }
}
