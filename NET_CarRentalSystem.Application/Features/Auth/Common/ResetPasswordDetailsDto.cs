namespace NET_CarRentalSystem.Application.Features.Auth.Common;

public class ResetPasswordDetailsDto
{
    public required string Token { get; set; }
    
    public int AttemptCount { get; set; }
    
    public DateTime ExpiryTime { get; set; }
    
    public DateTime KeyExpiresAt { get; set; }
}