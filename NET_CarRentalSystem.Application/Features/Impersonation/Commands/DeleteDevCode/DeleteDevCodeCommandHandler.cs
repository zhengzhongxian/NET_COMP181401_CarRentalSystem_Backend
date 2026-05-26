using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.DeleteDevCode;

public class DeleteDevCodeCommandHandler(
    ICurrentUserService currentUserService,
    ICacheService cacheService,
    ILogger<DeleteDevCodeCommandHandler> logger)
    : IRequestHandler<DeleteDevCodeCommand, (string Message, bool Success)>
{
    public async Task<(string Message, bool Success)> Handle(
        DeleteDevCodeCommand request,
        CancellationToken cancellationToken)
    {
        var devUserId = currentUserService.GetUserId();
        if (devUserId == null)
        {
            return (ImpersonationMessage.DevCode.UserNotFound, false);
        }

        var userKey = CacheKeyHelper.GetDevCodeByUserKey(devUserId.Value);
        var existingJson = await cacheService.GetStringAsync(userKey, cancellationToken);
        if (string.IsNullOrEmpty(existingJson))
        {
            return (ImpersonationMessage.DevCode.NotFound, false);
        }

        var sessionData = existingJson.FromJson<DevCodeSessionData>();
        if (sessionData != null)
        {
            await cacheService.RemoveAsync(userKey, cancellationToken);
            await cacheService.RemoveAsync(CacheKeyHelper.GetDevCodeByCodeKey(sessionData.Code), cancellationToken);
            logger.LogInformation("[Impersonation] Developer {DeveloperUserName} deleted/revoked dev code {DevCode}", sessionData.DeveloperUserName, sessionData.Code);
        }

        return (ImpersonationMessage.DevCode.DeleteSuccess, true);
    }
}
