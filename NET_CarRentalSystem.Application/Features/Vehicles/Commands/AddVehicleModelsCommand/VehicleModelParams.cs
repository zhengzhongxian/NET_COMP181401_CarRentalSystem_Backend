namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleModelsCommand;

public class VehicleModelParams
{
    public required string NumberPlate { get; set; }

    public int Mileage { get; set; }

    public string? ConditionNotes { get; set; }

    public Guid? LocationId { get; set; }
}

