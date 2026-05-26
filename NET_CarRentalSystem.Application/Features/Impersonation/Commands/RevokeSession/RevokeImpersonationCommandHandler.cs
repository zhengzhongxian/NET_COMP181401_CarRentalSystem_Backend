using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.RevokeSession;

public class RevokeImpersonationCommandHandler(
    IOptions<ImpersonationSettings> settings,
    ICacheService cacheService,
    ICryptographyService cryptographyService,
    ILogger<RevokeImpersonationCommandHandler> logger)
    : IRequestHandler<RevokeImpersonationCommand, (string Message, bool Success)>
{
    private readonly ImpersonationSettings _settings = settings.Value;

    public async Task<(string Message, bool Success)> Handle(
        RevokeImpersonationCommand request,
        CancellationToken cancellationToken)
    {
        if (!_settings.Enabled)
        {
            return (ImpersonationMessage.Grant.FeatureDisabled, false);
        }

        var parts = request.ImpersonationToken?.Split('.');
        if (parts is not { Length: 2 })
        {
            return (ImpersonationMessage.Revoke.NotFound, false);
        }

        var tokenRaw = parts[0];
        var hmacReceived = parts[1];

        var hmacExpected = cryptographyService.ComputeHmac(tokenRaw, _settings.TokenSecretKey);
        if (!string.Equals(hmacReceived, hmacExpected, StringComparison.OrdinalIgnoreCase))
        {
            return (ImpersonationMessage.Revoke.NotFound, false);
        }

        var redisKey = CacheKeyHelper.GetImpersonationSessionKey(tokenRaw);
        var existingJson = await cacheService.GetStringAsync(redisKey, cancellationToken);
        if (string.IsNullOrEmpty(existingJson))
        {
            return (ImpersonationMessage.Revoke.NotFound, false);
        }

        var sessionData = existingJson.FromJson<ImpersonationSessionData>();
        if (sessionData != null)
        {
            await cacheService.RemoveAsync(redisKey, cancellationToken);
            await cacheService.RemoveAsync(CacheKeyHelper.GetAdminActiveImpersonationKey(sessionData.AdminUserId), cancellationToken);
            
            logger.LogInformation(
                "[Impersonation] Token revoked for Admin {AdminUserId} (Developer={DeveloperUserName}), Token={TokenPrefix}...",
                sessionData.AdminUserId, sessionData.DeveloperUserName, tokenRaw[..Math.Min(8, tokenRaw.Length)]);
        }
        else
        {
            await cacheService.RemoveAsync(redisKey, cancellationToken);
        }

        return (ImpersonationMessage.Revoke.Success, true);
    }
}
