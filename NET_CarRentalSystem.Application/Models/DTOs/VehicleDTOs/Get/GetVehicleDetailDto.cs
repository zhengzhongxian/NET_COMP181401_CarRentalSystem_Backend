using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

public class GetVehicleDetailDto
{
    public Guid VehicleId { get; set; }
    public string NumberPlate { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public decimal PricePerHour { get; set; }
    public float Rating { get; set; }
    public VehicleStatus Status { get; set; }
    
    public string? VehicleCategoryCode { get; set; }
    public string? FuelName { get; set; }
    public string? TransmissionName { get; set; }
    public string? LocationName { get; set; }

    public List<GetVehicleAttributeDto> Attributes { get; set; } = [];
    public List<string> Images { get; set; } = [];
}