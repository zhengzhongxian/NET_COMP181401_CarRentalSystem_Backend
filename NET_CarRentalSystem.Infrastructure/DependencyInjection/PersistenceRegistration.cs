using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Infrastructure.Persistence.Repositories;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.DependencyInjection;

public static class PersistenceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<RenticarWriteDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(KeyConstants.ConnectionStrings.RenticarWriteDbContext)));

        services.AddDbContext<RenticarReadDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(KeyConstants.ConnectionStrings.RenticarReadDbContext)));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
