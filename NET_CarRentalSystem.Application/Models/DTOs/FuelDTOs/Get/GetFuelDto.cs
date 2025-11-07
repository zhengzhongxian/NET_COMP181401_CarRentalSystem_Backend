namespace NET_CarRentalSystem.Application.Models.DTOs.FuelDTOs.Get;

public class GetFuelDto
{
    public Guid FuelId { get; set; }
    
    public string Name { get; set; }
    
    public string? Description { get; set; }
}
