using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Bookings.Queries.GetCustomerBookingsPagedQuery;

public class GetCustomerBookingsPagedQueryParams : PagedParams
{
    public string? Status { get; set; }
    
    public Guid? PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }
    
    public bool? HasViolation { get; set; }
    
    public DateTime? StartDateFrom { get; set; }
    
    public DateTime? StartDateTo { get; set; }
}
