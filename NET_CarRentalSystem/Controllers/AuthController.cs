using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Models.Request.Auth;
using NET_CarRentalSystem.API.Models.Response.Auth;
using NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;
using NET_CarRentalSystem.Shared.Wrapper;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IMediator mediator, IMapper mapper) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login(
            [FromBody] LoginRequest request, 
            CancellationToken cancellationToken)
        {
            try
            {
                var command = mapper.Map<LoginCommand>(request);
                var (message, tokenData) = await mediator.Send(command, cancellationToken);
                
                if (tokenData == null)
                {
                    var errorResponse = ApiResponse<LoginResponse>.ErrorResult(
                        message,
                        StatusCodes.Status401Unauthorized
                    );
                    return StatusCode(errorResponse.StatusCode, errorResponse);
                }
                
                var response = mapper.Map<LoginResponse>(tokenData);
                
                var apiResponse = ApiResponse<LoginResponse>.SuccessResult(
                    response,
                    message 
                );

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                var errorResponse = ApiResponse<LoginResponse>.ErrorResult(
                    AuthMessage.Login.Error,
                    StatusCodes.Status500InternalServerError,
                    [ex.Message]
                );
                
                return StatusCode(errorResponse.StatusCode, errorResponse);
            }
        }
    }
}