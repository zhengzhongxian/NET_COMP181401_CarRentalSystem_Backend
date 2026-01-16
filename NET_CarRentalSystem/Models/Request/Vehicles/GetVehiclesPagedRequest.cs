using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class GetVehiclesPagedRequest : PagedRequest
{
    public Guid? CategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? LocationId { get; set; }

    public string? Status { get; set; }

    public decimal? MinPrice { get; set; }

    public decimal? MaxPrice { get; set; }
    
    public bool UseAi { get; set; } = false;
}