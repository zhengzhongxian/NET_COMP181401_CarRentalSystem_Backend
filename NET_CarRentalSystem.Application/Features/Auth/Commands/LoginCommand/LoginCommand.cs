using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LoginCommand;

public class LoginCommand : ICommand<(string, TokenResponse?)>
{
    public required string UsernameOrEmail { get; set; }
    public required string Password { get; set; }
    public string? IpAddress { get; set; }
    public string? DeviceName { get; set; }
}

public class LoginCommandHandler(
        IIdentityService identityService,
        ITokenService tokenService,
        ICacheService cacheService,
        ISecurityService  securityService,
        IUnitOfWork unitOfWork) : IRequestHandler<LoginCommand, (string, TokenResponse?)>
{
    public async Task<(string, TokenResponse?)> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await identityService.FindUserAsync(request.UsernameOrEmail);
        if (user == null)
        {
            return (AuthMessage.Login.Failed, null);
        }

        var succeeded = securityService.VerifyPassword(request.Password, user.Password);

        if (!succeeded || !user.IsVerified)
        {
            return (AuthMessage.Login.Failed, null);
        }

        if (user.Status == UserStatus.Banned)
        {
            return (AuthMessage.Login.Banned, null);
        }

        var tokens = await tokenService.GenerateTokensAsync(user);
        
        var userSession = new UserSession
        {
            UserId = user.UserId,
            RefreshToken = tokens.RefreshToken,
            RefreshTokenExpiryTime = tokens.RefreshTokenExpiry,
            IpAddress = request.IpAddress,
            DeviceName = request.DeviceName
        };
        
        await unitOfWork.GetRepository<UserSession>().AddAsync(userSession, cancellationToken);
        user.Status = UserStatus.LoggedIn;
        unitOfWork.GetRepository<User>().Update(user); 
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        var sessionCacheDto = new UserSessionCacheDto
        {
            UserId = user.UserId,
            IsRevoked = false
        };
        var sessionCacheJson = sessionCacheDto.ToJson();
        
        await cacheService.SetStringAsync(
            tokens.RefreshToken,
            sessionCacheJson,
            tokens.RefreshTokenExpiry,
            cancellationToken);
        
        return (AuthMessage.Login.Success, tokens);
    }
}