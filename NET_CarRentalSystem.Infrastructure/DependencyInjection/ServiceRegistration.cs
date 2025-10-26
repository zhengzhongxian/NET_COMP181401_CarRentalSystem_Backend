using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Interfaces.Storage;
using NET_CarRentalSystem.Infrastructure.Configuration;
using NET_CarRentalSystem.Infrastructure.HostedService;
using NET_CarRentalSystem.Infrastructure.Interfaces;
using NET_CarRentalSystem.Infrastructure.Services;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<CloudinarySettings>(configuration.GetSection(CloudinarySettings.SectionName));
        services.AddScoped<ICloudinaryService, CloudinaryService>();

        services.AddHttpClient<IApiClient, ApiClient>();
        
        services.AddSingleton(typeof(IScheduleService<>), typeof(ScheduleService<>));
        
        //-----Hosted Service-----
        services.AddHostedService<CheckToolAliveService>();
        
        return services;
    }
}
