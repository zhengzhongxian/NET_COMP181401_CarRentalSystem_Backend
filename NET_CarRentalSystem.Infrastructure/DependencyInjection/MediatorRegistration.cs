using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Shared.Constants;
using System.Reflection;
using FluentValidation;
using NET_CarRentalSystem.Application.Common.Behaviors;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class MediatorRegistration
{
    public static IServiceCollection AddMediatorServices(this IServiceCollection services)
    {
        var applicationAssembly = Assembly.Load(AppConstants.Architecture.ApplicationLayer);
        
        services.AddMediatR(applicationAssembly);
        services.AddValidatorsFromAssembly(applicationAssembly);
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        
        return services;
    }
}