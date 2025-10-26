namespace NET_CarRentalSystem.Application.DTOs.FuelDTOs.Get;

public class FuelDto
{
    public Guid FuelId { get; set; }
    
    public string Name { get; set; }
    
    public string? Description { get; set; }
}
