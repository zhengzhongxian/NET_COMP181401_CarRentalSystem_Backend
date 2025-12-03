using MassTransit;
using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Entities;


namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public sealed class RenticarWriteDbContext : RenticarBaseDbContext
{
    public RenticarWriteDbContext(
        DbContextOptions<RenticarWriteDbContext> options, 
        ICurrentUserService currentUserService) : base(options, currentUserService)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Ignore<VehicleReadFlat>();
        modelBuilder.AddInboxStateEntity();
        modelBuilder.AddOutboxMessageEntity();
        modelBuilder.AddOutboxStateEntity();
    }
}