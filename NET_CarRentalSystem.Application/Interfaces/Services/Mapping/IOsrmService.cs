namespace NET_CarRentalSystem.Application.Interfaces.Services.Mapping;

public interface IOsrmService
{
    Task<List<double[]>> GetRouteCoordinatesAsync(double startLat, double startLng, double endLat, double endLng, CancellationToken ct = default);
}
