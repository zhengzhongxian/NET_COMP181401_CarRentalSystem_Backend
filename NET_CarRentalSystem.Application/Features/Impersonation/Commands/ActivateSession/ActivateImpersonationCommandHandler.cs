using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.ActivateSession;

public class ActivateImpersonationCommandHandler(
    IOptions<ImpersonationSettings> settings,
    ICacheService cacheService,
    ICryptographyService cryptographyService,
    ITokenService tokenService,
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ILogger<ActivateImpersonationCommandHandler> logger)
    : IRequestHandler<ActivateImpersonationCommand, (string Message, ActivateImpersonationResult? Result)>
{
    private readonly ImpersonationSettings _settings = settings.Value;

    public async Task<(string Message, ActivateImpersonationResult? Result)> Handle(
        ActivateImpersonationCommand request,
        CancellationToken cancellationToken)
    {
        if (!_settings.Enabled)
        {
            return (ImpersonationMessage.Grant.FeatureDisabled, null);
        }

        var parts = request.ImpersonationToken?.Split('.');
        if (parts is not { Length: 2 })
        {
            return (ImpersonationMessage.Activate.InvalidToken, null);
        }

        var tokenRaw = parts[0];
        var hmacReceived = parts[1];

        var hmacExpected = cryptographyService.ComputeHmac(tokenRaw, _settings.TokenSecretKey);
        if (!string.Equals(hmacReceived, hmacExpected, StringComparison.OrdinalIgnoreCase))
        {
            return (ImpersonationMessage.Activate.InvalidToken, null);
        }

        var redisKey = CacheKeyHelper.GetImpersonationSessionKey(tokenRaw);
        var sessionJson = await cacheService.GetStringAsync(redisKey, cancellationToken);
        if (string.IsNullOrEmpty(sessionJson))
        {
            return (ImpersonationMessage.Activate.TokenExpired, null);
        }

        var session = sessionJson.FromJson<ImpersonationSessionData>();
        if (session == null || session.ExpiresAt <= DateTime.UtcNow)
        {
            return (ImpersonationMessage.Activate.TokenExpired, null);
        }

        var currentUserId = currentUserService.GetUserId();
        if (currentUserId == null || currentUserId != session.DeveloperUserId)
        {
            return (ImpersonationMessage.Activate.InvalidToken, null);
        }

        var userRepo = unitOfWork.GetWriteRepository<Domain.Entities.User>();
        var adminUser = await userRepo.GetFirstOrDefaultAsync(
            u => u.Id == session.AdminUserId,
            cancellationToken: cancellationToken);

        if (adminUser == null)
        {
            return (ImpersonationMessage.Activate.InvalidToken, null);
        }

        var impersonationClaims = new List<System.Security.Claims.Claim>
        {
            new("ImpersonatorId", session.DeveloperUserId.ToString()),
            new("ImpersonatorName", session.DeveloperUserName)
        };

        var tokenResponse = await tokenService.GenerateTokensAsync(adminUser, impersonationClaims, cancellationToken);

        var remainingMinutes = (int)(session.ExpiresAt - DateTime.UtcNow).TotalMinutes;

        logger.LogInformation(
            "[AuditLog] Action={Action} Entity={EntityName} EntityId={EntityId} " +
            "UserId={UserId} ChangedProperties={ChangedProperties} " +
            "OldValues={OldValues} NewValues={NewValues} " +
            "IpAddress={IpAddress} RequestPath={RequestPath} Timestamp={Timestamp}",
            "Impersonate",
            "ImpersonationSession",
            tokenRaw,
            session.DeveloperUserName,
            "Activated",
            "",
            $"Developer {session.DeveloperUserName} ({session.DeveloperUserId}) activated remote control over Admin {adminUser.UserName} ({adminUser.Id}) for {session.DurationMinutes} minutes.",
            "",
            "/api/Impersonation/activate",
            DateTime.UtcNow);

        var result = new ActivateImpersonationResult
        {
            AccessToken = tokenResponse.AccessToken,
            AccessTokenExpiry = tokenResponse.AccessTokenExpiry,
            AdminUserName = adminUser.UserName,
            RemainingMinutes = remainingMinutes,
            ExpiresAt = session.ExpiresAt
        };

        return (ImpersonationMessage.Activate.Success, result);
    }
}
