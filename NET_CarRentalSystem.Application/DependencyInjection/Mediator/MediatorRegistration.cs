using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NET_CarRentalSystem.Application.DependencyInjection.Mediator;

public static class MediatorRegistration
{
    public static IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
