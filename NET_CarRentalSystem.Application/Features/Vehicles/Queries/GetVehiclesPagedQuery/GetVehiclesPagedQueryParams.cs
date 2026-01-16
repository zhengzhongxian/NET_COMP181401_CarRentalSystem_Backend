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
    
    public bool UseAi { get; set; } = false;

    public List<string>? AttributeKeywords { get; set; }
    
    public List<string>? ExcludeAttributeKeywords { get; set; }
}