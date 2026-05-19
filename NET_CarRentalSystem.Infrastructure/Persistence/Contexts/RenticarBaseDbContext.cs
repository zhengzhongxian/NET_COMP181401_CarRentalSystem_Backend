using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Entities;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.Audit;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public abstract class RenticarBaseDbContext(
    DbContextOptions options,
    ICurrentUserService currentUserService,
    IAuditLogService auditLogService,
    IHttpContextAccessor httpContextAccessor) : DbContext(options)
{
    private static readonly HashSet<string> ExcludedEntities =
    [
        nameof(TransactionProcessingLog),
        nameof(RefundProcessingLog),
        nameof(WebhookLog),
        nameof(UserSession)
    ];
    
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();
    public DbSet<VehicleCategory> VehicleCategories => Set<VehicleCategory>();
    public DbSet<Fuel> Fuels => Set<Fuel>();
    public DbSet<Transmission> Transmissions => Set<Transmission>();
    public DbSet<Location> Locations => Set<Location>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<BookingImage> BookingImages => Set<BookingImage>();
    public DbSet<PaymentTransaction> PaymentTransactions => Set<PaymentTransaction>();
    public DbSet<TransactionProcessingLog> TransactionProcessingLogs => Set<TransactionProcessingLog>();
    public DbSet<RefundRequest> RefundRequests => Set<RefundRequest>();
    public DbSet<RefundProcessingLog> RefundProcessingLogs => Set<RefundProcessingLog>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<RoleClaim> RoleClaims => Set<RoleClaim>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<UserClaim> UserClaims => Set<UserClaim>();
    public DbSet<UserLogin> UserLogins => Set<UserLogin>();
    public DbSet<UserSession> UserSessions => Set<UserSession>();
    public DbSet<SystemSetting> SystemSettings => Set<SystemSetting>();
    public DbSet<WebhookLog> WebhookLogs => Set<WebhookLog>();
    public DbSet<VehicleModel> VehicleModels => Set<VehicleModel>();
    public DbSet<VehicleImage> VehicleImages => Set<VehicleImage>();
    public DbSet<VehicleAttribute> VehicleAttributes => Set<VehicleAttribute>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly(), 
            type => 
            {
                var configInterface = type.GetInterfaces().FirstOrDefault(i => 
                    i.IsGenericType && 
                    i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

                if (configInterface == null) return false;
                
                var entityType = configInterface.GetGenericArguments()[0];
                
                return this is not RenticarWriteDbContext || !typeof(IReadEntity).IsAssignableFrom(entityType);
            }
        );

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var entityBuilder = modelBuilder.Entity(entityType.ClrType);

            if (typeof(IRowVersion).IsAssignableFrom(entityType.ClrType))
            {
                entityBuilder.Property(nameof(IRowVersion.RowVersion))
                    .HasColumnName("row_version")
                    .IsRowVersion();
            }

            if (typeof(IAuditable).IsAssignableFrom(entityType.ClrType))
            {
                entityBuilder.Property(nameof(IAuditable.CreatedAt)).HasColumnName("created_at");
                entityBuilder.Property(nameof(IAuditable.CreatedBy)).HasColumnName("created_by");
                entityBuilder.Property(nameof(IAuditable.UpdatedAt)).HasColumnName("updated_at");
                entityBuilder.Property(nameof(IAuditable.UpdatedBy)).HasColumnName("updated_by");
            }

            if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
            {
                entityBuilder.Property(nameof(ISoftDelete.IsDeleted)).HasColumnName("is_deleted");
                entityBuilder.Property(nameof(ISoftDelete.DeletedAt)).HasColumnName("deleted_at");
                entityBuilder.Property(nameof(ISoftDelete.DeletedBy)).HasColumnName("deleted_by");

                entityBuilder.HasQueryFilter(CreateSoftDeleteFilter(entityType.ClrType));
            }
        }
    }

    public override int SaveChanges()
    {
        var auditEntries = CaptureAuditEntries();
        UpdateAuditFields();
        var result = base.SaveChanges();
        auditLogService.PublishAuditLogs(auditEntries);
        return result;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var auditEntries = CaptureAuditEntries();
        UpdateAuditFields();
        var result = await base.SaveChangesAsync(cancellationToken);
        auditLogService.PublishAuditLogs(auditEntries);
        return result;
    }

    private List<AuditLog> CaptureAuditEntries()
    {
        ChangeTracker.DetectChanges();
        var auditLogs = new List<AuditLog>();

        var userId = currentUserService.GetUserId()?.ToString();
        var httpContext = httpContextAccessor.HttpContext;
        var ipAddress = httpContext?.Connection.RemoteIpAddress?.ToString();
        var requestPath = httpContext?.Request.Path.ToString();

        foreach (var entry in ChangeTracker.Entries<IAuditable>())
        {
            if (entry.State is EntityState.Detached or EntityState.Unchanged)
                continue;

            var entityName = entry.Entity.GetType().Name;
            
            // Skip noisy entities
            if (ExcludedEntities.Contains(entityName))
                continue;

            var entityId = entry.Property("Id").CurrentValue?.ToString() ?? "N/A";

            var audit = new AuditLog
            {
                Action = entry.State.ToString(),
                EntityName = entityName,
                EntityId = entityId,
                UserId = userId,
                IpAddress = ipAddress,
                RequestPath = requestPath,
                Timestamp = DateTime.UtcNow
            };

            switch (entry.State)
            {
                case EntityState.Added:
                    audit.NewValues = SerializeProperties(
                        entry.Properties
                            .Where(p => p.CurrentValue != null)
                            .ToDictionary(p => p.Metadata.Name, p => p.CurrentValue));
                    break;

                case EntityState.Modified:
                    var changedProps = entry.Properties
                        .Where(p => p.IsModified)
                        .ToList();

                    audit.ChangedProperties = string.Join(", ", changedProps.Select(p => p.Metadata.Name));
                    audit.OldValues = SerializeProperties(
                        changedProps.ToDictionary(p => p.Metadata.Name, p => p.OriginalValue));
                    audit.NewValues = SerializeProperties(
                        changedProps.ToDictionary(p => p.Metadata.Name, p => p.CurrentValue));
                    break;

                case EntityState.Deleted:
                    audit.OldValues = SerializeProperties(
                        entry.Properties
                            .Where(p => p.OriginalValue != null)
                            .ToDictionary(p => p.Metadata.Name, p => p.OriginalValue));
                    break;
            }

            auditLogs.Add(audit);
        }

        return auditLogs;
    }

    private static string? SerializeProperties(Dictionary<string, object?> properties)
    {
        try
        {
            return properties.Count == 0 ? null : properties.ToJson();
        }
        catch
        {
            return null;
        }
    }

    private void UpdateAuditFields()
    {
        var userId = currentUserService.GetUserId()?.ToString();
        var currentTime = DateTime.UtcNow;

        foreach (var entry in ChangeTracker.Entries<IAuditable>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedAt = currentTime;
                    entry.Entity.CreatedBy = userId;
                    entry.Entity.UpdatedAt = currentTime;
                    entry.Entity.UpdatedBy = userId;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedAt = currentTime;
                    entry.Entity.UpdatedBy = userId;
                    entry.Property(e => e.CreatedAt).IsModified = false;
                    entry.Property(e => e.CreatedBy).IsModified = false;
                    break;
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
