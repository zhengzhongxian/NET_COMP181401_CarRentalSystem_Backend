using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Response.Payments;
using NET_CarRentalSystem.Application.Features.Payments.Queries.GetPaymentMethodQuery;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPaymentMethod(CancellationToken cancellationToken)
    {
        try
        {
            var mediatR = await sender.Send(new GetAllPaymentMethod(), cancellationToken);
            var response = mapper.Map<List<GetPaymentMethodResponse>>(mediatR);
            var apiResponse = ApiResponse<List<GetPaymentMethodResponse>>.SuccessResult(response, PaymentMessage.Get.Success);
            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<List<GetPaymentMethodResponse>>.ErrorResult(
                PaymentMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}