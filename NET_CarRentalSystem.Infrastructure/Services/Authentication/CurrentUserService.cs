using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

namespace NET_CarRentalSystem.Infrastructure.Services.Authentication;

public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    public Guid? GetUserId()
    {
        var userIdClaim = httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (Guid.TryParse(userIdClaim, out var userId))
        {
            return userId;
        }
        return null;
    }

    public IReadOnlyList<string> GetRoles()
    {
        var roles = httpContextAccessor.HttpContext?.User
            .FindAll(ClaimTypes.Role)
            .Select(c => c.Value)
            .Where(r => !string.IsNullOrWhiteSpace(r))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .ToList();

        if (roles == null || roles.Count == 0)
        {
            return [];
        }

        return roles.AsReadOnly();
    }
}
