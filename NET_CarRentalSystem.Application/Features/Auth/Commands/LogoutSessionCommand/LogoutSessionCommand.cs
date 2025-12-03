using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogoutSessionCommand;

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
        var sessionWriteRepository = unitOfWork.GetWriteRepository<UserSession>();
        var sessionReadRepository = unitOfWork.GetReadRepository<UserSession>();

        var sessionToLogout = await sessionWriteRepository.GetByIdAsync(request.SessionId, cancellationToken);

        if (sessionToLogout == null || sessionToLogout.UserId != currentUserId)
        {
            return (AuthMessage.LogoutSession.NotFound, false);
        }

        sessionWriteRepository.Remove(sessionToLogout, true);
        await cacheService.RemoveAsync(sessionToLogout.RefreshToken, cancellationToken);

        // Đếm số session hiện có trong DB (bao gồm cả session vừa đánh dấu xóa vì chưa SaveChanges)
        var remainingSessions = await sessionReadRepository.CountAsync(s => s.UserId == currentUserId, cancellationToken);
        
        if (remainingSessions <= 1)
        {
            var userWriteRepository = unitOfWork.GetWriteRepository<User>();
            var user = await userWriteRepository.GetFirstAsync(u => u.Id == currentUserId, cancellationToken);
            user.Status = UserStatus.LoggedOut;
            userWriteRepository.Update(user);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (AuthMessage.LogoutSession.Success, true);
    }
}