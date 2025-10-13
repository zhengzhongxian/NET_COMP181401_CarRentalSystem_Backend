using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public class RenticarReadDbContext : RenticarWriteDbContext
{
    public RenticarReadDbContext(DbContextOptions<RenticarWriteDbContext> options)
        : base(options) => ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
}
