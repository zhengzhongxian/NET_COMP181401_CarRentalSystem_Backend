using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Request.Users;
using NET_CarRentalSystem.API.Models.Response.Users;
using NET_CarRentalSystem.Application.Features.Users.Commands.AddUserClaimCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.AddUserRoleCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.RemoveUserClaimCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.RemoveUserRoleCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.UpdateAdminProfileCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserAvatarCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserPhoneCommand;
using NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserStatusCommand;
using NET_CarRentalSystem.Application.Features.Users.Queries.GetUserDetailQuery;
using NET_CarRentalSystem.Application.Features.Users.Queries.GetUsersPagedQuery;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;
using NET_CarRentalSystem.Shared.Pagination;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(ISender sender, IMapper mapper) : ControllerBase
{
    [HttpGet]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetUsers([FromQuery] GetUsersPagedRequest request, CancellationToken ct)
    {
        try
        {
            var queryParams = mapper.Map<GetUsersPagedQueryParams>(request);
            var query = new GetUsersPagedQuery
            {
                RequestParams = queryParams
            };

            var result = await sender.Send(query, ct);

            var pagedResponse = mapper.Map<PagedResponse<GetUserListResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(pagedResponse, UserMessage.Get.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpGet("{userId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetUserDetail([FromRoute] Guid userId, CancellationToken ct)
    {
        try
        {
            var query = new GetUserDetailQuery { UserId = userId };
            var result = await sender.Send(query, ct);

            if (result == null)
            {
                var notFoundResponse = ApiResponse.ErrorResult(
                    UserMessage.NotFound,
                    StatusCodes.Status404NotFound);
                return StatusCode(StatusCodes.Status404NotFound, notFoundResponse);
            }

            var response = mapper.Map<GetUserDetailResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, UserMessage.Get.DetailSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPatch("{userId:guid}/status")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> UpdateUserStatus(
        [FromRoute] Guid userId,
        [FromBody] UpdateUserStatusRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new UpdateUserStatusCommand
            {
                UserId = userId,
                Status = request.Status,
                IsIdentityVerified = request.IsIdentityVerified,
                IsPhoneVerified = request.IsPhoneVerified,
                IsDriverLicenseVerified = request.IsDriverLicenseVerified
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
                UserMessage.UpdateStatusError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPatch("phone")]
    [ValidateUserExists]
    public async Task<IActionResult> UpdateUserPhone(
        [FromBody] UpdateUserPhoneRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new UpdateUserPhoneCommand
            {
                PhoneNumber = request.PhoneNumber
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
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpPatch("avatar")]
    [ValidateUserExists]
    public async Task<IActionResult> UpdateUserAvatar(
        IFormFile avatarFile,
        CancellationToken ct)
    {
        try
        {
            if (avatarFile.Length == 0)
            {
                var badRequest = ApiResponse.ErrorResult(UserValidationMessage.Avatar.Required);
                return StatusCode(badRequest.StatusCode, badRequest);
            }

            using var memoryStream = new MemoryStream();
            await avatarFile.CopyToAsync(memoryStream, ct);
            memoryStream.Position = 0;

            var fileModel = new FileModel
            {
                Content = memoryStream,
                FileName = avatarFile.FileName,
                ContentType = avatarFile.ContentType
            };

            var command = new UpdateUserAvatarCommand
            {
                AvatarFile = fileModel
            };

            var (success, message, avatarUrl) = await sender.Send(command, ct);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(new { AvatarUrl = avatarUrl }, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPut("admin-profile")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> UpdateAdminProfile(
        [FromBody] UpdateAdminProfileRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new UpdateAdminProfileCommand
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber
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
                UserMessage.Profile.UpdateError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #region User Role Management

    [HttpPost("{userId:guid}/roles/{roleId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> AddUserRole(
        [FromRoute] Guid userId,
        [FromRoute] Guid roleId,
        CancellationToken ct)
    {
        try
        {
            var command = new AddUserRoleCommand
            {
                UserId = userId,
                RoleId = roleId
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
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpDelete("{userId:guid}/roles/{roleId:guid}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> RemoveUserRole(
        [FromRoute] Guid userId,
        [FromRoute] Guid roleId,
        CancellationToken ct)
    {
        try
        {
            var command = new RemoveUserRoleCommand
            {
                UserId = userId,
                RoleId = roleId
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
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion

    #region User Claim Management

    [HttpPost("{userId:guid}/claims")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> AddUserClaim(
        [FromRoute] Guid userId,
        [FromBody] AddUserClaimRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new AddUserClaimCommand
            {
                UserId = userId,
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
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    [HttpDelete("{userId:guid}/claims")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> RemoveUserClaim(
        [FromRoute] Guid userId,
        [FromBody] RemoveUserClaimRequest request,
        CancellationToken ct)
    {
        try
        {
            var command = new RemoveUserClaimCommand
            {
                UserId = userId,
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
                UserMessage.Get.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion
}
