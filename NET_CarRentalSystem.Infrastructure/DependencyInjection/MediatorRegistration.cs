using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class MediatorRegistration
{
    public static IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.Load("NET_CarRentalSystem.Application"));

        return services;
    }
}