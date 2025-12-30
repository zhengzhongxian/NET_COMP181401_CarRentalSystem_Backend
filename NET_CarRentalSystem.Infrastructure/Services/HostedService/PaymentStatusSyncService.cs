using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;
using NET_CarRentalSystem.Shared.Constants;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class PaymentStatusSyncService(
    IServiceProvider serviceProvider,
    IConfiguration configuration,
    ILogger<PaymentStatusSyncService> logger) : BackgroundService
{
    private readonly PaymentSyncJob _paymentSyncConfig = configuration
        .GetSection(KeyConstants.ConfigurationSections.PaymentSyncJob)
        .Get<PaymentSyncJob>() ?? new PaymentSyncJob
        {
            JobName = "PaymentStatusSync",
            CronExpression = "0 */5 * * * ?",
            Enabled = true,
            MaxRetry = 5,
            TimeoutInSeconds = 30
        };

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_paymentSyncConfig.Enabled)
        {
            logger.LogInformation("PaymentStatusSyncService is disabled");
            return;
        }

        try
        {

            logger.LogInformation("PaymentStatusSyncService starting: JobName={JobName}, Cron={Cron}", 
                _paymentSyncConfig.JobName, _paymentSyncConfig.CronExpression);

            using var scope = serviceProvider.CreateScope();
            
            PaymentStatusSyncJob.SetServiceProvider(scope.ServiceProvider);
            
            var scheduleService = scope.ServiceProvider.GetRequiredService<IScheduleService<PaymentStatusSyncJob>>();
            
            var jobDataMap = new JobDataMap
            {
                { "MaxRetry", _paymentSyncConfig.MaxRetry }
            };

            await scheduleService.ScheduleJobAsync(
                _paymentSyncConfig.JobName!,
                _paymentSyncConfig.CronExpression!,
                jobDataMap,
                stoppingToken
            );

            logger.LogInformation("PaymentStatusSyncService scheduled successfully: JobName={JobName}", _paymentSyncConfig.JobName);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error while scheduling PaymentStatusSyncService, but service will continue running");
        }
    }
}

