using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Infrastructure.Services.Authentication;

public class TokenService(IOptions<JwtSettings> jwtSettings, IUnitOfWork unitOfWork, ILogger<TokenService> logger) : ITokenService
{
    private readonly JwtSettings _jwtSettings = jwtSettings.Value;

    public async Task<TokenResponse> GenerateTokensAsync(User user, CancellationToken cancellationToken = default)
    {
        var claims = await GetClaimsAsync(user, cancellationToken);
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
        var randomNumber = new byte[64];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }


    public ClaimsPrincipal? GetPrincipalFromExpiredToken(string token)
    {
        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = true,
            ValidateIssuer = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key)),
            ValidateLifetime = false, 
            ValidIssuer = _jwtSettings.Issuer,
            ValidAudience = _jwtSettings.Audience
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        try
        {
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);
            if (securityToken is not JwtSecurityToken jwtSecurityToken ||
                !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }

            return principal;
        }
        catch(Exception ex)
        {
            logger.LogError("Token Validation Error. Error: {ex}", ex.Message);
            return null;
        }
    }

    public string? FindFirst(ClaimsPrincipal claimsPrincipal)
    {
        return claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
    }

    private async Task<List<Claim>> GetClaimsAsync(User user, CancellationToken cancellationToken = default)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email),
            new(JwtRegisteredClaimNames.Name, user.UserName)
        };

        var userLogin = await unitOfWork.GetWriteRepository<UserLogin>()
            .GetFirstOrDefaultAsync(ul => ul.UserId == user.Id, cancellationToken: cancellationToken);

        var loginProvider = userLogin?.LoginProvider.ToString() ?? "Local";
        claims.Add(new Claim("LoginProvider", loginProvider));

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetFirstOrDefaultAsync(c => c.UserId == user.Id, cancellationToken: cancellationToken);
        var loyaltyPoints = customer?.LoyaltyPoints ?? 0;
        claims.Add(new Claim("LoyaltyPoints", loyaltyPoints.ToString()));

        var roleIds = unitOfWork.GetWriteRepository<UserRole>()
            .GetQueryable()
            .Where(ur => ur.UserId == user.Id)
            .Select(ur => ur.RoleId);

        var existRoleIds = await roleIds.AnyAsync(cancellationToken);
        if (!existRoleIds) return claims.Distinct().ToList();

        var roles = unitOfWork.GetWriteRepository<Role>()
            .GetQueryable()
            .Where(r => roleIds.Contains(r.Id))
            .Select(r => r.Name);

        var roleNames = await roles.ToListAsync(cancellationToken);
        claims.AddRange(roleNames.Select(role => new Claim(ClaimTypes.Role, role)).Distinct());

        var permissionClaims = await unitOfWork.GetWriteRepository<RoleClaim>()
            .GetAsync(rc => roleIds.Contains(rc.RoleId) && rc.ClaimType == "Permission", cancellationToken: cancellationToken);

        var rolePermissions = permissionClaims
            .Select(c => c.ClaimValue)
            .Distinct();

        var userClaims = await unitOfWork.GetWriteRepository<UserClaim>()
            .GetAsync(uc => uc.UserId == user.Id && uc.ClaimType == "Permission", cancellationToken: cancellationToken);

        var userPermissions = userClaims
            .Select(c => c.ClaimValue)
            .Distinct();

        var distinctPermissions = rolePermissions.Union(userPermissions).Distinct();

        claims.AddRange(distinctPermissions.Select(permission => new Claim("Permission", permission)));

        return claims.Distinct(new ClaimComparer()).ToList();
    }
}

public class ClaimComparer : IEqualityComparer<Claim>
{
    public bool Equals(Claim? x, Claim? y)
    {
        if (x == null && y == null) return true;
        if (x == null || y == null) return false;
        return x.Type == y.Type && x.Value == y.Value;
    }

    public int GetHashCode(Claim obj)
    {
        return HashCode.Combine(obj.Type, obj.Value);
    }
}
