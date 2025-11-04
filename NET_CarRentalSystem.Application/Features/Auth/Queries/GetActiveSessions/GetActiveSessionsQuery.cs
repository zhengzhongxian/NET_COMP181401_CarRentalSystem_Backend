using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.DTOs.UserDTOs.Get;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Auth.Queries.GetActiveSessions;

public class GetActiveSessionsQuery : IQuery<List<GetUserSessionDto>>;

public class GetActiveSessionsQueryHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService) : IRequestHandler<GetActiveSessionsQuery, List<GetUserSessionDto>>
{
    public async Task<List<GetUserSessionDto>> Handle(GetActiveSessionsQuery request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId()!.Value;

        var sessions = await unitOfWork.GetRepository<Domain.Entities.UserSession>().GetAsync(
            filter: s => s.UserId == userId,
            sortBy: "CreatedAt",
            sortDirection: "desc");

        var sessionDtos = sessions.Select(s => new GetUserSessionDto
        {
            UserSessionId = s.UserSessionId,
            DeviceName = s.DeviceName,
            IpAddress = s.IpAddress,
            CreatedAt = s.CreatedAt
        }).ToList();

        return sessionDtos;
    }
}

