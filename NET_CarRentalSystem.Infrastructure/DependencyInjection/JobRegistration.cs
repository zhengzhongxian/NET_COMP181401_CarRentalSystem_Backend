using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Infrastructure.BackgroundJobs;
using Quartz;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class JobRegistration
{
    public static void AddJobServices(this IServiceCollection services)
    {
        services.AddQuartz(q =>
        {
            q.UseSimpleTypeLoader();
            q.UseInMemoryStore();
        });
        
        services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
        
        //di job
        services.AddTransient<CheckToolAliveJob>();
    }
}
