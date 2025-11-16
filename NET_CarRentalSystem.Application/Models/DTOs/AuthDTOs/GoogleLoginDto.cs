using NET_CarRentalSystem.Application.Interfaces.Services;

namespace NET_CarRentalSystem.Application.Models.DTOs.AuthDTOs;

public class GoogleLoginDto
{
    public string? Email { get; set; }
    
    public string? GivenName { get; set; }
    
    public string? FamilyName { get; set; }
    
    public TokenResponse? TokenResponse { get; set; }
}