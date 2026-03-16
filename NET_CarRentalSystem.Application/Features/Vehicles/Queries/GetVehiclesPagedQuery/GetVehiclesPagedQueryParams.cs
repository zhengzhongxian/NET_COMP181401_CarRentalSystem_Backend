using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

public class GetVehiclesPagedQueryParams : PagedParams
{
    public Guid? CategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? LocationId { get; set; }

    public string? Status { get; set; }

    public decimal? MinPrice { get; set; }

    public decimal? MaxPrice { get; set; }
    
    public List<string>? AttributeKeywords { get; set; }
    
    /// <summary>
    /// When true, use AI-powered Redis hybrid search (semantic + keyword).
    /// When false, use traditional SQL LIKE search.
    /// Client search should set this to true; admin search leaves it false.
    /// </summary>
    public bool UseHybridSearch { get; set; }
}