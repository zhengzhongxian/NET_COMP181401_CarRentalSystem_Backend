using Quartz;

namespace NET_CarRentalSystem.Infrastructure.Interfaces;

public interface IScheduleService<TJob> where TJob : IJob
{
    Task ScheduleJobAsync(
        string jobName,
        string cronExpression, 
        JobDataMap? jobData = null, 
        CancellationToken cancellationToken = default);
    
    Task<bool> DeleteJobAsync(
        string jobName,
        CancellationToken cancellationToken = default);
    
    Task TriggerJobAsync(
        string jobName,
        JobDataMap? jobData = null, 
        CancellationToken cancellationToken = default);
}