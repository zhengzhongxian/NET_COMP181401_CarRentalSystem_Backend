using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.Vehicles;

public class GetVehicleDetailResponse
{
    public Guid VehicleId { get; set; }

    public string NumberPlate { get; set; } = string.Empty;
    
    public string Manufacturer { get; set; } = string.Empty;
    
    public string Model { get; set; } = string.Empty;
    
    public decimal PricePerHour { get; set; }
    
    public float Rating { get; set; }
    
    public VehicleStatus Status { get; set; }
    
    public string? Thumbnail { get; set; }
    
    public string? Color { get; set; }
    
    public int? Mileage { get; set; }
    
    public Guid? VehicleCategoryId { get; set; }
    
    public Guid? FuelId { get; set; }
    
    public Guid? TransmissionId { get; set; }
    
    public Guid? LocationId { get; set; }
    
    public string? VehicleCategoryCode { get; set; }
    
    public string? FuelName { get; set; }
    
    public string? TransmissionName { get; set; }
    
    public string? LocationName { get; set; }
    
    public List<GetVehicleAttributeDto> Attributes { get; set; } = [];
    
    public List<GetVehicleImageDto> Images { get; set; } = [];
}