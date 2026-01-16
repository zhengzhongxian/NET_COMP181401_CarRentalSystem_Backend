using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class CreateBookingRequest
{
    public Guid VehicleId { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public PaymentMethod PaymentMethod { get; set; }
    
    public string? Note { get; set; }
    
    public List<Guid>? InsurancePackageIds { get; set; }
    
    public bool AcceptTerms { get; set; }
    
    public string? AcceptedTermsVersion { get; set; }
}
