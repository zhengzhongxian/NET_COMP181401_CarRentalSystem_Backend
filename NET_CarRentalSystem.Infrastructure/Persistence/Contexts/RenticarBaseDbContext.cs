using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Entities;
using System.Linq.Expressions;
using System.Reflection;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public abstract class RenticarBaseDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<VehicleCategory> VehicleCategories => Set<VehicleCategory>();
    public DbSet<Fuel> Fuels => Set<Fuel>();
    public DbSet<Transmission> Transmissions => Set<Transmission>();
    public DbSet<Location> Locations => Set<Location>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<VehicleImage> VehicleImages => Set<VehicleImage>();
    public DbSet<VehicleAttribute> VehicleAttributes => Set<VehicleAttribute>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Customer> Customers => Set<Customer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
            {
                modelBuilder.Entity(entityType.ClrType)
                    .HasQueryFilter(CreateSoftDeleteFilter(entityType.ClrType));
            }
        }
    }

    private static LambdaExpression CreateSoftDeleteFilter(Type type)
    {
        var parameter = Expression.Parameter(type, "e");
        var property = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
        var constant = Expression.Constant(false);
        var equality = Expression.Equal(property, constant);
        return Expression.Lambda(equality, parameter);
    }
}