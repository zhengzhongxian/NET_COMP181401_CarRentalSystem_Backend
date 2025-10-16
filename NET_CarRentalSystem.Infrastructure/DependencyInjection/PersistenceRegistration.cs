using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Persistence.Contexts;
using NET_CarRentalSystem.Infrastructure.Persistence.Repositories;

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

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
