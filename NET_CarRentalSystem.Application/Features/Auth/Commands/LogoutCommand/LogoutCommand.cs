using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutCommand;

public class LogoutCommand : ICommand<Unit>
{
    public required string RefreshToken { get; set; }
}

public class LogoutCommandHandler(
    IUnitOfWork unitOfWork,
    ICacheService cacheService) : IRequestHandler<LogoutCommand, Unit>
{
    public async Task<Unit> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        var sessionCacheJson = await cacheService.GetStringAsync(request.RefreshToken, cancellationToken);
        if (sessionCacheJson != null)
        {
            var sessionCache = sessionCacheJson.FromJson<UserSessionCacheDto>()!;
            if (sessionCache.IsRevoked)
            {
                return Unit.Value;
            }
        }

        var sessionRepository = unitOfWork.GetRepository<UserSession>();
        var session = await sessionRepository.GetFirstOrDefaultAsync(
            s => s.RefreshToken == request.RefreshToken,
            cancellationToken: cancellationToken,
            useWriteConnection: true);

        if (session == null)
        {
            return Unit.Value;
        }
        
        sessionRepository.Remove(session, true);
        await cacheService.RemoveAsync(request.RefreshToken, cancellationToken);

        var remainingSessions = await sessionRepository.CountAsync(s => s.UserId == session.UserId, cancellationToken);

        if (remainingSessions <= 1)
        {
            var userRepository = unitOfWork.GetRepository<User>();
            var user = await userRepository.GetFirstAsync(
                s=> s.UserId == session.UserId, 
                cancellationToken: cancellationToken, 
                useWriteConnection: true);
            
            user.Status = UserStatus.LoggedOut;
            userRepository.Update(user);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

