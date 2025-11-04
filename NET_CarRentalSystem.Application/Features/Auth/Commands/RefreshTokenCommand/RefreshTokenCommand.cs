using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.RefreshTokenCommand;

public class RefreshTokenCommand : ICommand<(string, TokenResponse?)>
{
    public required string AccessToken { get; set; }
    public required string RefreshToken { get; set; }
}

public class RefreshTokenCommandHandler(
    ITokenService tokenService,
    ICacheService cacheService,
    IUnitOfWork unitOfWork) : IRequestHandler<RefreshTokenCommand, (string, TokenResponse?)>
{
    public async Task<(string, TokenResponse?)> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        var principal = tokenService.GetPrincipalFromExpiredToken(request.AccessToken);
        if (principal?.Identity?.Name is null)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var userId= principal.Identity.Name;

        var userIdFromCache = await cacheService.GetStringAsync(request.RefreshToken, cancellationToken);

        if (userIdFromCache is null || userIdFromCache != userId)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var session = await unitOfWork.GetRepository<UserSession>().GetFirstOrDefaultAsync(
            s => s.UserId.ToString() == userId && s.RefreshToken == request.RefreshToken,
            cancellationToken: cancellationToken, useWriteConnection: true);

        if (session == null)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var user = await unitOfWork.GetRepository<User>().GetByIdAsync(session.UserId, cancellationToken);
        if (user == null)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var newTokens = await tokenService.GenerateTokensAsync(user);
        
        session.RefreshToken = newTokens.RefreshToken;
        session.RefreshTokenExpiryTime = newTokens.RefreshTokenExpiry;
        unitOfWork.GetRepository<UserSession>().Update(session);
        
        await cacheService.RemoveAsync(request.RefreshToken, cancellationToken);
        await cacheService.SetStringAsync(newTokens.RefreshToken, user.UserId.ToString(), newTokens.RefreshTokenExpiry, cancellationToken);

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (AuthMessage.RefreshToken.Success, newTokens);
    }
}

