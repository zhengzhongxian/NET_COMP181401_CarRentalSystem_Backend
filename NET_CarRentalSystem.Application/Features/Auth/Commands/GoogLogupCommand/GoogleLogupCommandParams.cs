namespace NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLogupCommand;

public class GoogleLogupCommandParams
{
    public required string IdToken { get; set; }
    
    public required string Email { get; set; }
    
    public required string GivenName { get; set; }
    
    public required string FamilyName { get; set; }
    
    public required string PhoneNumber { get; set; }
    
    public DateTime Dob { get; set; }
    
    public string? Address { get; set; }
}