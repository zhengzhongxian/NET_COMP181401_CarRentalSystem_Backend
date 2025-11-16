namespace NET_CarRentalSystem.API.Models.Response.Auth;

public class GoogleLoginResponse
{
    public required string Email { get; set; }
    
    public required string GivenName { get; set; }
    
    public required string FamilyName { get; set; }
}