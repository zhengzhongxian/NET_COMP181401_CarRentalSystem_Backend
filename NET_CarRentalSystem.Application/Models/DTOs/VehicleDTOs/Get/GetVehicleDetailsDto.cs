using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

public class GetVehicleDetailsDto
{
    public Guid VehicleId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? Manufacturer { get; set; }
    
    public string? Model { get; set; }

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

    public string? AttributesJson { get; set; }
    
    public string? ImagesJson { get; set; }
}