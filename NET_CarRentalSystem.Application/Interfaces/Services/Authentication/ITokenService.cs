using System.Security.Claims;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

public class TokenResponse
{
    public required string AccessToken { get; set; }

    public required DateTime AccessTokenExpiry { get; set; }

    public required string RefreshToken { get; set; }

    public required DateTime RefreshTokenExpiry { get; set; }
}

public interface ITokenService
{
    Task<TokenResponse> GenerateTokensAsync(User user, CancellationToken  cancellationToken = default);
    
    Task<TokenResponse> GenerateTokensAsync(User user, List<Claim> additionalClaims, CancellationToken cancellationToken = default);

    string GenerateRefreshToken();
    
    ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);

    string? FindFirst(ClaimsPrincipal claimsPrincipal);
}