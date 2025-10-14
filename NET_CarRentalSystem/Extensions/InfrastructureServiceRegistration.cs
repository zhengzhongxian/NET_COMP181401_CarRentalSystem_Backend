using NET_CarRentalSystem.Infrastructure.DependencyInjection;

namespace NET_CarRentalSystem.API.Extensions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddPersistenceServices(configuration);

        return services;
    }
}
