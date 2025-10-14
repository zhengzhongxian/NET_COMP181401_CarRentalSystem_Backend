using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class PersistenceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<RenticarWriteDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RenticarWriteDbContext")));

        services.AddDbContext<RenticarReadDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RenticarReadDbContext")));

        return services;
    }
}
