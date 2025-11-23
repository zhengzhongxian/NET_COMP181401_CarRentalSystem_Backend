using Microsoft.EntityFrameworkCore;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;


namespace NET_CarRentalSystem.Infrastructure.Persistence.Contexts;

public sealed class RenticarWriteDbContext : RenticarBaseDbContext
{
    public RenticarWriteDbContext(
        DbContextOptions<RenticarWriteDbContext> options, 
        ICurrentUserService currentUserService) : base(options, currentUserService)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
    }
}