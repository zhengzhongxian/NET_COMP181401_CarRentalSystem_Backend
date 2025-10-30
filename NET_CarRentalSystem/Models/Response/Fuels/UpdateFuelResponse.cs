namespace NET_CarRentalSystem.API.Models.Response.Fuels;

public class UpdateFuelResponse
{
    public required Guid FuelId { get; init; }
    
    public required string Name { get; init; }
    
    public string? Description { get; init; }
}