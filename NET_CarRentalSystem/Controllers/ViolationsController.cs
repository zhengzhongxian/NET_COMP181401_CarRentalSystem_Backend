using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Violations;
using NET_CarRentalSystem.API.Models.Response.Violations;
using NET_CarRentalSystem.Application.Features.Violations.Commands.CreateViolationPaymentCommand;
using NET_CarRentalSystem.Application.Features.Violations.Commands.ResolveViolationCommand;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ViolationsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpPost("create-payment")]
    [ValidateUserExists]
    public async Task<IActionResult> CreateViolationPayment([FromBody] CreateViolationPaymentRequest request, CancellationToken ct)
    {
        try
        {
            var command = mapper.Map<CreateViolationPaymentCommand>(request);
            var (success, message, transaction) = await sender.Send(command, ct);

            if (!success || transaction == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var response = new CreateViolationPaymentResponse
            {
                TransactionId = transaction.TransactionId,
                TransactionCode = transaction.TransactionCode,
                Amount = transaction.AmountToPay,
                PaymentUrl = transaction.PaymentUrl,
                QrCode = transaction.QrCode,
                ExpireDate = transaction.ExpireDate!.Value
            };

            var apiResponse = ApiResponse.SuccessResult(response, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                ViolationMessage.CreatePaymentLink.Error, 
                StatusCodes.Status500InternalServerError, 
                [ex.Message]);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPost("{violationId:guid}/resolve")]
    [ValidateUserExists(Policy = PermissionConstants.Violations.Resolve)]
    public async Task<IActionResult> ResolveViolation([FromRoute] Guid violationId, CancellationToken ct)
    {
        var command = new ResolveViolationCommand { ViolationId = violationId };
        var (success, message) = await sender.Send(command, ct);

        if (!success)
        {
            var errorResponse = ApiResponse.ErrorResult(message);
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }

        var apiResponse = ApiResponse.SuccessResult(message);
        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
}
