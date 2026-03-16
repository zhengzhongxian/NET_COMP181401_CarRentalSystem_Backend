using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.Vehicles;

public class GetVehicleModelsInventoryResponse
{
    public Guid VehicleId { get; set; }
    
    public string VehicleName { get; set; } = default!;
    
    public int TotalCount { get; set; }
    
    public List<GetVehicleModelsByStatusResponse> ByStatus { get; set; } = [];

    public List<GetVehicleModelsByLocationResponse> ByLocation { get; set; } = [];
}

public class GetVehicleModelsByStatusResponse
{
    public VehicleStatus Status { get; set; }
    
    public int Count { get; set; }
}

public class GetVehicleModelsByLocationResponse
{
    public Guid LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
    
    public int Count { get; set; }
    
    public List<GetVehicleModelDetailsResponse> Models { get; set; } = [];
}
