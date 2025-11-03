namespace NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Get;

public class GetVehicleCategoryDto
{
    public Guid CategoryId { get; set; }

    public string CategoryCode { get; set; } = string.Empty;

    public int Seat { get; set; }
}
