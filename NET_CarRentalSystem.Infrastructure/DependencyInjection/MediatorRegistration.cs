using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Shared.Constants;
using System.Reflection;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class MediatorRegistration
{
    public static IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.Load(AppConstants.Architecture.ApplicationLayer));

        return services;
    }
}