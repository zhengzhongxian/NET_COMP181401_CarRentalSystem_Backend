using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request;
using NET_CarRentalSystem.API.Models.Response;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ApiResponse<PagedResponse<VehicleResponse>>>> GetVehicles(
        [FromQuery] GetVehiclesRequest request, 
        CancellationToken cancellationToken)
    {
        var queryParams = mapper.Map<GetVehiclesPagedQueryParams>(request);

        var pagedList = await sender.Send(
            new GetVehiclesPagedQuery
            {
                QueryParams = queryParams
            },
            cancellationToken
        );

        var pagedResponse = mapper.Map<PagedResponse<VehicleResponse>>(pagedList);

        return Ok(ApiResponse<PagedResponse<VehicleResponse>>.SuccessResult(pagedResponse, "Vehicles retrieved successfully"));
    }
}
