using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

namespace NET_CarRentalSystem.API.Extensions;

public static class DbContextRegistration
{
    public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RenticarWriteDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RenticarWriteDbContext")));

        services.AddDbContext<RenticarReadDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RenticarWriteDbContext")));

        return services;
    }
}
