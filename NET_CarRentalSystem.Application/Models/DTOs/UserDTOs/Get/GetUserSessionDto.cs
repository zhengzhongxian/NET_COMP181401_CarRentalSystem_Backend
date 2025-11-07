namespace NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;

public class GetUserSessionDto
{
    public Guid UserSessionId { get; set; }
    
    public string? DeviceName { get; set; }
    
    public string? IpAddress { get; set; }
    
    public DateTime CreatedAt { get; set; }
}