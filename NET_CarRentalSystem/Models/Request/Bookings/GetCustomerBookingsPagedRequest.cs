using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class GetCustomerBookingsPagedRequest : PagedRequest
{
    public string? Status { get; set; }
    
    // Optional filters
    public Guid? PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }
    
    public bool? HasViolation { get; set; }
}
