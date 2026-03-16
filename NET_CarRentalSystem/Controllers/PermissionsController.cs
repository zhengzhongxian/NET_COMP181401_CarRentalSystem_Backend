using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Response.Permissions;
using NET_CarRentalSystem.Application.Features.Permissions.Queries.GetPermissionsQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PermissionsController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetPermissions([FromQuery] string? groupName, CancellationToken ct)
    {
        try
        {
            var query = new GetPermissionsQuery { GroupName = groupName };
            var result = await sender.Send(query, ct);

            var response = mapper.Map<List<GetPermissionGroupResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, RoleMessage.Permission.GetSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Permission.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
}

