using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Infrastructure.BackgroundJobs;
using NET_CarRentalSystem.Infrastructure.Interfaces;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.HostedService;

public class CheckToolAliveService(
    IServiceProvider serviceProvider, 
    IConfiguration configuration,
    ILogger<CheckToolAliveService> logger) : BackgroundService
{
    string _jobName = configuration.GetValue<string>(KeyConstants.Quartz.CheckToolAlive.JobName) ?? "CheckToolAlive";
    string _cronExp = configuration.GetValue<string>(KeyConstants.Quartz.CheckToolAlive.CronExpression) ?? "0 * * * * ?";
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            logger.LogInformation("Bắt đầu lên lịch cho job: {JobName}", _jobName);

            using var scope = serviceProvider.CreateScope();
            var job = scope.ServiceProvider
                .GetRequiredService<IScheduleService<CheckToolAliveJob>>();
                
            await job.ScheduleJobAsync(
                _jobName,
                _cronExp,
                null,
                stoppingToken
            );
            
            logger.LogInformation("Đã lên lịch thành công cho job: {JobName} với cron: {Cron}", _jobName, _cronExp);
        }
        catch (Exception ex)
        {
            logger.LogError("Lỗi nghiêm trọng khi lên lịch cho job: {JobName}. Error: {ex}", _jobName, ex);
        }
    }
}