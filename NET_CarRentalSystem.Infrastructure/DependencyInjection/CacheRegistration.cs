using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection
{
    public static class CacheRegistration
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetConnectionString(KeyConstants.ConnectionStrings.Redis);
                options.InstanceName = "Renticar_";
            });
            
            return services;
        }
    }
}