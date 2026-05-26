using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.ActivateSession;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.CreateSession;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.RevokeSession;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.DeleteDevCode;
using NET_CarRentalSystem.Application.Features.Impersonation.Queries;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[Route("api/impersonation")]
[ApiController]
public class ImpersonationController(IMediator mediator) : ControllerBase
{
    [HttpPost("grant")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GrantAccess(
        [FromBody] GrantAccessRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new CreateImpersonationSessionCommand
            {
                DeveloperCode = request.DeveloperCode,
                DurationMinutes = request.DurationMinutes
            };

            var (message, token) = await mediator.Send(command, cancellationToken);

            if (token == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var data = new { impersonationToken = token };
            var apiResponse = ApiResponse<object>.SuccessResult(data, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.Grant.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost("activate")]
    [ValidateUserExists(Roles = RoleConstants.Developer)]
    public async Task<IActionResult> ActivateToken(
        [FromBody] ActivateTokenRequest request,
        CancellationToken cancellationToken)
    {
        try
        {
            var command = new ActivateImpersonationCommand
            {
                ImpersonationToken = request.ImpersonationToken
            };

            var (message, result) = await mediator.Send(command, cancellationToken);

            if (result == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status401Unauthorized);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse<object>.SuccessResult(result, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.Activate.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpDelete("revoke/{token}")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> RevokeToken(string token, CancellationToken cancellationToken)
    {
        try
        {
            var command = new RevokeImpersonationCommand
            {
                ImpersonationToken = token
            };

            var (message, success) = await mediator.Send(command, cancellationToken);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status404NotFound);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.Revoke.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
    
    [HttpGet("dev-logs")]
    [Authorize]
    public async Task<IActionResult> GetDevLogs([FromQuery] GetDevLogsQuery query)
    {
        try
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.DevLogs.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpPost("devcode")]
    [ValidateUserExists(Roles = RoleConstants.Developer)]
    public async Task<IActionResult> GenerateDevCode(CancellationToken cancellationToken)
    {
        try
        {
            var command = new GenerateDevCodeCommand();
            var (message, code) = await mediator.Send(command, cancellationToken);

            if (code == null)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status400BadRequest);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var data = new { developerCode = code };
            var apiResponse = ApiResponse<object>.SuccessResult(data, message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.DevCode.GenerateError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpDelete("devcode")]
    [ValidateUserExists(Roles = RoleConstants.Developer)]
    public async Task<IActionResult> DeleteDevCode(CancellationToken cancellationToken)
    {
        try
        {
            var command = new DeleteDevCodeCommand();
            var (message, success) = await mediator.Send(command, cancellationToken);

            if (!success)
            {
                var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status400BadRequest);
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }

            var apiResponse = ApiResponse.SuccessResult(message);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.DevCode.DeleteError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("devcode")]
    [ValidateUserExists(Roles = RoleConstants.Developer)]
    public async Task<IActionResult> GetDevCode(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetDevCodeQuery();
            var result = await mediator.Send(query, cancellationToken);

            if (result == null)
            {
                var apiResponseNull = ApiResponse<object>.SuccessResult(null, ImpersonationMessage.DevCode.NotFound);
                return StatusCode(apiResponseNull.StatusCode, apiResponseNull);
            }

            var apiResponse = ApiResponse<object>.SuccessResult(result, ImpersonationMessage.DevCode.GetSuccess);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.DevCode.GetError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }

    [HttpGet("active-session")]
    [ValidateUserExists(Roles = RoleConstants.Admin)]
    public async Task<IActionResult> GetActiveSession(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetActiveImpersonationSessionQuery();
            var result = await mediator.Send(query, cancellationToken);

            if (result == null)
            {
                var apiResponseNull = ApiResponse<object>.SuccessResult(null, ImpersonationMessage.Session.ActiveNotFound);
                return StatusCode(apiResponseNull.StatusCode, apiResponseNull);
            }

            var apiResponse = ApiResponse<object>.SuccessResult(result, ImpersonationMessage.Session.GetSuccess);
            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex)
        {
            var errorResponse = ApiResponse.ErrorResult(
                ImpersonationMessage.Session.GetError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}

public record GrantAccessRequest(string DeveloperCode, int DurationMinutes);
public record ActivateTokenRequest(string ImpersonationToken);
