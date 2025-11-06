namespace NET_CarRentalSystem.Application.DTOs.UserDTOs.Get;

public class GetUserSessionDto
{
    public Guid UserSessionId { get; set; }
    
    public string? DeviceName { get; set; }
    
    public string? IpAddress { get; set; }
    
    public DateTime CreatedAt { get; set; }
}