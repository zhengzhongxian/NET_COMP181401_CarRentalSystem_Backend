using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Update;

public class UpdateVehicleCategoryDto
{
    [Required]
    public Guid CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public int? Seat { get; set; }
}
