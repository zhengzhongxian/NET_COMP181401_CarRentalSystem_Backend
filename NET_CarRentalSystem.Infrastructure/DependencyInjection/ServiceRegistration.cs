using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
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
        services.Configure<EmailSettings>(configuration.GetSection(EmailSettings.SectionName));
        services.Configure<OtpSettings>(configuration.GetSection(OtpSettings.SectionName));
        services.Configure<RsaSettings>(configuration.GetSection(RsaSettings.SectionName));
        services.Configure<AesSettings>(configuration.GetSection(AesSettings.SectionName));
        
        //add scope
        services.AddScoped<ICloudinaryService, CloudinaryService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ISecurityService, SecurityService>();
        services.AddScoped<ICacheService, CacheService>();
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IEmailService, EmailService>();

        //http
        services.AddHttpClient<IApiClient, ApiClient>();
        services.AddHttpContextAccessor();

        //add singleton
        services.AddSingleton(typeof(IScheduleService<>), typeof(ScheduleService<>));

        //add transient

        //-----Hosted Service-----
        services.AddHostedService<CheckToolAliveService>();

        return services;
    }
}
