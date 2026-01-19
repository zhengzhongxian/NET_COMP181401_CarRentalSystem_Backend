namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class AddVehicleModelsRequest
{
    public required List<VehicleModelItemRequest> VehicleModels { get; set; }
}

public class VehicleModelItemRequest
{
    public required string NumberPlate { get; set; }

    public int Mileage { get; set; }

    public string? ConditionNotes { get; set; }

    public required Guid LocationId { get; set; }
}

