using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public sealed class RenticarReadDbContext : RenticarBaseDbContext
{
    public RenticarReadDbContext(
        DbContextOptions<RenticarReadDbContext> options, 
        ICurrentUserService currentUserService) : base(options, currentUserService)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
}