namespace NET_CarRentalSystem.Application.Features.Bookings.Events;

public record OverdueBookingDetectedEvent
{
    public Guid BookingId { get; init; }
    
    public Guid CustomerId { get; init; }
    
    public string CustomerName { get; init; } = string.Empty;
    
    public string? CustomerEmail { get; init; }
    
    public string? CustomerPhone { get; init; }
    
    public string NumberPlate { get; init; } = string.Empty;
    
    public string VehicleInfo { get; init; } = string.Empty;
    
    public string PickupLocationName { get; init; } = string.Empty;
    
    public DateTime StartDate { get; init; }
    
    public DateTime EndDate { get; init; }
    
    public int OverdueMinutes { get; init; }
    
    public string Severity { get; init; } = "Warning";
    
    public bool NotifyAdmin { get; init; }
    
    public string? AdminEmail { get; init; }
    
    public DateTime DetectedAt { get; init; } = DateTime.UtcNow;
}

