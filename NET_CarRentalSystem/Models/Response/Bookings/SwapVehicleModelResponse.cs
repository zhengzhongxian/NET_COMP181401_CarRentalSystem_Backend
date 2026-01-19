namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class SwapVehicleModelResponse
{
    public Guid BookingId { get; set; }
    
    public Guid NewVehicleModelId { get; set; }
    
    public string? Reason { get; set; }
}

