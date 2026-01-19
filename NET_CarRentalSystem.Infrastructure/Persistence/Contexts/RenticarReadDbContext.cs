using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
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
}