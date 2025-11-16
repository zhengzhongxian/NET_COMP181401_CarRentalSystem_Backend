using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Attributes;
using NET_CarRentalSystem.API.Models.Request.Auth;
using NET_CarRentalSystem.API.Models.Response.Auth;
using NET_CarRentalSystem.Application.Features.Auth.Commands.ForgetPasswordCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLoginCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLogupCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutAllOtherSessionsCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutSessionCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.RefreshTokenCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.ResetPasswordCommand;
using NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtpCommand;
using NET_CarRentalSystem.Application.Features.Auth.Queries.GetActiveSessions;
using NET_CarRentalSystem.Application.Features.Users.Queries.GetUserProfileQuery;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = mapper.Map<LoginCommand>(request);
                command.IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
                command.DeviceName = Request.Headers.UserAgent.ToString();

                var (message, tokenData) = await mediator.Send(command, cancellationToken);

                if (tokenData == null)
                {
                    var errorResponse = ApiResponse.ErrorResult(
                        message,
                        StatusCodes.Status401Unauthorized
                    );

                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = mapper.Map<LoginResponse>(tokenData);
                var apiResponse = ApiResponse.SuccessResult(
                    response,
                    message
                );

                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.Login.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]
                );

                return StatusCode(errorResponse.StatusCode, errorResponse);
            }
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] LogoutRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new LogoutCommand { RefreshToken = request.RefreshToken };

                await mediator.Send(command, cancellationToken);

                var apiResponse = ApiResponse.SuccessResult(AuthMessage.Logout.Success);

                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.Logout.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new RefreshTokenCommand
                {
                    AccessToken = request.AccessToken,
                    RefreshToken = request.RefreshToken
                };

                var (message, tokenData) = await mediator.Send(command, cancellationToken);

                if (tokenData == null)
                {
                    var errorResponse = ApiResponse.ErrorResult(
                        message,
                        StatusCodes.Status401Unauthorized
                    );
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = mapper.Map<LoginResponse>(tokenData);
                var apiResponse = ApiResponse.SuccessResult(
                    response,
                    message
                );

                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.RefreshToken.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpGet("sessions")]
        [ValidateUserExists]
        public async Task<IActionResult> GetActiveSessions(CancellationToken cancellationToken)
        {
            try
            {
                var sessions = await mediator.Send(new GetActiveSessionsQuery(), cancellationToken);

                var apiResponse = ApiResponse.SuccessResult(
                    mapper.Map<List<GetUserSessionResponse>>(sessions),
                    AuthMessage.GetSessions.Success);

                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.GetSessions.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpDelete("sessions/{sessionId:guid}")]
        [ValidateUserExists]
        public async Task<IActionResult> LogoutSession(Guid sessionId, CancellationToken cancellationToken)
        {
            try
            {
                var command = new LogoutSessionCommand { SessionId = sessionId };
                var (message, success) = await mediator.Send(command, cancellationToken);

                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message, StatusCodes.Status404NotFound);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);

                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.LogoutSession.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);

                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("sessions/logout-all-others")]
        [ValidateUserExists]
        public async Task<IActionResult> LogoutAllOtherSessions([FromBody] LogoutAllOtherSessionsRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new LogoutAllOtherSessionsCommand { CurrentRefreshToken = request.CurrentRefreshToken };
                await mediator.Send(command, cancellationToken);

                return Ok(ApiResponse.SuccessResult(AuthMessage.LogoutAllOtherSessions.Success));
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.LogoutAllOtherSessions.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("send-otp")]
        public async Task<IActionResult> SendOtp([FromBody] SendOtpRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new SendOtpCommand
                {
                    SendOtpParams = mapper.Map<SendOtpParams>(request),
                };

                var (message, success) = await mediator.Send(command, cancellationToken);

                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.Otp.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("logup")]
        public async Task<IActionResult> Logup([FromBody] LogupRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var command = new LogupCommand
                {
                    LogupCommandParams = mapper.Map<LogupCommandParams>(request)
                };

                var (message, success) = await mediator.Send(command, cancellationToken);

                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.Logup.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpGet("profile")]
        [ValidateUserExists]
        public async Task<IActionResult> GetUserProfile(CancellationToken cancellationToken)
        {
            try
            {
                var userDto = await mediator.Send(new GetUserProfileQuery(), cancellationToken);
                var response = mapper.Map<GetUserResponse>(userDto);
                var apiResponse = ApiResponse.SuccessResult(response, AuthMessage.User.Sucess);
                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.User.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("login-google")]
        [AllowAnonymous]
        public async Task<IActionResult> GoogleLogin([FromBody] GoogleLoginRequest request,
            CancellationToken cancellationToken)
        {
            try
            {
                var command = new GoogleLoginCommand
                {
                    IdToken = request.IdToken,
                    IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString(),
                    DeviceName = Request.Headers.UserAgent.ToString()
                };
                var (message, ggloginDto) = await mediator.Send(command, cancellationToken);

                switch (message)
                {
                    case AuthMessage.GoogleLogin.Banned:
                    {
                        var errorResponse = ApiResponse.ErrorResult(message, 401);
                        return StatusCode(errorResponse.StatusCode, errorResponse);
                    }
                    case AuthMessage.GoogleLogin.NotFound:
                    {
                        var ggInfo = mapper.Map<GoogleLoginResponse>(ggloginDto);
                        var ggInfoResponse = ApiResponse.ErrorResult(message, ggInfo, 404);
                        
                        return StatusCode(ggInfoResponse.StatusCode, ggInfoResponse);
                    }
                }

                var response = mapper.Map<LoginResponse>(ggloginDto!.TokenResponse);
                var apiResponse = ApiResponse.SuccessResult(
                    response,
                    message
                );

                return StatusCode(apiResponse.StatusCode, apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.GoogleLogin.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]
                );

                return StatusCode(errorResponse.StatusCode, errorResponse);
            }
        }

        [HttpPost("logup-google")]
        [AllowAnonymous]
        public async Task<IActionResult> GoogleLogup([FromBody] GoogleLogupRequest request,
            CancellationToken cancellationToken)
        {
            try
            {
                var command = new GoogleLogupCommand
                {
                    GoogleLogupCommandParams = mapper.Map<GoogleLogupCommandParams>(request)
                };

                var (message, success) = await mediator.Send(command, cancellationToken);

                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.GoogleLogup.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]);
                
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("forget-password")]
        public async Task<IActionResult> ForgetPassword([FromBody] ForgetPasswordRequest request,
            CancellationToken cancellationToken)
        {
            try
            {
                var command = new ForgetPasswordCommand { Email = request.Email };
                var (message, success) = await mediator.Send(command, cancellationToken);
                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.ForgetPassword.Error,
                    StatusCodes.Status500InternalServerError,
                    [e.Message]);
                
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequest request,
            CancellationToken cancellationToken)
        {
            try
            {
                var command = new ResetPasswordCommand { Token = request.Token, Password = request.Password };
                var (message, success) = await mediator.Send(command, cancellationToken);
                if (!success)
                {
                    var errorResponse = ApiResponse.ErrorResult(message);
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }

                var response = ApiResponse.SuccessResult(message);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception e)
            {
                var errorResponse = ApiResponse.ErrorResult(
                    AuthMessage.ResetPassword.Error,
                    StatusCodes.Status500InternalServerError,
                    [e.Message]);
                
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}