using MediatR;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public class GetDevCodeQueryHandler(
    ICurrentUserService currentUserService,
    ICacheService cacheService)
    : IRequestHandler<GetDevCodeQuery, DevCodeSessionData?>
{
    public async Task<DevCodeSessionData?> Handle(
        GetDevCodeQuery request,
        CancellationToken cancellationToken)
    {
        var devUserId = currentUserService.GetUserId();
        if (devUserId == null) return null;

        var userKey = CacheKeyHelper.GetDevCodeByUserKey(devUserId.Value);
        var json = await cacheService.GetStringAsync(userKey, cancellationToken);
        if (string.IsNullOrEmpty(json)) return null;

        return json.FromJson<DevCodeSessionData>();
    }
}
