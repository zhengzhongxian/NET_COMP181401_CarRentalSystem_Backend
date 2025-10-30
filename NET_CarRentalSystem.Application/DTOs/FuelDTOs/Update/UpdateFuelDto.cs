namespace NET_CarRentalSystem.Application.DTOs.FuelDTOs.Update;

public class UpdateFuelDto
{
    public required Guid FuelId { get; init; }
    
    public required string Name { get; init; }
    
    public string? Description { get; init; }
}