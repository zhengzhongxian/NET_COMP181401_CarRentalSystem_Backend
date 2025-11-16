namespace NET_CarRentalSystem.Application.Features.Auth.Common;

public class UserSessionCacheDto
{
    public Guid UserId { get; set; }
    
    public bool IsRevoked { get; set; }
}

