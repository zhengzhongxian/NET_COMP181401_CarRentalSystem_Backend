using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Configurations.ApiClientSettings;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;
using NET_CarRentalSystem.Application.Interfaces.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Documents;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Application.Interfaces.Services.Audit;
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
using NET_CarRentalSystem.Infrastructure.Services.Audit;
using NET_CarRentalSystem.Infrastructure.Services.Ekyc;
using NET_CarRentalSystem.Infrastructure.Services.Sms;
using NET_CarRentalSystem.Application.Interfaces.Services.Ekyc;
using NET_CarRentalSystem.Application.Interfaces.Services.Mapping;
using NET_CarRentalSystem.Application.Interfaces.Services.Sms;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Infrastructure.Services.Search;
using NET_CarRentalSystem.Infrastructure.Services.Mapping;
using NET_CarRentalSystem.Application.Features.Payments.Strategies;
using NET_CarRentalSystem.Application.Common.Queue;
using NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;
using NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;
using Microsoft.Extensions.Logging;
using PayOS;
using TaskQueueKeys = NET_CarRentalSystem.Shared.Constants.KeyConstants.TaskQueueSettings;


namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region Configuration
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
        services.Configure<OverdueBookingJobConfig>(configuration.GetSection(OverdueBookingJobConfig.SectionName));
        services.Configure<DepositRefundJobConfig>(configuration.GetSection(DepositRefundJobConfig.SectionName));
        services.Configure<MinioSettings>(configuration.GetSection(MinioSettings.SectionName));
        services.Configure<MinioSettings>(configuration.GetSection(MinioSettings.SectionName));
        services.Configure<VnptEkycSettings>(configuration.GetSection(VnptEkycSettings.SectionName));
        services.Configure<SpeedSmsSettings>(configuration.GetSection(SpeedSmsSettings.SectionName));
        services.Configure<TwilioSettings>(configuration.GetSection(TwilioSettings.SectionName));
        services.Configure<GrpcServicesSettings>(configuration.GetSection(GrpcServicesSettings.SectionName));
        
        var grpcSettings = configuration.GetSection(GrpcServicesSettings.SectionName).Get<GrpcServicesSettings>()!;
        Grpc.GrpcChannelFactory.Settings(grpcSettings);
        
        services.Configure<CheckToolAliveSettings>(configuration.GetSection(CheckToolAliveSettings.SectionName));
        services.Configure<FileValidationSettings>(configuration.GetSection(FileValidationSettings.SectionName));
        services.Configure<ImpersonationSettings>(configuration.GetSection(ImpersonationSettings.SectionName));
        #endregion

        #region Audit & HttpContext
        services.AddHttpContextAccessor();
        services.AddScoped<IAuditLogService, AuditLogService>();
        #endregion

        #region Scoped Services
        services.AddScoped<ICloudinaryService, CloudinaryService>();
        services.AddScoped<IMinioService, MinioService>();
        services.AddScoped<IImageResizeService, ImageResizeService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IPayOsService, PayOsService>();
        services.AddScoped<ICreateBookingPaymentStrategy, PayOsCreateBookingPaymentStrategy>();
        services.AddScoped<ICreateBookingPaymentStrategy, NoExternalCreateBookingPaymentStrategy>();
        services.AddScoped<ICreateBookingPaymentStrategy, VnPayCreateBookingPaymentStrategy>();
        services.AddScoped<ICryptographyService, CryptographyService>();
        services.AddScoped<ICacheService, CacheService>();
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IGoogleService, GoogleService>();
        services.AddScoped<IVnPayService, VnPayService>();
        services.AddScoped<IQueryExecutor, QueryExecutor>();
        services.AddScoped<IPdfContractService, PdfContractService>();
        services.AddScoped<PaymentStatusSyncJob>();
        services.AddScoped<RefundProcessingJob>();
        services.AddScoped<ReturnDeadlineReminderJob>();
        services.AddScoped<INotificationHub, NotificationHubService>();
        services.AddScoped<DepositRefundJob>();
        services.AddScoped<IVehicleSearchService, VehicleSearchService>();
        services.AddScoped<IOsrmService, OsrmService>();

        services.AddScoped<IPaymentCommandStrategy, DepositPaymentStrategy>();
        services.AddScoped<IPaymentCommandStrategy, FinalPaymentStrategy>();
        services.AddScoped<IPaymentCommandStrategy, ViolationPaymentStrategy>();
        services.AddScoped<IPaymentCommandDispatcher, PaymentCommandDispatcher>();

        services.AddScoped<IPaymentEmailStrategy, DepositPaymentEmailStrategy>();
        services.AddScoped<IPaymentEmailStrategy, FinalPaymentEmailStrategy>();

        services.AddScoped<IRefundEmailStrategy, RefundNotificationEmailStrategy>();
        services.AddScoped<IRefundEmailStrategy, RefundSuccessEmailStrategy>();
        #endregion

        #region Http Clients
        services.AddHttpClient<IApiClient, ApiClient>();
        services.AddHttpClient<IVnptEkycService, VnptEkycService>();
        services.AddHttpClient<ISpeedSmsService, SpeedSmsService>();
        services.AddHttpClient("OsrmClient");
        services.AddHttpContextAccessor();
        #endregion

        #region Singleton Services
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
        services.AddSingleton<ITwilioSmsVerifyService, TwilioSmsVerifyService>();

        services.AddSingleton(sp =>
        {
            var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
            var config = sp.GetRequiredService<IConfiguration>();
            var logger = sp.GetRequiredService<ILogger<TaskQueue<CreateBookingCommand, (bool, string, PaymentTransactionDto?)>>>();
            var maxWorkers = config.GetValue(TaskQueueKeys.CreateBookingMaxWorkers, 5);
            var maxQueue = config.GetValue(TaskQueueKeys.CreateBookingMaxQueue, 100);

            return new TaskQueue<CreateBookingCommand, (bool, string, PaymentTransactionDto?)>(
                async (request, ct) =>
                {
                    using var scope = scopeFactory.CreateScope();
                    var mediator = scope.ServiceProvider.GetRequiredService<ISender>();
                    return await mediator.Send(request, ct);
                },
                maxWorkers, maxQueue, logger);
        });
        #endregion
        
        #region Other Services
        services.AddMemoryCache();

        services.AddAiServices();

        services.AddHostedService<CheckToolAliveService>();
        services.AddHostedService<PaymentStatusSyncService>();
        services.AddHostedService<RefundProcessingService>();
        services.AddHostedService<ReturnDeadlineReminderService>();
        services.AddHostedService<OverdueBookingService>();
        services.AddHostedService<DepositRefundService>();
        services.AddHostedService<VehicleSearchIndexInitializer>();
        services.AddHostedService<VehicleTrackingBackgroundService>();
        #endregion

        #region SignalR
        services.AddSignalR();
        #endregion

        return services;
    }
}
