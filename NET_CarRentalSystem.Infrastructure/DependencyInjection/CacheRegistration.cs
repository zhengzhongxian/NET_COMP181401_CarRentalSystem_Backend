using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            
            // Phase 5.2: Connection Pooling with optimized configuration
            var configOptions = ConfigurationOptions.Parse(redisConnectionString!);
            configOptions.AbortOnConnectFail = false;           
            configOptions.ConnectRetry = 3;                   
            configOptions.ConnectTimeout = 5000;               
            configOptions.SyncTimeout = 3000;            
            configOptions.AsyncTimeout = 5000; 
            configOptions.ReconnectRetryPolicy = new ExponentialRetry(5000);
            configOptions.SocketManager = SocketManager.ThreadPool;
            
            services.AddSingleton<IConnectionMultiplexer>(sp =>
            {
                var logger = sp.GetService<ILogger<ConnectionMultiplexer>>();
                var connection = ConnectionMultiplexer.Connect(configOptions);
                
                connection.ConnectionFailed += (_, e) =>
                    logger?.LogWarning("Redis connection failed: {FailureType}", e.FailureType);
                connection.ConnectionRestored += (_, e) =>
                    logger?.LogInformation("Redis connection restored: {EndPoint}", e.EndPoint);
                    
                return connection;
            });
            
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = redisConnectionString;
                options.InstanceName = "Renticar_";
            });
            
            return services;
        }
    }
}