using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.VehicleCategories;

public class CreateVehicleCategoryRequest
{
    [Required]
    public string CategoryCode { get; set; }

    [Required]
    public int Seat { get; set; }
}
