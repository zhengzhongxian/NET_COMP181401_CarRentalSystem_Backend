using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class GetBookingsPagedRequest : PagedRequest
{
    public string? Status { get; set; }
    
    public Guid? CustomerId { get; set; }
    
    public DateTime? StartDateFrom { get; set; }
    
    public DateTime? StartDateTo { get; set; }

    public Guid? PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }
    public bool? HasViolation { get; set; }
}
