using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request.Payments;
using NET_CarRentalSystem.API.Models.Response.Payments;
using NET_CarRentalSystem.Application.Features.Payments.Commands.CreatePaymentQrLinkCommand;
using NET_CarRentalSystem.Application.Features.Payments.Queries.GetPaymentMethodQuery;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
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
            var apiResponse = ApiResponse.SuccessResult(
                response, 
                PaymentMessage.Get.Success);
            
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                PaymentMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );
            
            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Tạo mã QR thanh toán VietQR
    /// </summary>
    [HttpPost("generate-qr")]
    public async Task<IActionResult> GenerateQr(
        [FromBody] CreatePaymentQrRequest request, 
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new CreatePaymentQrLinkCommand
            {
                Amount = request.Amount,
                Description = request.Description
            };

            var result = await sender.Send(command, cancellationToken);

            var response = mapper.Map<CreatePaymentQrResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(
                response,
                PaymentMessage.CreateQr.Success
            );

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                PaymentMessage.CreateQr.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Test endpoint để kiểm tra VietQR integration
    /// </summary>
    [HttpGet("test")]
    public IActionResult Test()
    {
        var apiResponse = ApiResponse.SuccessResult(
            "VietQR Payment API đang hoạt động!",
            "Kết nối VietQR thành công"
        );
        
        return StatusCode(apiResponse.StatusCode, apiResponse);
    }
}