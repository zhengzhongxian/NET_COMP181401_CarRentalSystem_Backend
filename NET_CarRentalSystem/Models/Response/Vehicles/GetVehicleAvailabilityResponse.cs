namespace NET_CarRentalSystem.API.Models.Response.Vehicles;

public class GetVehicleAvailabilityResponse
{
    public Guid VehicleId { get; set; }
    
    public string VehicleName { get; set; } = default!;
    
    public int TotalAvailable { get; set; }
    
    public List<GetVehicleAvailabilityByLocationResponse> ByLocation { get; set; } = [];
}

