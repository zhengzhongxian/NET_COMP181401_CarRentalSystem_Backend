using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutSession;

public class LogoutSessionCommand : ICommand<(string, bool)>
{
    public Guid SessionId { get; set; }
}

public class LogoutSessionCommandHandler(
    IUnitOfWork unitOfWork,
    ICacheService cacheService,
    ICurrentUserService currentUserService) : IRequestHandler<LogoutSessionCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(LogoutSessionCommand request, CancellationToken cancellationToken)
    {
        var currentUserId = currentUserService.GetUserId()!.Value;
        var sessionRepository = unitOfWork.GetRepository<UserSession>();

        var sessionToLogout = await sessionRepository.GetByIdAsync(request.SessionId, cancellationToken, useWriteConnection: true);

        if (sessionToLogout == null || sessionToLogout.UserId != currentUserId)
        {
            return (AuthMessage.LogoutSession.NotFound, false);
        }

        sessionRepository.Remove(sessionToLogout, true);
        await cacheService.RemoveAsync(sessionToLogout.RefreshToken, cancellationToken);

        var remainingSessions = await sessionRepository.CountAsync(s => s.UserId == currentUserId, cancellationToken);
        if (remainingSessions <= 1)
        {
            var userRepository = unitOfWork.GetRepository<User>();
            var user = await userRepository.GetFirstAsync(u => u.UserId == currentUserId, cancellationToken: cancellationToken, useWriteConnection: true);
            user.Status = UserStatus.LoggedOut;
            userRepository.Update(user);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (AuthMessage.LogoutSession.Success, true);
    }
}

