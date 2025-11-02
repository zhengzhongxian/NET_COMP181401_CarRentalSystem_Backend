namespace NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Get;

public class GetVehicleCategoryDto
{
    public Guid CategoryId { get; set; }

    public string CategoryCode { get; set; }

    public int Seat { get; set; }
}
