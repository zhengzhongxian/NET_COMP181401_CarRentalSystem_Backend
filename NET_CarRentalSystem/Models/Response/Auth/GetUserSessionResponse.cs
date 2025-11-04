namespace NET_CarRentalSystem.API.Models.Response.Auth;

public class GetUserSessionResponse
{
    public Guid UserSessionId { get; set; }
    
    public string? DeviceName { get; set; }
    
    public string? IpAddress { get; set; }
    
    public DateTime CreatedAt { get; set; }
}