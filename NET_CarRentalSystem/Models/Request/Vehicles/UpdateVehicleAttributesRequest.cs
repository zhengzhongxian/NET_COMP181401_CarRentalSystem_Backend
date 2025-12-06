namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class UpdateVehicleAttributesRequest
{
    public required string Key { get; set; }
    public required string Value { get; set; }
}
