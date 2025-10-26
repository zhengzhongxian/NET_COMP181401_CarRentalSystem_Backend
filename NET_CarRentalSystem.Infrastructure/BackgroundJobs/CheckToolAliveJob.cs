using Microsoft.Extensions.Logging;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.BackgroundJobs;

[DisallowConcurrentExecution]
public class CheckToolAliveJob(ILogger<CheckToolAliveJob> logger) : IJob
{
    public Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation("Tool is alive at {time}", DateTime.UtcNow);
        return Task.CompletedTask;
    }
}
