using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class DepositRefundService(
    IServiceProvider serviceProvider,
    IOptions<DepositRefundJobConfig> configOptions,
    ILogger<DepositRefundService> logger) : BackgroundService
{
    private readonly DepositRefundJobConfig _config = configOptions.Value;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_config.Enabled)
        {
            logger.LogInformation("[DepositRefundService] DepositRefundJob is disabled");
            return;
        }

        logger.LogInformation(
            "[DepositRefundService] Starting service. JobName={JobName}, CronExpression={CronExpression}",
            _config.JobName, _config.CronExpression);

        await Task.Delay(TimeSpan.FromSeconds(15), stoppingToken);

        using var scope = serviceProvider.CreateScope();
        var scheduleService = scope.ServiceProvider.GetRequiredService<IScheduleService<DepositRefundJob>>();

        try
        {
            await scheduleService.ScheduleJobAsync(
                _config.JobName,
                _config.CronExpression,
                null,
                stoppingToken
            );

            logger.LogInformation("[DepositRefundService] DepositRefundJob scheduled successfully");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[DepositRefundService] Error scheduling DepositRefundJob");
        }
    }
}
