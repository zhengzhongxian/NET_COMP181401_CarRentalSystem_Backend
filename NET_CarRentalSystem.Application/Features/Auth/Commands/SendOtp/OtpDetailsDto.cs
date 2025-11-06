namespace NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtp;

public class OtpDetailsDto
{
    public required string Otp { get; set; }
    
    public required string UserName { get; set; }
    
    public int AttemptCount { get; set; }
    
    public DateTime ExpiryTime { get; set; }
    
    public DateTime KeyExpiresAt { get; set; }
}

