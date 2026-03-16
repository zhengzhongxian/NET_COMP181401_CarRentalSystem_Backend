namespace NET_CarRentalSystem.Application.Features.Bookings.Events;

public record ReturnDeadlineReminderEvent
{
    public Guid BookingId { get; init; }
    
    public string CustomerName { get; init; } = string.Empty;
    
    public string? CustomerEmail { get; init; }
    
    public string NumberPlate { get; init; } = string.Empty;
    
    public string Manufacturer { get; init; } = "N/A";
    
    public string Model { get; init; } = "N/A";
    
    public string Color { get; init; } = "N/A";
    
    public string PickupLocationName { get; init; } = string.Empty;
    
    public string ReturnLocationName { get; init; } = string.Empty;
    
    public DateTime EndDate { get; init; }
    
    public DateTime DetectedAt { get; init; } = DateTime.UtcNow;
}

