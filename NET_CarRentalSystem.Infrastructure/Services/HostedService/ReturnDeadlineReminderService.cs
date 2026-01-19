using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class ReturnDeadlineReminderService(
    IServiceProvider serviceProvider,
    IOptions<ReturnDeadlineReminderJobConfig> configOptions,
    ILogger<ReturnDeadlineReminderService> logger) : BackgroundService
{
    private readonly ReturnDeadlineReminderJobConfig _config = configOptions.Value;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_config.Enabled)
        {
            logger.LogInformation("[ReturnDeadlineReminderService] ReturnDeadlineReminderJob is disabled");
            return;
        }

        logger.LogInformation(
            "[ReturnDeadlineReminderService] Starting service. JobName={JobName}, CronExpression={CronExpression}, ReminderMinutes={ReminderMinutes}",
            _config.JobName, _config.CronExpression, _config.ReminderMinutesBefore);

        await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);

        using var scope = serviceProvider.CreateScope();
        var scheduleService = scope.ServiceProvider.GetRequiredService<IScheduleService<ReturnDeadlineReminderJob>>();

        try
        {
            await scheduleService.ScheduleJobAsync(
                _config.JobName,
                _config.CronExpression,
                null,
                stoppingToken
            );

            logger.LogInformation("[ReturnDeadlineReminderService] ReturnDeadlineReminderJob scheduled successfully");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[ReturnDeadlineReminderService] Error scheduling ReturnDeadlineReminderJob");
        }
    }
}
