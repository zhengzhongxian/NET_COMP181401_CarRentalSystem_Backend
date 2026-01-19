using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Configurations.ApiClientSettings;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.AI;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Documents;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Configurations;
using NET_CarRentalSystem.Infrastructure.Http;
using NET_CarRentalSystem.Infrastructure.Interfaces.Schedulers;
using NET_CarRentalSystem.Infrastructure.Persistence.Repositories;
using NET_CarRentalSystem.Infrastructure.Services.Authentication;
using NET_CarRentalSystem.Infrastructure.Services.Caching;
using NET_CarRentalSystem.Infrastructure.Services.Documents;
using NET_CarRentalSystem.Infrastructure.Services.HostedService;
using NET_CarRentalSystem.Infrastructure.Services.Notifications;
using NET_CarRentalSystem.Infrastructure.Services.Payments;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;
using NET_CarRentalSystem.Infrastructure.Services.Scheduling.Schedulers;
using NET_CarRentalSystem.Infrastructure.Services.Security;
using NET_CarRentalSystem.Infrastructure.Services.Storage;
using NET_CarRentalSystem.Infrastructure.Services.AI;
using NET_CarRentalSystem.Infrastructure.Services.Search;
using PayOS;


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
        services.Configure<GmailApiSettings>(configuration.GetSection(GmailApiSettings.SectionName));
        services.Configure<PayOsSettings>(configuration.GetSection(PayOsSettings.SectionName));
        services.Configure<PaymentSyncJob>(configuration.GetSection(PaymentSyncJob.SectionName)); 
        services.Configure<RefundProcessingJobConfig>(configuration.GetSection(RefundProcessingJobConfig.SectionName));
        services.Configure<ReturnDeadlineReminderJobConfig>(configuration.GetSection(ReturnDeadlineReminderJobConfig.SectionName));
        services.Configure<MinioSettings>(configuration.GetSection(MinioSettings.SectionName));
        services.Configure<MinioSettings>(configuration.GetSection(MinioSettings.SectionName));
        services.Configure<GeminiSettings>(configuration.GetSection(GeminiSettings.SectionName));
        services.Configure<EmbeddingSettings>(configuration.GetSection(EmbeddingSettings.SectionName));

        //add scope
        services.AddScoped<ICloudinaryService, CloudinaryService>();
        services.AddScoped<IMinioService, MinioService>();
        services.AddScoped<IImageResizeService, ImageResizeService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IPayOsService, PayOsService>();
        services.AddScoped<ICryptographyService, CryptographyService>();
        services.AddScoped<ICacheService, CacheService>();
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IGoogleService, GoogleService>();
        services.AddScoped<IVnPayService, VnPayService>();
        services.AddScoped<IQueryExecutor, QueryExecutor>();
        services.AddScoped<IPdfContractService, PdfContractService>();
        services.AddScoped<IGeminiService, GeminiService>();
        services.AddScoped<PaymentStatusSyncJob>();
        services.AddScoped<RefundProcessingJob>();
        services.AddScoped<ReturnDeadlineReminderJob>();
        services.AddScoped<INotificationHub, NotificationHubService>();

        //http
        services.AddHttpClient<IApiClient, ApiClient>();
        services.AddHttpContextAccessor();

        //add singleton
        services.AddSingleton(typeof(IScheduleService<>), typeof(ScheduleService<>));
        services.AddSingleton(sp =>
        {
            var payOsSettings = sp.GetRequiredService<IOptions<PayOsSettings>>().Value;
            return new PayOSClient(
                clientId: payOsSettings.ClientId,
                apiKey: payOsSettings.ApiKey,
                checksumKey: payOsSettings.CheckSumKey
            );
        });
        services.AddSingleton<IEmbeddingService, OnnxEmbeddingService>();
        services.AddSingleton<IVehicleSearchService, VehicleSearchService>();
        
        //add transient

        //hosted service
        services.AddHostedService<CheckToolAliveService>();
        services.AddHostedService<PaymentStatusSyncService>();
        services.AddHostedService<RefundProcessingService>();
        services.AddHostedService<ReturnDeadlineReminderService>();

        //signalR
        services.AddSignalR();

        return services;
    }
}
