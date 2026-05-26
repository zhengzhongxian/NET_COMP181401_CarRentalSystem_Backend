using MediatR;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public class GetActiveImpersonationSessionQueryHandler(
    ICurrentUserService currentUserService,
    ICacheService cacheService)
    : IRequestHandler<GetActiveImpersonationSessionQuery, ActiveImpersonationSessionDto?>
{
    public async Task<ActiveImpersonationSessionDto?> Handle(
        GetActiveImpersonationSessionQuery request,
        CancellationToken cancellationToken)
    {
        var adminUserId = currentUserService.GetUserId();
        if (adminUserId == null) return null;

        var activeKey = CacheKeyHelper.GetAdminActiveImpersonationKey(adminUserId.Value);
        var impersonationToken = await cacheService.GetStringAsync(activeKey, cancellationToken);
        if (string.IsNullOrEmpty(impersonationToken)) return null;

        var parts = impersonationToken.Split('.');
        if (parts.Length < 1) return null;
        var tokenRaw = parts[0];

        var sessionKey = CacheKeyHelper.GetImpersonationSessionKey(tokenRaw);
        var sessionJson = await cacheService.GetStringAsync(sessionKey, cancellationToken);
        if (string.IsNullOrEmpty(sessionJson))
        {
            await cacheService.RemoveAsync(activeKey, cancellationToken);
            return null;
        }

        var session = sessionJson.FromJson<ImpersonationSessionData>();
        if (session == null || session.ExpiresAt <= DateTime.UtcNow)
        {
            await cacheService.RemoveAsync(activeKey, cancellationToken);
            await cacheService.RemoveAsync(sessionKey, cancellationToken);
            return null;
        }

        var remainingMinutes = (int)(session.ExpiresAt - DateTime.UtcNow).TotalMinutes;
        if (remainingMinutes <= 0) remainingMinutes = 1;

        return new ActiveImpersonationSessionDto
        {
            ImpersonationToken = impersonationToken,
            DeveloperCode = session.DeveloperCode,
            DeveloperUserName = session.DeveloperUserName,
            DurationMinutes = session.DurationMinutes,
            ExpiresAt = session.ExpiresAt,
            RemainingMinutes = remainingMinutes
        };
    }
}
