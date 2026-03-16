using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public sealed class RenticarReadDbContext : RenticarBaseDbContext
{
    public DbSet<VehicleReadFlat> VehicleReadFlats => Set<VehicleReadFlat>();
    public DbSet<BookingReadFlat> BookingReadFlats => Set<BookingReadFlat>();
    
    public RenticarReadDbContext(
        DbContextOptions<RenticarReadDbContext> options, 
        ICurrentUserService currentUserService) : base(options, currentUserService)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            modelBuilder.Entity(entityType.ClrType).HasQueryFilter(null);
            
            if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
            {
                 modelBuilder.Entity(entityType.ClrType).HasQueryFilter(CreateSoftDeleteFilter(entityType.ClrType));
            }

            foreach (var fk in entityType.GetForeignKeys().ToList())
            {
                entityType.RemoveForeignKey(fk);
            }
            
            foreach (var property in entityType.GetNavigations().ToList().Select(navigation => navigation.PropertyInfo).OfType<PropertyInfo>())
            {
                modelBuilder.Entity(entityType.ClrType).Ignore(property.Name);
            }
            
            foreach (var skipNav in entityType.GetSkipNavigations().ToList())
            {
                entityType.RemoveSkipNavigation(skipNav);
            }
        }
    }

    private static LambdaExpression CreateSoftDeleteFilter(Type type)
    {
        var parameter = Expression.Parameter(type, "e");
        var property = Expression.Property(parameter, nameof(ISoftDelete.IsDeleted));
        var constant = Expression.Constant(false);
        var equality = Expression.Equal(property, constant);
        return Expression.Lambda(equality, parameter);
    }
}
