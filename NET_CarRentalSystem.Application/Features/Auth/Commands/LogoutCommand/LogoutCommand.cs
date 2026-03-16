using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
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

        var sessionWriteRepository = unitOfWork.GetWriteRepository<UserSession>();
        var session = await sessionWriteRepository.GetFirstOrDefaultAsync(
            s => s.RefreshToken == request.RefreshToken,
            cancellationToken: cancellationToken);

        if (session == null)
        {
            return Unit.Value;
        }
        
        var remainingSessions = (await sessionWriteRepository.GetAsync(
            s => s.UserId == session.UserId,
            cancellationToken: cancellationToken)).Count;

        sessionWriteRepository.Remove(session, true);
        await cacheService.RemoveAsync(request.RefreshToken, cancellationToken);

        if (remainingSessions <= 1)
        {
            var userWriteRepository = unitOfWork.GetWriteRepository<User>();
            var user = await userWriteRepository.GetFirstAsync(u => u.Id == session.UserId, cancellationToken);
            
            user.Status = UserStatus.LoggedOut;
            userWriteRepository.Update(user);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}