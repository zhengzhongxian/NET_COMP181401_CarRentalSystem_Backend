namespace NET_CarRentalSystem.Application.Interfaces.Services.Search;

public interface IVehicleSearchService
{
    /// <summary>
    /// Index a vehicle into Redis for hybrid search.
    /// </summary>
    Task IndexVehicleAsync(
        Guid vehicleId,
        string searchText,
        byte[] embedding,
        string? manufacturer,
        string? model,
        string? title,
        string? category,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a vehicle from the search index.
    /// </summary>
    Task RemoveVehicleAsync(Guid vehicleId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Hybrid search: combine vector KNN with optional keyword filter.
    /// Returns list of (vehicleId, score) ordered by relevance.
    /// </summary>
    Task<List<(Guid VehicleId, double Score)>> HybridSearchAsync(
        byte[] queryVector,
        string? keyword,
        int topK = 20,
        CancellationToken cancellationToken = default);
}
