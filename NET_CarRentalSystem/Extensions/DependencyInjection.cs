namespace NET_CarRentalSystem.API.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        //singleton
        services.AddSingleton<ILogger>();
        return services;
    }
}