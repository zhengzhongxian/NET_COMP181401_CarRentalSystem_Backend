namespace NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Get;

public class GetTransmissionDto
{
    public Guid TransmissionId { get; set; }
    
    public required string Name { get; set; }
    
    public required string Code { get; set; }
    
    public string? Description { get; set; }
}

