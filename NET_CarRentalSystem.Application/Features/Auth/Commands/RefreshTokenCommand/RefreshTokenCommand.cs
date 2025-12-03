using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

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
        
        if (principal is null)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }
        
        var userIdString = tokenService.FindFirst(principal);
        
        if (!Guid.TryParse(userIdString, out var userId))
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var sessionReadRepository = unitOfWork.GetReadRepository<UserSession>();
        var sessionWriteRepository = unitOfWork.GetWriteRepository<UserSession>();
        var userWriteRepository = unitOfWork.GetWriteRepository<User>();

        var sessionCacheJson = await cacheService.GetStringAsync(request.RefreshToken, cancellationToken);
        if (sessionCacheJson is null)
        {
            var sessionInDb = await sessionReadRepository.GetFirstOrDefaultAsync(
                s => s.RefreshToken == request.RefreshToken, 
                cancellationToken: cancellationToken);
            
            if (sessionInDb != null && sessionInDb.UserId == userId)
            {
                var remainingSessions = await sessionReadRepository.CountAsync(s => s.UserId == sessionInDb.UserId, cancellationToken);
                sessionWriteRepository.Remove(sessionInDb, true);

                if (remainingSessions <= 1)
                {
                    var userToUpdate = await userWriteRepository.GetFirstAsync(
                        u => u.Id == sessionInDb.UserId, 
                        cancellationToken: cancellationToken);
                    
                    userToUpdate.Status = UserStatus.LoggedOut;
                    userWriteRepository.Update(userToUpdate);

                }

                await unitOfWork.SaveChangesAsync(cancellationToken);
                
                return (AuthMessage.RefreshToken.Invalid, null);
            }
            
            var allUserSessions = await sessionReadRepository.GetAsync(
                s => s.UserId == userId,
                cancellationToken: cancellationToken);

            if (allUserSessions.Count > 0)
            {
                foreach (var session in allUserSessions)
                {
                    sessionWriteRepository.Remove(session, true);
                    await cacheService.RemoveAsync(session.RefreshToken, cancellationToken);
                }
                
                var userToUpdate = await userWriteRepository.GetFirstAsync(u => 
                    u.Id == userId, 
                    cancellationToken: cancellationToken);
                
                userToUpdate.Status = UserStatus.LoggedOut;
                userWriteRepository.Update(userToUpdate);

            }

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return (AuthMessage.RefreshToken.Breach, null);
        }
        
        var sessionCache = sessionCacheJson.FromJson<UserSessionCacheDto>()!;
        
        if (sessionCache.IsRevoked)
        {
            var allUserSessions = await sessionReadRepository.GetAsync(s => s.UserId == sessionCache.UserId, cancellationToken: cancellationToken);
            if (allUserSessions.Count > 0)
            {
                foreach (var session in allUserSessions)
                {
                    sessionWriteRepository.Remove(session, true);
                    await cacheService.RemoveAsync(session.RefreshToken, cancellationToken);
                }

                var userToUpdate = await userWriteRepository.GetFirstAsync(u => 
                    u.Id == sessionCache.UserId, 
                    cancellationToken: cancellationToken);
                
                userToUpdate.Status = UserStatus.LoggedOut;
                userWriteRepository.Update(userToUpdate);

            }

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return (AuthMessage.RefreshToken.Breach, null);
        }
        
        if (sessionCache.UserId != userId)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var currentDbSession = await sessionWriteRepository.GetFirstAsync(s => s.RefreshToken == request.RefreshToken, cancellationToken: cancellationToken);
        var originalExpiryTime = currentDbSession.RefreshTokenExpiryTime;

        var user = await unitOfWork.GetReadRepository<User>().GetByIdAsync(sessionCache.UserId, cancellationToken);

        var newTokens = await tokenService.GenerateTokensAsync(user!, cancellationToken: cancellationToken);
        currentDbSession.RefreshToken = newTokens.RefreshToken;
        currentDbSession.RefreshTokenExpiryTime = newTokens.RefreshTokenExpiry;
        sessionWriteRepository.Update(currentDbSession);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);

        sessionCache.IsRevoked = true;
        await cacheService.SetStringAsync(request.RefreshToken, sessionCache.ToJson(), originalExpiryTime, cancellationToken);
        
        var newSessionCache = new UserSessionCacheDto
        {
            UserId = user!.Id, 
            IsRevoked = false
        };
        await cacheService.SetStringAsync(newTokens.RefreshToken, newSessionCache.ToJson(), newTokens.RefreshTokenExpiry, cancellationToken);
        
        return (AuthMessage.RefreshToken.Success, newTokens);
    }
}