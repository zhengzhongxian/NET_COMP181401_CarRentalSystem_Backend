using Microsoft.EntityFrameworkCore;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public class RenticarReadDbContext : RenticarBaseDbContext
{
    public RenticarReadDbContext(DbContextOptions<RenticarReadDbContext> options)
        : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
}