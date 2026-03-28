using NET_CarRentalSystem.Domain.Constants;
using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
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
        ICryptographyService  cryptographyService,
        IUnitOfWork unitOfWork) : IRequestHandler<LoginCommand, (string, TokenResponse?)>
{
    public async Task<(string, TokenResponse?)> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await identityService.FindUserAsync(request.UsernameOrEmail);
        if (user == null)
        {
            return (AuthMessage.Login.Failed, null);
        }

        var succeeded = cryptographyService.VerifyPassword(request.Password, user.Password);

        if (!succeeded || !user.IsVerified)
        {
            return (AuthMessage.Login.Failed, null);
        }

        if (user.Status == UserStatus.Banned)
        {
            return (AuthMessage.Login.Banned, null);
        }

        var tokens = await tokenService.GenerateTokensAsync(user, cancellationToken);
        
        var userSession = new UserSession
        {
            UserId = user.Id,
            RefreshToken = tokens.RefreshToken,
            RefreshTokenExpiryTime = tokens.RefreshTokenExpiry,
            IpAddress = request.IpAddress,
            DeviceName = request.DeviceName
        };
        
        await unitOfWork.GetWriteRepository<UserSession>().AddAsync(userSession, cancellationToken);
        
        var userToUpdate = await unitOfWork.GetWriteRepository<User>().GetByIdAsync(user.Id, cancellationToken);
        if (userToUpdate != null)
        {
            userToUpdate.Status = UserStatus.LoggedIn;
            unitOfWork.GetWriteRepository<User>().Update(userToUpdate);
        }
        
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        var sessionCacheDto = new UserSessionCacheDto
        {
            UserId = user.Id,
            IsRevoked = false
        };
        var sessionCacheJson = sessionCacheDto.ToJson();
        
        await cacheService.SetStringAsync(
            tokens.RefreshToken,
            sessionCacheJson,
            tokens.RefreshTokenExpiry,
            cancellationToken);
        
        var roles = await identityService.GetRolesAsync(user);
        if (roles.Any(r => r is RoleConstants.Admin or RoleConstants.Staff))
        {
            var agentEvent = new
            {
                type = "AGENT_LOGIN",
                agentId = user.Id.ToString(),
                timestamp = DateTime.UtcNow
            }.ToJson();
            await cacheService.PublishAsync("agent:status", agentEvent, cancellationToken);
        }
        
        return (AuthMessage.Login.Success, tokens);
    }
}