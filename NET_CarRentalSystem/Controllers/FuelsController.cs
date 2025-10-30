using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Application.DTOs.FuelDTOs.Get;
using NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;
namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuelsController(ISender sender) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAllFuels(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetAllFuelsQuery();

            var result = await sender.Send(query, cancellationToken);

            var apiResponse = ApiResponse<IEnumerable<FuelDto>>.SuccessResult(
                result,
                FuelMessage.Get.Success
            );

            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<IEnumerable<FuelDto>>.ErrorResult(
                FuelMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message] 
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}
