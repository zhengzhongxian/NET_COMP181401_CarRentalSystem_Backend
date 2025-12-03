namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class AddVehicleAttributesRequest
{
    public List<VehicleAttributeRequestDto> Attributes { get; set; } = [];
}

public class VehicleAttributeRequestDto
{
    public required string Key { get; set; }
    public required string Value { get; set; }
}

