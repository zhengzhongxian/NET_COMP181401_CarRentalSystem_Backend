namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class UpdateVehicleModelsRequest
{
    public required string NumberPlate { get; set; }

    public int Mileage { get; set; }

    public string? ConditionNotes { get; set; }

    public Guid? LocationId { get; set; }
}

