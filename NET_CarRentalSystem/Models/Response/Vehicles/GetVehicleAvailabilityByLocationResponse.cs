using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.Vehicles;

public class GetVehicleAvailabilityByLocationResponse
{
    public Guid LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
    
    public int AvailableCount { get; set; }
    
    public List<GetVehicleModelDetailsResponse> Models { get; set; } = [];
}

public class GetVehicleModelDetailsResponse
{
    public Guid Id { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public int Mileage { get; set; }
    
    public VehicleStatus Status { get; set; }
}


