using NET_CarRentalSystem.Application.DependencyInjection.Mediator;

namespace NET_CarRentalSystem.API.Extensions;

public static class AplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddMediatorServices();

        return services;
    }
}

