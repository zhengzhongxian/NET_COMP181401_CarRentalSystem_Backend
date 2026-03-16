using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Mapping;
using NET_CarRentalSystem.Application.Models.Mapping;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Infrastructure.Services.Mapping;

public class OsrmService(IHttpClientFactory httpClientFactory, IMemoryCache memoryCache, ILogger<OsrmService> logger) : IOsrmService
{
    private const string OsrmBaseUrl = "http://router.project-osrm.org/route/v1/driving/";

    public async Task<List<double[]>> GetRouteCoordinatesAsync(double startLat, double startLng, double endLat, double endLng, CancellationToken ct = default)
    {
        var cacheKey = $"osrm_route_{startLat}_{startLng}_{endLat}_{endLng}";
        if (memoryCache.TryGetValue(cacheKey, out List<double[]>? cachedCoordinates) && cachedCoordinates != null)
        {
            return cachedCoordinates;
        }

        try
        {
            var client = httpClientFactory.CreateClient("OsrmClient");
            var url = $"{OsrmBaseUrl}{startLng},{startLat};{endLng},{endLat}?geometries=geojson&overview=full";
            
            var response = await client.GetAsync(url, ct);
            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync(ct);
            var result = jsonString.FromJson<OsrmResponse>();

            if (result?.Routes is { Count: > 0 })
            {
                var coordinates = result.Routes[0].Geometry.Coordinates;
                if (coordinates.Count > 0)
                {
                    memoryCache.Set(cacheKey, coordinates, TimeSpan.FromDays(1));
                    return coordinates;
                }
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to get route coordinates from OSRM");
        }

        return [];
    }
}
