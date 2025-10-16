using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FuelsController(ISender sender) : ControllerBase
{
    private readonly ISender _sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAllFuels(CancellationToken cancellationToken)
    {
        try
        {
            var result = await _sender.Send(new GetAllFuelsQuery(), cancellationToken);
            var response = ApiResponse<List<FuelDto>>.Success(result);
            return StatusCode((int) response.StatusCode, response);
        }
        catch (Exception ex)
        {

            var errorResponse = ApiResponse<List<FuelDto>>.Fail(ex.Message);
            return StatusCode((int)errorResponse.StatusCode, errorResponse);
        }
    }
}
