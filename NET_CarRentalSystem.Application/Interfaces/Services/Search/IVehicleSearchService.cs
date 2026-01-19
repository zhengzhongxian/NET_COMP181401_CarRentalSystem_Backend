using NET_CarRentalSystem.Application.Models.Search;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Search;

/// <summary>
/// Service for vehicle full-text search using RediSearch
/// </summary>
public interface IVehicleSearchService
{
    Task CreateIndexIfNotExistsAsync(CancellationToken ct = default);
    
    Task CreateVectorIndexIfNotExistsAsync(CancellationToken ct = default);
    
    Task IndexVehicleAsync(VehicleSearchDocument document, CancellationToken ct = default);
    
    Task RemoveVehicleAsync(Guid vehicleId, CancellationToken ct = default);
    
    Task<VehicleSearchResult> SearchAsync(VehicleSearchParams searchParams, CancellationToken ct = default);
    
    Task<VehicleSearchResult> TwoStageSearchAsync(VehicleSearchParams searchParams, CancellationToken ct = default);
    
    Task<SearchFacets> GetSearchFacetsAsync(VehicleSearchParams? searchParams = null, CancellationToken ct = default);
    
    Task<bool> IsAvailableAsync(CancellationToken ct = default);
    
    Task<bool> IsVectorSearchAvailableAsync(CancellationToken ct = default);
}