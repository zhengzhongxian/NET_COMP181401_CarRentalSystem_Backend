using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Infrastructure.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class TokenService(IOptions<JwtSettings> jwtSettings, IUnitOfWork unitOfWork) : ITokenService
{
    private readonly JwtSettings _jwtSettings = jwtSettings.Value;

    public async Task<TokenResponse> GenerateTokensAsync(User user)
    {
        var claims = await GetClaimsAsync(user);
        var accessTokenExpiry = DateTime.UtcNow.AddMinutes(_jwtSettings.AccessTokenDurationInMinutes);
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = accessTokenExpiry,
            Issuer = _jwtSettings.Issuer,
            Audience = _jwtSettings.Audience,
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var accessToken = tokenHandler.CreateToken(tokenDescriptor);
        
        var refreshToken = GenerateRefreshToken();
        var refreshTokenExpiry = DateTime.UtcNow.AddDays(_jwtSettings.RefreshTokenDurationInDays);
        
        return new TokenResponse
        {
            AccessToken = tokenHandler.WriteToken(accessToken),
            AccessTokenExpiry = accessTokenExpiry,
            RefreshToken = refreshToken,
            RefreshTokenExpiry = refreshTokenExpiry
        };
    }

    public string GenerateRefreshToken()
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
    
    private async Task<List<Claim>> GetClaimsAsync(User user)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.UserId.ToString()),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email),
            new(JwtRegisteredClaimNames.Name, user.UserName)
        };

        var roleIds = unitOfWork.GetRepository<UserRole>()
            .GetQueryable(ur => ur.UserId == user.UserId)
            .Select(ur => ur.RoleId);

        var existRoleIds = await unitOfWork.GetQueryRepository().AnyAsync(roleIds);
        if (!existRoleIds) return claims.Distinct().ToList();

        var roles = unitOfWork.GetRepository<Role>()
            .GetQueryable(r => roleIds.Contains(r.RoleId))
            .Select(r => r.Name);
        
        var roleNames = await unitOfWork.GetQueryRepository().ToListAsync(roles);
        claims.AddRange(roleNames.Select(role => new Claim(ClaimTypes.Role, role)));

        var permissionClaims = await unitOfWork.GetRepository<RoleClaim>()
            .GetAsync(rc => roleIds.Contains(rc.RoleId) && rc.ClaimType == "Permission");
                
        claims.AddRange(permissionClaims.Select(c => new Claim(c.ClaimType, c.ClaimValue)));

        return claims.Distinct().ToList();
    }
}
