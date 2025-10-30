using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetVehicles(
    [FromQuery] GetVehiclesPagedRequest request,
    CancellationToken cancellationToken)
    {
        try
        {
            var queryParams = mapper.Map<GetVehiclesPagedQueryParams>(request);

            var pagedList = await sender.Send(
                new GetVehiclesPagedQuery
                {
                    QueryParams = queryParams
                },
                cancellationToken
            );

            var pagedResponse = mapper.Map<PagedResponse<GetVehiclesPagedResponse>>(pagedList);

            var apiResponse = ApiResponse<PagedResponse<GetVehiclesPagedResponse>>.SuccessResult(
                pagedResponse,
                VehicleMessage.Get.Success
            );

            return Ok(apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse<PagedResponse<GetVehiclesPagedResponse>>.ErrorResult(
                VehicleMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]
            );

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}