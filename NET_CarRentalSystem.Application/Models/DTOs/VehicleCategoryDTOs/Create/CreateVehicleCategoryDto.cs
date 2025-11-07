using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Create;

public class CreateVehicleCategoryDto
{
    [Required]
    public string CategoryCode { get; set; } = string.Empty;

    [Required]
    public int Seat { get; set; }
}
