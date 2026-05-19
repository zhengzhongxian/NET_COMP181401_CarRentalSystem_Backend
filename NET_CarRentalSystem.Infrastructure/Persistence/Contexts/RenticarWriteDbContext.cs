using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services.Audit;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;


namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public sealed class RenticarWriteDbContext : RenticarBaseDbContext
{
    public RenticarWriteDbContext(
        DbContextOptions<RenticarWriteDbContext> options, 
        ICurrentUserService currentUserService,
        IAuditLogService auditLogService,
        IHttpContextAccessor httpContextAccessor) : base(options, currentUserService, auditLogService, httpContextAccessor)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.AddInboxStateEntity();
        modelBuilder.AddOutboxMessageEntity();
        modelBuilder.AddOutboxStateEntity();
    }
}