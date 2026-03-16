using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Roles;
using NET_CarRentalSystem.API.Models.Response.Roles;
using NET_CarRentalSystem.Application.Features.Roles.Commands.CreateRoleClaimCommand;
using NET_CarRentalSystem.Application.Features.Roles.Commands.CreateRoleCommand;
using NET_CarRentalSystem.Application.Features.Roles.Commands.DeleteRoleClaimCommand;
using NET_CarRentalSystem.Application.Features.Roles.Commands.DeleteRoleCommand;
using NET_CarRentalSystem.Application.Features.Roles.Commands.UpdateRoleClaimCommand;
using NET_CarRentalSystem.Application.Features.Roles.Commands.UpdateRoleCommand;
using NET_CarRentalSystem.Application.Features.Roles.Queries.GetRoleClaimsQuery;
using NET_CarRentalSystem.Application.Features.Roles.Queries.GetRolesQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController(ISender sender, IMapper mapper) : ControllerBase
{
    #region Role APIs

    /// <summary>
    /// API 3: Lấy danh sách Role
    /// </summary>
    [HttpGet]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetRoles(CancellationToken ct)
    {
        try
        {
            var query = new GetRolesQuery();
            var result = await sender.Send(query, ct);

            var response = mapper.Map<List<GetRoleResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, RoleMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// API 5: Tạo Role mới
    /// </summary>
    [HttpPost]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> CreateRole([FromBody] CreateRoleRequest request, CancellationToken ct)
    {
        try
        {
            var command = new CreateRoleCommand
            {
                Name = request.Name,
                Description = request.Description
            };

            var (success, roleId, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(new { RoleId = roleId }, message, StatusCodes.Status201Created);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Create.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// API 6: Cập nhật Role
    /// </summary>
    [HttpPut("{roleId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> UpdateRole(
        [FromRoute] Guid roleId,
        [FromBody] UpdateRoleRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new UpdateRoleCommand
            {
                RoleId = roleId,
                Name = request.Name,
                Description = request.Description
            };

            var (success, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Update.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// API 7: Xóa Role
    /// </summary>
    [HttpDelete("{roleId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> DeleteRole([FromRoute] Guid roleId, CancellationToken ct)
    {
        try
        {
            var command = new DeleteRoleCommand { RoleId = roleId };
            var (success, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status404NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Delete.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion

    #region RoleClaim APIs

    /// <summary>
    /// API 4: Lấy danh sách RoleClaim
    /// </summary>
    [HttpGet("claims")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetRoleClaims([FromQuery] Guid? roleId, CancellationToken ct)
    {
        try
        {
            var query = new GetRoleClaimsQuery { RoleId = roleId };
            var result = await sender.Send(query, ct);

            var response = mapper.Map<List<GetRoleClaimResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, RoleMessage.Claim.GetSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Claim.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// API 8: Tạo RoleClaim mới
    /// </summary>
    [HttpPost("claims")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> CreateRoleClaim([FromBody] CreateRoleClaimRequest request, CancellationToken ct)
    {
        try
        {
            var command = new CreateRoleClaimCommand
            {
                RoleId = request.RoleId,
                ClaimType = request.ClaimType,
                ClaimValue = request.ClaimValue
            };

            var (success, claimId, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(new { ClaimId = claimId }, message, StatusCodes.Status201Created);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Claim.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// API 9: Cập nhật RoleClaim
    /// </summary>
    [HttpPut("claims/{claimId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> UpdateRoleClaim(
        [FromRoute] Guid claimId,
        [FromBody] UpdateRoleClaimRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new UpdateRoleClaimCommand
            {
                ClaimId = claimId,
                ClaimType = request.ClaimType,
                ClaimValue = request.ClaimValue
            };

            var (success, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Claim.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    [HttpDelete("{roleId:guid}/claims/{claimValue}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> DeleteRoleClaim(
        [FromRoute] Guid roleId,
        [FromRoute] string claimValue,
        CancellationToken ct)
    {
        try
        {
            var command = new DeleteRoleClaimCommand 
            { 
                RoleId = roleId,
                ClaimValue = claimValue
            };
            var (success, message) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status404NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                RoleMessage.Claim.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion
}

