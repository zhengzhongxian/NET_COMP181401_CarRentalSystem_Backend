namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;

public class GetVehicleImageDto
{
    public int Order { get; set; }

    public string ImageUrl { get; set; } = default!;

    public string? AltText { get; set; }

    public string? PublicId { get; set; }
}