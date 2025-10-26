using NET_CarRentalSystem.Infrastructure.Interfaces;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class ScheduleService<TJob>(ISchedulerFactory schedulerFactory) 
    : IScheduleService<TJob> where TJob : IJob
{
    private async Task<IScheduler> GetScheduler(CancellationToken cancellationToken)
    {
        return await schedulerFactory.GetScheduler(cancellationToken);
    }
    
    private JobKey GetJobKey(string jobName)
    {
        var group = typeof(TJob).Name;
        return new JobKey(jobName, group);
    }

    public async Task ScheduleJobAsync(
        string jobName,
        string cronExpression, 
        JobDataMap? jobData = null, 
        CancellationToken cancellationToken = default)
    {
        var scheduler = await GetScheduler(cancellationToken);
        
        var jobKey = GetJobKey(jobName); 
        
        var jobBuilder = JobBuilder.Create<TJob>()
            .WithIdentity(jobKey)
            .WithDescription($"Job for {typeof(TJob).Name}");

        if (jobData is not null)
        {
            jobBuilder.UsingJobData(jobData);
        }
        
        var jobDetail = jobBuilder
            .StoreDurably()
            .Build();
        
        var triggerKey = new TriggerKey($"{jobKey.Name}-trigger", jobKey.Group);
        var trigger = TriggerBuilder.Create()
            .WithIdentity(triggerKey)
            .WithCronSchedule(cronExpression)
            .ForJob(jobKey) 
            .Build();
        
        await scheduler.AddJob(jobDetail, true, cancellationToken);
        
        if (await scheduler.CheckExists(triggerKey, cancellationToken))
        {
            await scheduler.RescheduleJob(triggerKey, trigger, cancellationToken);
        }
        else
        {
            await scheduler.ScheduleJob(trigger, cancellationToken);
        }
    }

    public async Task<bool> DeleteJobAsync(
        string jobName,
        CancellationToken cancellationToken = default)
    {
        var scheduler = await GetScheduler(cancellationToken);
        
        var jobKey = GetJobKey(jobName); 

        if (await scheduler.CheckExists(jobKey, cancellationToken))
        {
            return await scheduler.DeleteJob(jobKey, cancellationToken);
        }
        
        return false; 
    }

    public async Task TriggerJobAsync(
        string jobName,
        JobDataMap? jobData = null, 
        CancellationToken cancellationToken = default)
    {
        var scheduler = await GetScheduler(cancellationToken);
        
        var jobKey = GetJobKey(jobName); 

        if (!await scheduler.CheckExists(jobKey, cancellationToken))
        {
            return; 
        }

        if (jobData is not null)
        {
            await scheduler.TriggerJob(jobKey, jobData, cancellationToken);
        }
        else
        {
            await scheduler.TriggerJob(jobKey, cancellationToken);
        }
    }
}