using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class CheckToolAliveJob(
    ILogger<CheckToolAliveJob> logger,
    IAiImageVerificationService aiVerificationService) : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation("Health check started at {Time}", DateTime.UtcNow);
        
        try
        {
            var aiHealthy = await aiVerificationService.HealthCheckAsync(context.CancellationToken);
            if (aiHealthy)
            {
                logger.LogInformation("AI Image Verification Service: HEALTHY");
            }
            else
            {
                logger.LogWarning("AI Image Verification Service: UNHEALTHY or DISABLED");
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "AI Image Verification Service: ERROR during health check");
        }
        
        logger.LogInformation("Health check completed at {Time}", DateTime.UtcNow);
    }
}
