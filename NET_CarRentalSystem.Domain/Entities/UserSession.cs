using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class UserSession : BaseEntity
{
    public Guid UserSessionId { get; set; }
    
    public Guid UserId { get; set; }
    
    public string RefreshToken { get; set; }
    
    public DateTime RefreshTokenExpiryTime { get; set; }
    
    public string? DeviceName { get; set; }
    
    public string? IpAddress { get; set; }
    
    public virtual User User { get; set; }
}

