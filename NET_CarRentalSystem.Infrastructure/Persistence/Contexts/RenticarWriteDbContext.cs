using Microsoft.EntityFrameworkCore;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public class RenticarWriteDbContext : RenticarBaseDbContext
{
    public RenticarWriteDbContext(DbContextOptions<RenticarWriteDbContext> options)
        : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
    }
}