using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class SwapVehicleModelRequest
{
    public Guid NewVehicleModelId { get; set; }
    
    public VehicleStatus OldVehicleModelStatus { get; set; }
    
    public string? Reason { get; set; }
}

