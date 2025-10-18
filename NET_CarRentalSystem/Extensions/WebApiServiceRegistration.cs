using System.Reflection;

namespace NET_CarRentalSystem.API.Extensions;

public static class WebApiServiceRegistration
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddAutoMapper(cfg => {
            cfg.AddMaps(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
