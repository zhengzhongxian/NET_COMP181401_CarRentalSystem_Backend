using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.GenerateDevCode;

public class GenerateDevCodeCommandHandler(
    ICurrentUserService currentUserService,
    ICacheService cacheService,
    IUnitOfWork unitOfWork,
    ILogger<GenerateDevCodeCommandHandler> logger)
    : IRequestHandler<GenerateDevCodeCommand, (string Message, string? Code)>
{
    public async Task<(string Message, string? Code)> Handle(
        GenerateDevCodeCommand request,
        CancellationToken cancellationToken)
    {
        var devUserId = currentUserService.GetUserId();
        if (devUserId == null)
        {
            return (ImpersonationMessage.DevCode.UserNotFound, null);
        }

        var userKey = CacheKeyHelper.GetDevCodeByUserKey(devUserId.Value);
        var existingCodeJson = await cacheService.GetStringAsync(userKey, cancellationToken);
        if (!string.IsNullOrEmpty(existingCodeJson))
        {
            return (ImpersonationMessage.DevCode.CodeExists, null);
        }

        var userRepo = unitOfWork.GetWriteRepository<User>();
        var user = await userRepo.GetFirstOrDefaultAsync(u => u.Id == devUserId.Value, cancellationToken: cancellationToken);
        var userName = user?.UserName ?? "developer";

        string code;
        int maxAttempts = 5;
        int attempts = 0;
        do
        {
            code = Guid.NewGuid().ToString("N")[..6];
            var codeKey = CacheKeyHelper.GetDevCodeByCodeKey(code);
            var check = await cacheService.GetStringAsync(codeKey, cancellationToken);
            if (string.IsNullOrEmpty(check))
            {
                break;
            }
            attempts++;
        } while (attempts < maxAttempts);

        var record = new DevCodeSessionData
        {
            Code = code,
            DeveloperUserId = devUserId.Value,
            DeveloperUserName = userName,
            CreatedAt = DateTime.UtcNow
        };

        var json = record.ToJson();
        var expiry = DateTime.UtcNow.AddHours(24);
        
        await cacheService.SetStringAsync(CacheKeyHelper.GetDevCodeByUserKey(devUserId.Value), json, expiry, cancellationToken);
        await cacheService.SetStringAsync(CacheKeyHelper.GetDevCodeByCodeKey(code), json, expiry, cancellationToken);

        logger.LogInformation("[Impersonation] Developer {DeveloperUserName} generated dev code {DevCode}", userName, code);

        return (ImpersonationMessage.DevCode.Success, code);
    }
}

public class DevCodeSessionData
{
    public string Code { get; set; } = string.Empty;
    public Guid DeveloperUserId { get; set; }
    public string DeveloperUserName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
