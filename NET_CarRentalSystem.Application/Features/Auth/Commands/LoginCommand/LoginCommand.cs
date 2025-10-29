using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;

public class LoginCommand : ICommand<(string, TokenResponse?)> 
{
    public required string UsernameOrEmail { get; set; }
    public required string Password { get; set; }
}

public class LoginCommandHandler(
        IIdentityService identityService, 
        ITokenService tokenService,
        ICacheService cacheService) : IRequestHandler<LoginCommand, (string, TokenResponse?)> 
{
    public async Task<(string, TokenResponse?)> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await identityService.FindUserAsync(request.UsernameOrEmail);
        if (user == null)
        {
            return (AuthMessage.Login.Failed, null);
        }
        
        var succeeded = await identityService.CheckPasswordSignInAsync(user, request.Password);
        if (!succeeded)
        {
            return (AuthMessage.Login.Failed, null);
        }
        
        var tokens = await tokenService.GenerateTokensAsync(user);
        
        await cacheService.SetStringAsync(
            tokens.RefreshToken, 
            user.UserId.ToString(), 
            tokens.RefreshTokenExpiry, 
            cancellationToken);
        
        return (AuthMessage.Login.Success, tokens);
    }
}