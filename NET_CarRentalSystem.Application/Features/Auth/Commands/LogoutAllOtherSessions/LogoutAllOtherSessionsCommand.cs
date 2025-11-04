using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutAllOtherSessions;

public class LogoutAllOtherSessionsCommand : ICommand<Unit>
{
    public required string CurrentRefreshToken { get; set; }
}

public class LogoutAllOtherSessionsCommandHandler(
    IUnitOfWork unitOfWork,
    ICacheService cacheService,
    ICurrentUserService currentUserService) : IRequestHandler<LogoutAllOtherSessionsCommand, Unit>
{
    public async Task<Unit> Handle(LogoutAllOtherSessionsCommand request, CancellationToken cancellationToken)
    {
        var currentUserId = currentUserService.GetUserId()!.Value;
        var sessionRepository = unitOfWork.GetRepository<UserSession>();
        
        var sessionsToLogout = await sessionRepository.GetAsync(
            filter: s => s.UserId == currentUserId && s.RefreshToken != request.CurrentRefreshToken);

        if (sessionsToLogout.Count == 0)
        {
            return Unit.Value;
        }

        foreach (var session in sessionsToLogout)
        {
            sessionRepository.Remove(session);
            await cacheService.RemoveAsync(session.RefreshToken, cancellationToken);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}

