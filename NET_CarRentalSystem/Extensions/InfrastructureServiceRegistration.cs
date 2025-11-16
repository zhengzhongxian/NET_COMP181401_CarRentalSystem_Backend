using NET_CarRentalSystem.Infrastructure.DependencyInjection;

namespace NET_CarRentalSystem.API.Extensions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddProjectServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPersistenceServices(configuration);
        services.AddMediatorServices();
        services.AddInfrastructureServices(configuration);
        services.AddJobServices();
        services.AddCacheServices(configuration);

        return services;
    }
}
