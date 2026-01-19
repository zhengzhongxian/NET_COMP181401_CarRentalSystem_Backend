using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.Vehicles;

public class GetVehicleModelsResponse
{
    public Guid VehicleModelId { get; set; }

    public string NumberPlate { get; set; } = string.Empty;

    public int Mileage { get; set; }

    public VehicleStatus Status { get; set; }

    public string? ConditionNotes { get; set; }

    public string? RealTimeLocation { get; set; }

    public Guid? LocationId { get; set; }

    public string? LocationName { get; set; }
}

