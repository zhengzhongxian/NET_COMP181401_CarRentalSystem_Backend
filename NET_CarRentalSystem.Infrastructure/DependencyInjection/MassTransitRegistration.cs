using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Features.Bookings.Consumers;
using NET_CarRentalSystem.Application.Features.Fuels.Consumers;
using NET_CarRentalSystem.Application.Features.Locations.Consumers;
using NET_CarRentalSystem.Application.Features.Payments.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Consumers;
using NET_CarRentalSystem.Application.Features.Webhooks.Consumers;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using RabbitKeys = NET_CarRentalSystem.Shared.Constants.KeyConstants.RabbitMq;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection
{
    public static class MassTransitRegistration
    {
        public static IServiceCollection AddMassTransitServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumers();
                
                x.AddEntityFrameworkOutbox<RenticarWriteDbContext>(o =>
                {
                    o.QueryDelay = TimeSpan.FromSeconds(1);
                    o.UseSqlServer();
                    o.UseBusOutbox(); 
                });
                
                x.UsingRabbitMq((context, cfg) =>
                {
                    var host = configuration.GetValue<string>(RabbitKeys.Host);
                    var port = configuration.GetValue<ushort?>(RabbitKeys.Port); 
                    var virtualHost = configuration.GetValue<string>(RabbitKeys.VirtualHost);
                    var username = configuration.GetValue<string>(RabbitKeys.Username);
                    var password = configuration.GetValue<string>(RabbitKeys.Password);

                    if (string.IsNullOrWhiteSpace(host))
                        throw new InvalidOperationException($"Missing required configuration: {RabbitKeys.Host}");

                    if (!port.HasValue)
                        throw new InvalidOperationException($"Missing required configuration: {RabbitKeys.Port}");

                    if (string.IsNullOrWhiteSpace(virtualHost))
                        throw new InvalidOperationException($"Missing required configuration: {RabbitKeys.VirtualHost}");

                    if (string.IsNullOrWhiteSpace(username))
                        throw new InvalidOperationException($"Missing required configuration: {RabbitKeys.Username}");

                    if (string.IsNullOrWhiteSpace(password))
                        throw new InvalidOperationException($"Missing required configuration: {RabbitKeys.Password}");
                    
                    cfg.Host(host, port.Value, virtualHost, h => 
                    { 
                        h.Username(username);
                        h.Password(password);
                    });
                    

                    cfg.UseMessageRetry(r => 
                    {
                        r.Intervals(
                            TimeSpan.FromSeconds(1),
                            TimeSpan.FromSeconds(5),
                            TimeSpan.FromSeconds(15),
                            TimeSpan.FromSeconds(30)
                        );
                    });
                    
                    cfg.UseDelayedRedelivery(r =>
                    {
                        r.Intervals(
                            TimeSpan.FromMinutes(5),
                            TimeSpan.FromMinutes(30),
                            TimeSpan.FromHours(1)
                        );
                    });

                    cfg.ConfigureEndpoints(context);
                });
            });

            return services;
        }

        private static void AddConsumers(this IBusRegistrationConfigurator configurator)
        {
            configurator.AddConsumer<FuelCreatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatCreatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatDeletedConsumer>();
            configurator.AddConsumer<VehicleReadFlatUpdatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatThumbnailUpdatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatImagesUpdatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatAttributesUpdatedConsumer>();
            configurator.AddConsumer<VehicleReadFlatModelsUpdatedConsumer>();
            configurator.AddConsumer<LocationCreatedConsumer>();
            configurator.AddConsumer<LocationDeletedConsumer>();
            configurator.AddConsumer<LocationReadFlatThumbnailUpdatedConsumer>();
            configurator.AddConsumer<LocationReadFlatUpdatedConsumer>();
            configurator.AddConsumer<BookingReadFlatCreatedConsumer>();
            configurator.AddConsumer<BookingReadFlatUpdatedConsumer>();
            configurator.AddConsumer<PaymentEmailEventConsumer>();
            configurator.AddConsumer<RefundEmailEventConsumer>();
            configurator.AddConsumer<RefundProcessingFailedAlertConsumer>();
            configurator.AddConsumer<PendingTransactionsRefundNoticeConsumer>();

            configurator.AddConsumer<PaymentWebhookConsumer>(cfg =>
            {
                cfg.ConcurrentMessageLimit = 5;
            });

            configurator.AddConsumer<PaymentSyncConsumer>(cfg =>
            {
                cfg.ConcurrentMessageLimit = 10;
            });
        }
    }
}