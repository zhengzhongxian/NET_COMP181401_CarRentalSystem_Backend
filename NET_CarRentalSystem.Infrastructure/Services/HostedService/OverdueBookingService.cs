using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class OverdueBookingService(
    IServiceProvider serviceProvider,
    IOptions<OverdueBookingJobConfig> configOptions,
    ILogger<OverdueBookingService> logger) : BackgroundService
{
    private readonly OverdueBookingJobConfig _config = configOptions.Value;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_config.Enabled)
        {
            logger.LogInformation("[OverdueBookingService] OverdueBookingJob is disabled");
            return;
        }

        logger.LogInformation(
            "[OverdueBookingService] Starting service. JobName={JobName}, CronExpression={CronExpression}",
            _config.JobName, _config.CronExpression);

        await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

        using var scope = serviceProvider.CreateScope();
        var scheduleService = scope.ServiceProvider.GetRequiredService<IScheduleService<OverdueBookingJob>>();

        try
        {
            await scheduleService.ScheduleJobAsync(
                _config.JobName,
                _config.CronExpression,
                null,
                stoppingToken
            );

            logger.LogInformation("[OverdueBookingService] OverdueBookingJob scheduled successfully");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[OverdueBookingService] Error scheduling OverdueBookingJob");
        }
    }
}

