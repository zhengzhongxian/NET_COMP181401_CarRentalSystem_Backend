namespace NET_CarRentalSystem.Application.Models.Authentication;

public class GoogleUserPayload
{
    public required string Email { get; set; }
    
    public bool EmailVerified { get; set; }
    
    public required string Name { get; set; }
     
    public required string GoogleUserId { get; set; }
    
    public required string GivenName { get; set; }
    
    public required string FamilyName { get; set; }
    
    public required string? Picture { get; set; }
}