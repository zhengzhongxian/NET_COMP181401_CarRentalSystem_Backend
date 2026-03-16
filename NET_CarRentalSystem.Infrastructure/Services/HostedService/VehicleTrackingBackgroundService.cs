using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Mapping;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Infrastructure.Hubs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.HostedService;

public class VehicleTrackingBackgroundService(
    IServiceProvider serviceProvider,
    IHubContext<NotificationHub> hubContext,
    ILogger<VehicleTrackingBackgroundService> logger) : BackgroundService
{
    private static readonly TimeSpan TrackingStateTtl = TimeSpan.FromMinutes(15);
    private static readonly TimeSpan TrackingLockTtl = TimeSpan.FromSeconds(30);
    private const string TrackingCacheKeyPrefix = "vehicle_tracking:";

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("VehicleTrackingBackgroundService starts running.");

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await ProcessTrackingsAsync(stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred executing VehicleTrackingBackgroundService.");
            }

            await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
        }
    }

    private async Task ProcessTrackingsAsync(CancellationToken ct)
    {
        using var scope = serviceProvider.CreateScope();
        var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
        var osrmService = scope.ServiceProvider.GetRequiredService<IOsrmService>();
        var cacheService = scope.ServiceProvider.GetRequiredService<ICacheService>();
        
        var activeBookings = await unitOfWork.GetReadRepository<BookingReadFlat>()
            .GetQueryable()
            .Where(b => b.Status == BookingStatus.InProgress)
            .Select(b => new { b.BookingId, b.VehicleId })
            .ToListAsync(ct);
        
        foreach (var booking in activeBookings)
        {
            var trackingKey = BuildTrackingCacheKey(booking.BookingId);
            var lockKey = $"{trackingKey}:lock";
            var lockValue = Guid.NewGuid().ToString("N");
            var lockAcquired = await cacheService.AcquireLockAsync(lockKey, lockValue, TrackingLockTtl, ct);
            if (!lockAcquired)
            {
                continue;
            }
            
            try
            {
                var state = await GetOrCreateTrackingStateAsync(cacheService, osrmService, trackingKey, booking.BookingId, ct);
                
                if (state is { Route.Count: > 0 })
                {
                    state.CurrentIndex = (state.CurrentIndex + 1) % state.Route.Count;
                    var currentCoord = state.Route[state.CurrentIndex];
                    
                    double heading = 0;
                    if (state.CurrentIndex + 1 < state.Route.Count)
                    {
                        var nextCoord = state.Route[state.CurrentIndex + 1];
                        heading = CalculateHeading(currentCoord[1], currentCoord[0], nextCoord[1], nextCoord[0]);
                    }
                    
                    await cacheService.SetStringAsync(
                        trackingKey,
                        state.ToJson(),
                        DateTime.UtcNow.Add(TrackingStateTtl),
                        ct);
                    
                    await hubContext.Clients.Groups("role_Admin", "role_Manager").SendAsync("ReceiveVehicleLocation", new
                    {
                        Id = booking.BookingId,
                        booking.VehicleId,
                        Latitude = currentCoord[1],
                        Longitude = currentCoord[0],
                        Heading = heading,
                        Speed = 45
                    }, ct);
                }
            }
            finally
            {
                var lockReleased = await cacheService.ReleaseLockAsync(lockKey, lockValue, ct);
                if (!lockReleased)
                {
                    logger.LogWarning("Failed to release tracking lock for booking {BookingId}.", booking.BookingId);
                }
            }
        }
    }

    private async Task<TrackingState> GetOrCreateTrackingStateAsync(
        ICacheService cacheService,
        IOsrmService osrmService,
        string trackingKey,
        Guid bookingId,
        CancellationToken ct)
    {
        var cachedStateJson = await cacheService.GetStringAsync(trackingKey, ct);
        if (!string.IsNullOrWhiteSpace(cachedStateJson))
        {
            var cachedState = cachedStateJson.FromJson<TrackingState>();
            if (cachedState is { Route.Count: > 0 })
            {
                return cachedState;
            }
        }
        
        // todo: Chỗ này lấy tọa độ thật từ kho và địa chỉ khách (nếu có Delivery)
        // Hiện tại mock 2 tọa độ bất kỳ ở HCM cho dễ test
        var route = await osrmService.GetRouteCoordinatesAsync(
            10.762622, 106.660172, // ĐH KHTN HCM
            10.771576, 106.698387, // Dinh Độc Lập
            ct);

        if (route.Count == 0)
        {
            logger.LogWarning("OSRM route is empty for booking {BookingId}. Using fallback route.", bookingId);
            route = BuildFallbackRoute(bookingId);
        }
        
        var newState = new TrackingState { Route = route, CurrentIndex = 0 };
        await cacheService.SetStringAsync(
            trackingKey,
            newState.ToJson(),
            DateTime.UtcNow.Add(TrackingStateTtl),
            ct);
        
        return newState;
    }

    private static string BuildTrackingCacheKey(Guid bookingId) => $"{TrackingCacheKeyPrefix}{bookingId:N}";

    private static double CalculateHeading(double lat1, double lon1, double lat2, double lon2)
    {
        var dLon = (lon2 - lon1) * Math.PI / 180;
        var y = Math.Sin(dLon) * Math.Cos(lat2 * Math.PI / 180);
        var x = Math.Cos(lat1 * Math.PI / 180) * Math.Sin(lat2 * Math.PI / 180) -
                Math.Sin(lat1 * Math.PI / 180) * Math.Cos(lat2 * Math.PI / 180) * Math.Cos(dLon);
        var brng = Math.Atan2(y, x) * 180 / Math.PI;
        return (brng + 360) % 360;
    }

    private static List<double[]> BuildFallbackRoute(Guid bookingId)
    {
        var hash = Math.Abs(bookingId.GetHashCode());
        var baseLat = 10.762622 + ((hash % 25d) * 0.0005d);
        var baseLng = 106.660172 + (((hash / 25d) % 25d) * 0.0005d);

        return
        [
            [baseLng, baseLat],
            [baseLng + 0.0012, baseLat + 0.0005],
            [baseLng + 0.0021, baseLat + 0.0015],
            [baseLng + 0.0015, baseLat + 0.0023],
            [baseLng + 0.0005, baseLat + 0.0017],
            [baseLng - 0.0002, baseLat + 0.0008],
        ];
    }

    private class TrackingState
    {
        public List<double[]> Route { get; set; } = [];
        public int CurrentIndex { get; set; }
    }
}
