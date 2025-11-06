namespace NET_CarRentalSystem.Application.Features.Auth.Commands.Logup;

public class LogupDto
{
    public required string UserName { get; set; }
    
    public required string Password { get; set; }
    
    public required string Otp { get; set; }
    
    public required string Email { get; set; }
    
    public required string FirstName { get; set; }
    
    public required string LastName { get; set; }
    
    public DateTime Dob { get; set; }
    
    public required string PhoneNumber { get; set; }
    
    public string? Address { get; set; }
}
