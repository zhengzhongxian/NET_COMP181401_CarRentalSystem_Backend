using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Utilities;
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
        
        if (principal is null)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }
        
        var userIdString = tokenService.FindFirst(principal);
        
        if (!Guid.TryParse(userIdString, out var userId))
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var sessionRepository = unitOfWork.GetRepository<UserSession>();
        var sessionCacheJson = await cacheService.GetStringAsync(request.RefreshToken, cancellationToken);
        if (sessionCacheJson is null)
        {
            var sessionInDb = await sessionRepository.GetFirstOrDefaultAsync(
                s => s.RefreshToken == request.RefreshToken, 
                cancellationToken: cancellationToken);
            
            if (sessionInDb != null && sessionInDb.UserId == userId)
            {
                var remainingSessions = await sessionRepository.CountAsync(s => s.UserId == sessionInDb.UserId, cancellationToken);
                sessionRepository.Remove(sessionInDb, true);

                if (remainingSessions <= 1)
                {
                    var userToUpdate = await unitOfWork.GetRepository<User>().GetFirstAsync(
                        u => u.UserId == sessionInDb.UserId, 
                        useWriteConnection: true, 
                        cancellationToken: cancellationToken);
                    
                    userToUpdate.Status = UserStatus.LoggedOut;
                    unitOfWork.GetRepository<User>().Update(userToUpdate);

                }

                await unitOfWork.SaveChangesAsync(cancellationToken);
                
                return (AuthMessage.RefreshToken.Invalid, null);
            }
            
            var allUserSessions = await sessionRepository.GetAsync(
                s => s.UserId == userId,
                cancellationToken: cancellationToken);

            if (allUserSessions.Count > 0)
            {
                foreach (var session in allUserSessions)
                {
                    sessionRepository.Remove(session, true);
                    await cacheService.RemoveAsync(session.RefreshToken, cancellationToken);
                }

                // FIX 3: 'userId' đã là Guid, không cần Parse
                var userToUpdate = await unitOfWork.GetRepository<User>().GetFirstAsync(u => u.UserId == userId, useWriteConnection: true, cancellationToken: cancellationToken);
                userToUpdate.Status = UserStatus.LoggedOut;
                unitOfWork.GetRepository<User>().Update(userToUpdate);

            }

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return (AuthMessage.RefreshToken.Breach, null);
        }
        
        var sessionCache = sessionCacheJson.FromJson<UserSessionCacheDto>()!;
        
        if (sessionCache.IsRevoked)
        {
            var allUserSessions = await sessionRepository.GetAsync(s => s.UserId == sessionCache.UserId, cancellationToken: cancellationToken);
            if (allUserSessions.Count > 0)
            {
                foreach (var session in allUserSessions)
                {
                    sessionRepository.Remove(session, true);
                    await cacheService.RemoveAsync(session.RefreshToken, cancellationToken);
                }

                var userToUpdate = await unitOfWork.GetRepository<User>().GetFirstAsync(u => u.UserId == sessionCache.UserId, useWriteConnection: true, cancellationToken: cancellationToken);
                userToUpdate.Status = UserStatus.LoggedOut;
                unitOfWork.GetRepository<User>().Update(userToUpdate);

            }

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return (AuthMessage.RefreshToken.Breach, null);
        }
        
        if (sessionCache.UserId != userId)
        {
            return (AuthMessage.RefreshToken.Invalid, null);
        }

        var currentDbSession = await sessionRepository.GetFirstAsync(s => s.RefreshToken == request.RefreshToken, useWriteConnection: true);
        var originalExpiryTime = currentDbSession.RefreshTokenExpiryTime;

        var user = await unitOfWork.GetRepository<User>().GetByIdAsync(sessionCache.UserId, cancellationToken);

        var newTokens = await tokenService.GenerateTokensAsync(user!);
        currentDbSession.RefreshToken = newTokens.RefreshToken;
        currentDbSession.RefreshTokenExpiryTime = newTokens.RefreshTokenExpiry;
        sessionRepository.Update(currentDbSession);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);

        sessionCache.IsRevoked = true;
        await cacheService.SetStringAsync(request.RefreshToken, sessionCache.ToJson(), originalExpiryTime, cancellationToken);
        
        var newSessionCache = new UserSessionCacheDto
        {
            UserId = user!.UserId, 
            IsRevoked = false
        };
        await cacheService.SetStringAsync(newTokens.RefreshToken, newSessionCache.ToJson(), newTokens.RefreshTokenExpiry, cancellationToken);
        
        return (AuthMessage.RefreshToken.Success, newTokens);
    }
}