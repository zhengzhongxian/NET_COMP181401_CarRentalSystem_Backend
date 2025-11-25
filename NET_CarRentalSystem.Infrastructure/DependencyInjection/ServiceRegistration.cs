using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Configurations.ApiClientSettings;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Infrastructure.Http;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Authentication;
using NET_CarRentalSystem.Infrastructure.Services.Caching;
using NET_CarRentalSystem.Infrastructure.Services.HostedService;
using NET_CarRentalSystem.Infrastructure.Services.Notifications;
using NET_CarRentalSystem.Infrastructure.Services.Payments;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Security;
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
        services.Configure<CorsSettings>(configuration.GetSection(CorsSettings.SectionName));
        services.Configure<GoogleSettings>(configuration.GetSection(GoogleSettings.SectionName));
        services.Configure<ResetPasswordSettings>(configuration.GetSection(ResetPasswordSettings.SectionName));
        services.Configure<MyApiSettings>(configuration.GetSection(MyApiSettings.SectionName));
        services.Configure<VnPaySettings>(configuration.GetSection(VnPaySettings.SectionName));

        //add scope
        services.AddScoped<ICloudinaryService, CloudinaryService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<ICryptographyService, CryptographyService>();
        services.AddScoped<ICacheService, CacheService>();
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IGoogleService, GoogleService>();
        services.AddScoped<IVnPayService, VnPayService>();

        //http
        services.AddHttpClient<IApiClient, ApiClient>();
        services.AddHttpContextAccessor();

        //add singleton
        services.AddSingleton(typeof(IScheduleService<>), typeof(ScheduleService<>));

        //add transient

        //hosted service
        services.AddHostedService<CheckToolAliveService>();

        return services;
    }
}
