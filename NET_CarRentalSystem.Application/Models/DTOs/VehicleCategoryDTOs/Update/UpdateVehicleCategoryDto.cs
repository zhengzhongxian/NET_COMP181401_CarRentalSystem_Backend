namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Update;

public class UpdateVehicleCategoryDto
{
    public Guid CategoryId { get; set; }
    public string? CategoryCode { get; set; }
    public int? Seat { get; set; }
}
