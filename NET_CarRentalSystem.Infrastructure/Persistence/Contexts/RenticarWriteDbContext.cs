using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Entities;
using System.Linq.Expressions;
using System.Reflection;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

/// <summary>
/// dbcontext này dùng cho thêm create, update, delete nha Minh, mình xóa mềm chứ ko xóa thẳng.
/// Đây là nguồn chân lý cho cấu trúc database.
/// </summary>
public class RenticarWriteDbContext(DbContextOptions<RenticarWriteDbContext> options) : DbContext(options)
{
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    public DbSet<VehicleCategory> VehicleCategories => Set<VehicleCategory>();

    public DbSet<Fuel> Fuels => Set<Fuel>();

    public DbSet<Transmission> Transmissions => Set<Transmission>();

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
