using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Infrastructure.Configuration;
using NET_CarRentalSystem.Infrastructure.HostedService;
using NET_CarRentalSystem.Infrastructure.Interfaces;
using NET_CarRentalSystem.Infrastructure.Services;
using NET_CarRentalSystem.Infrastructure.Services.Storage;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<CloudinarySettings>(configuration.GetSection(CloudinarySettings.SectionName));
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        //add scope
        services.AddScoped<ICloudinaryService, CloudinaryService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ICacheService, CacheService>();
        services.AddScoped<IIdentityService, IdentityService>();
        
        //http
        services.AddHttpClient<IApiClient, ApiClient>();
        
        //add singleton
        services.AddSingleton(typeof(IScheduleService<>), typeof(ScheduleService<>));
        
        //add transient
        
        //-----Hosted Service-----
        services.AddHostedService<CheckToolAliveService>();
        
        return services;
    }
}
