using System.Text.RegularExpressions;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.CreateSession;

public partial class CreateImpersonationSessionCommandHandler(
    IOptions<ImpersonationSettings> settings,
    ICurrentUserService currentUserService,
    ICacheService cacheService,
    ICryptographyService cryptographyService,
    ILogger<CreateImpersonationSessionCommandHandler> logger)
    : IRequestHandler<CreateImpersonationSessionCommand, (string Message, string? Token)>
{
    private readonly ImpersonationSettings _settings = settings.Value;

    public async Task<(string Message, string? Token)> Handle(
        CreateImpersonationSessionCommand request,
        CancellationToken cancellationToken)
    {
        if (!_settings.Enabled)
        {
            return (ImpersonationMessage.Grant.FeatureDisabled, null);
        }

        if (string.IsNullOrWhiteSpace(request.DeveloperCode) ||
            !HexCodeRegex().IsMatch(request.DeveloperCode))
        {
            return (ImpersonationValidationMessage.DeveloperCodeInvalidFormat, null);
        }

        if (request.DurationMinutes < _settings.MinDurationMinutes ||
            request.DurationMinutes > _settings.MaxDurationMinutes)
        {
            var msg = string.Format(ImpersonationValidationMessage.DurationOutOfRange,
                _settings.MinDurationMinutes, _settings.MaxDurationMinutes);
            return (msg, null);
        }

        var adminUserId = currentUserService.GetUserId();
        if (adminUserId == null)
        {
            return (ImpersonationMessage.User.InvalidAdmin, null);
        }

        var activeKey = CacheKeyHelper.GetAdminActiveImpersonationKey(adminUserId.Value);
        var activeToken = await cacheService.GetStringAsync(activeKey, cancellationToken);
        if (!string.IsNullOrEmpty(activeToken))
        {
            return (ImpersonationMessage.Session.ActiveExists, null);
        }

        var devCodeKey = CacheKeyHelper.GetDevCodeByCodeKey(request.DeveloperCode.ToLowerInvariant());
        var devCodeJson = await cacheService.GetStringAsync(devCodeKey, cancellationToken);
        if (string.IsNullOrEmpty(devCodeJson))
        {
            return (ImpersonationMessage.DevCode.Invalid, null);
        }

        var devCodeData = devCodeJson.FromJson<DevCodeSessionData>();
        if (devCodeData == null)
        {
            return (ImpersonationMessage.DevCode.InvalidData, null);
        }

        var tokenRaw = Guid.NewGuid().ToString("N");
        var hmac = cryptographyService.ComputeHmac(tokenRaw, _settings.TokenSecretKey);
        var impersonationToken = $"{tokenRaw}.{hmac}";

        var sessionData = new ImpersonationSessionData
        {
            AdminUserId = adminUserId.Value,
            DeveloperCode = request.DeveloperCode.ToLowerInvariant(),
            DeveloperUserId = devCodeData.DeveloperUserId,
            DeveloperUserName = devCodeData.DeveloperUserName,
            DurationMinutes = request.DurationMinutes,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddMinutes(request.DurationMinutes)
        };

        var redisKey = CacheKeyHelper.GetImpersonationSessionKey(tokenRaw);
        var expiryTime = DateTime.UtcNow.AddMinutes(request.DurationMinutes);
        await cacheService.SetStringAsync(
            redisKey,
            sessionData.ToJson(),
            expiryTime,
            cancellationToken);

        await cacheService.SetStringAsync(
            activeKey,
            impersonationToken,
            expiryTime,
            cancellationToken);

        logger.LogInformation(
            "[Impersonation] Session created by Admin {AdminUserId} for DevCode {DevCode} ({DeveloperUserName}), Duration={Duration}min, Token={TokenPrefix}...",
            adminUserId.Value, request.DeveloperCode, devCodeData.DeveloperUserName, request.DurationMinutes, tokenRaw[..8]);

        return (ImpersonationMessage.Grant.Success, impersonationToken);
    }

    [GeneratedRegex("^[0-9a-fA-F]{6}$")]
    private static partial Regex HexCodeRegex();
}
