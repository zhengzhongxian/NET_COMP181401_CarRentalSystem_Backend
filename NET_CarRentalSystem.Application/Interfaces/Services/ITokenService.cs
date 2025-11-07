using System.Security.Claims;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services;

public class TokenResponse
{
    public required string AccessToken { get; set; }
    
    public DateTime AccessTokenExpiry { get; set; }
    
    public required string RefreshToken { get; set; }
    
    public DateTime RefreshTokenExpiry { get; set; }
}

public interface ITokenService
{
    Task<TokenResponse> GenerateTokensAsync(User user);

    string GenerateRefreshToken();
    
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
}