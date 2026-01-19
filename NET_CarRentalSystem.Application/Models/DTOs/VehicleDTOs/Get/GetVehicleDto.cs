using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

public class GetVehicleDto
{
    public Guid VehicleId { get; set; }

    public string Manufacturer { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public float Rating { get; set; }

    public int AvailableCount { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }
    
    public string? VehicleCategoryCode { get; set; }

    public string? FuelName { get; set; }

    public string? TransmissionName { get; set; }

    public List<GetVehicleAttributeDto>? AttributeDtos { get; set; } = [];
}
