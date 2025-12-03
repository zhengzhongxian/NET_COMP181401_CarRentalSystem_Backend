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

        var sessionReadRepository = unitOfWork.GetReadRepository<UserSession>();
        var session = await sessionReadRepository.GetFirstOrDefaultAsync(
            s => s.RefreshToken == request.RefreshToken,
            cancellationToken: cancellationToken);

        if (session == null)
        {
            return Unit.Value;
        }
        
        unitOfWork.GetWriteRepository<UserSession>().Remove(session, true);
        await cacheService.RemoveAsync(request.RefreshToken, cancellationToken);

        var remainingSessions = await sessionReadRepository.CountAsync(s => s.UserId == session.UserId, cancellationToken);

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