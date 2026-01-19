using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.VehicleModels;

public class GetAvailableVehicleModelsForSwapResponse
{
    public Guid Id { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public int Mileage { get; set; }
    
    public VehicleStatus Status { get; set; }
    
    public string? ConditionNotes { get; set; }
    
    public Guid? LocationId { get; set; }
    
    public string? LocationName { get; set; }
    
    public string? Address { get; set; }
}

