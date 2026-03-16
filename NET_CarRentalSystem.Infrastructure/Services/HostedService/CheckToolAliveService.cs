using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Hosting;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class CheckToolAliveService(
    IServiceProvider serviceProvider, 
    IOptions<CheckToolAliveSettings> options,
    ILogger<CheckToolAliveService> logger) : BackgroundService
{
    private readonly CheckToolAliveSettings _settings = options.Value;
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            logger.LogInformation("Start scheduling jobs: {JobName}", _settings.JobName);

            using var scope = serviceProvider.CreateScope();
            var job = scope.ServiceProvider.GetRequiredService<IScheduleService<CheckToolAliveJob>>();
                
            await job.ScheduleJobAsync(
                _settings.JobName,
                _settings.CronExpression,
                null,
                stoppingToken
            );
            
            logger.LogInformation("Job scheduled successfully: {JobName} với cron: {Cron}", _settings.JobName, _settings.CronExpression);
        }
        catch (Exception ex)
        {
            logger.LogError("Fatal error while scheduling job: {JobName}. Error: {ex}", _settings.JobName, ex);
        }
    }
}