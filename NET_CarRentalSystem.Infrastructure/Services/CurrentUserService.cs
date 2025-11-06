using Microsoft.AspNetCore.Http;
using NET_CarRentalSystem.Application.Interfaces.Services;
using System.Security.Claims;

namespace NET_CarRentalSystem.Infrastructure.Services;

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
}
