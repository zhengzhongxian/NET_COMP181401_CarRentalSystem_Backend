using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;

public class GetVehicleModelDto
{
    public Guid Id { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public int Mileage { get; set; }
    
    public VehicleStatus Status { get; set; }
    
    public Guid? LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
    
    public string? ConditionNotes { get; set; }
}