using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Infrastructure.Services.Search;
using NET_CarRentalSystem.Shared.Constants;
using StackExchange.Redis;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection
{
    public static class CacheRegistration
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services, IConfiguration configuration)
        {
            var redisConnectionString = configuration.GetConnectionString(KeyConstants.ConnectionStrings.Redis);
            
            services.AddSingleton<IConnectionMultiplexer>(_ => 
                ConnectionMultiplexer.Connect(redisConnectionString!));
            
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = redisConnectionString;
                options.InstanceName = "Renticar_";
            });
            
            services.AddSingleton<IVehicleSearchService, VehicleSearchService>();
            
            return services;
        }
    }
}