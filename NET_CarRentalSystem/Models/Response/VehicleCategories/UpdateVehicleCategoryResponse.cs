namespace NET_CarRentalSystem.API.Models.Response.VehicleCategories;

public class UpdateVehicleCategoryResponse
{
    public Guid CategoryId { get; set; }

    public string CategoryCode { get; set; }

    public int Seat { get; set; }
}
