using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class CheckToolAliveService(
    IServiceProvider serviceProvider, 
    IConfiguration configuration,
    ILogger<CheckToolAliveService> logger) : BackgroundService
{
    private readonly string _jobName = configuration.GetValue<string>(KeyConstants.Quartz.CheckToolAlive.JobName) ?? "CheckToolAlive";
    private readonly string _cronExp = configuration.GetValue<string>(KeyConstants.Quartz.CheckToolAlive.CronExpression) ?? "0 * * * * ?";
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            logger.LogInformation("Start scheduling jobs: {JobName}", _jobName);

            using var scope = serviceProvider.CreateScope();
            var job = scope.ServiceProvider.GetRequiredService<IScheduleService<CheckToolAliveJob>>();
                
            await job.ScheduleJobAsync(
                _jobName,
                _cronExp,
                null,
                stoppingToken
            );
            
            logger.LogInformation("Job scheduled successfully: {JobName} với cron: {Cron}", _jobName, _cronExp);
        }
        catch (Exception ex)
        {
            logger.LogError("Fatal error while scheduling job: {JobName}. Error: {ex}", _jobName, ex);
        }
    }
}