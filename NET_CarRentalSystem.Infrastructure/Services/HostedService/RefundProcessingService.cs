using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class RefundProcessingService(
    IServiceProvider serviceProvider,
    IOptions<RefundProcessingJobConfig> configOptions,
    ILogger<RefundProcessingService> logger) : BackgroundService
{
    private readonly RefundProcessingJobConfig _config = configOptions.Value;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_config.Enabled)
        {
            logger.LogInformation("[RefundProcessingService] RefundProcessingJob is disabled");
            return;
        }

        logger.LogInformation(
            "[RefundProcessingService] Starting RefundProcessingService. JobName={JobName}, CronExpression={CronExpression}",
            _config.JobName, _config.CronExpression);

        await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

        using var scope = serviceProvider.CreateScope();
        var scheduleService = scope.ServiceProvider.GetRequiredService<IScheduleService<RefundProcessingJob>>();

        try
        {
            var jobDataMap = new JobDataMap
            {
                { "MaxRetryAttempts", _config.MaxRetryAttempts },
                { "RetryDelayMs", _config.RetryDelayMs },
                { "BatchSize", _config.BatchSize }
            };

            await scheduleService.ScheduleJobAsync(
                _config.JobName,
                _config.CronExpression,
                jobDataMap,
                stoppingToken
            );

            logger.LogInformation("[RefundProcessingService] RefundProcessingJob scheduled successfully");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[RefundProcessingService] Error scheduling RefundProcessingJob");
        }
    }
}

