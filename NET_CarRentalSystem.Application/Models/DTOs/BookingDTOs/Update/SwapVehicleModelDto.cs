namespace NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Update;

public class SwapVehicleModelDto
{
    public Guid BookingId { get; set; }
    
    public Guid NewVehicleModelId { get; set; }
    
    public string? Reason { get; set; }
}

