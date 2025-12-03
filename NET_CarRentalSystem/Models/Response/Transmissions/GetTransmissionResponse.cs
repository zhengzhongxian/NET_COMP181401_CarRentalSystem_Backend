namespace NET_CarRentalSystem.API.Models.Response.Transmissions;

public class GetTransmissionResponse
{
    public Guid TransmissionId { get; set; }
    
    public required string Name { get; set; }
    
    public required string Code { get; set; }
    
    public string? Description { get; set; }
}

