namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleAttributesCommand;

public class VehicleAttributeParams
{
    public required string Key { get; set; }
    
    public required string Value { get; set; }
}