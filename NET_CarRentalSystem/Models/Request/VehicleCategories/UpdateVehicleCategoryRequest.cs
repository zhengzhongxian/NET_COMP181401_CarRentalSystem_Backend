namespace NET_CarRentalSystem.API.Models.Request.VehicleCategories;

public class UpdateVehicleCategoryRequest
{
    public string? CategoryCode { get; set; }

    public int? Seat { get; set; }
}
