namespace NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Get;

public class GetVehicleAvailabilityByLocationDto
{
    public Guid LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
    
    public int AvailableCount { get; set; }
    
    public List<GetVehicleModelDto> Models { get; set; } = [];
}