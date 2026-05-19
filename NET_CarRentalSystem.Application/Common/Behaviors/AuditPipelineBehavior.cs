using System.Diagnostics;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Common.Behaviors;

public class AuditPipelineBehavior<TRequest, TResponse>(
    ICurrentUserService currentUserService,
    ILogger<AuditPipelineBehavior<TRequest, TResponse>> logger) : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        var userId = GetUserId();
        var stopwatch = Stopwatch.StartNew();

        string? requestBody;
        try
        {
            requestBody = request.ToJson();
        }
        catch
        {
            requestBody = "[Serialization failed]";
        }

        logger.LogInformation(
            "[Audit:Start] UserId={UserId} Request={RequestName} Body={RequestBody}",
            userId, requestName, requestBody);

        try
        {
            var response = await next();
            stopwatch.Stop();

            logger.LogInformation(
                "[Audit:End] UserId={UserId} Request={RequestName} " +
                "ElapsedMs={ElapsedMs} Status=Success",
                userId, requestName, stopwatch.ElapsedMilliseconds);

            return response;
        }
        catch (Exception ex)
        {
            stopwatch.Stop();

            logger.LogWarning(
                "[Audit:End] UserId={UserId} Request={RequestName} " +
                "ElapsedMs={ElapsedMs} Status=Failed Error={ErrorMessage}",
                userId, requestName, stopwatch.ElapsedMilliseconds, ex.Message);

            throw;
        }
    }

    private string GetUserId()
    {
        try
        {
            return currentUserService.GetUserId()?.ToString() ?? "Anonymous";
        }
        catch
        {
            return "Anonymous";
        }
    }
}
