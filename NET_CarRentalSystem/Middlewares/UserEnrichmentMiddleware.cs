using Serilog.Context;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace NET_CarRentalSystem.API.Middlewares;

public class UserEnrichmentMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var user = context.User;

        if (user.Identity?.IsAuthenticated == true)
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier)
                         ?? user.FindFirstValue(JwtRegisteredClaimNames.Sub)
                         ?? "unknown";

            var userName = user.Identity?.Name
                           ?? user.FindFirstValue(ClaimTypes.Name)
                           ?? user.FindFirstValue("name")
                           ?? "unknown";

            var roles = user.FindAll(ClaimTypes.Role)
                            .Select(c => c.Value)
                            .ToList();

            var disposables = new List<IDisposable>
            {
                LogContext.PushProperty("UserId", userId),
                LogContext.PushProperty("UserName", userName),
                LogContext.PushProperty("UserRoles", roles.Count > 0 ? string.Join(", ", roles) : "none")
            };

            var impId = user.FindFirstValue("ImpersonatorId");
            if (!string.IsNullOrEmpty(impId))
            {
                disposables.Add(LogContext.PushProperty("ImpersonatorId", impId));
            }

            var impName = user.FindFirstValue("ImpersonatorName");
            if (!string.IsNullOrEmpty(impName))
            {
                disposables.Add(LogContext.PushProperty("ImpersonatorName", impName));
            }

            try
            {
                await next(context);
            }
            finally
            {
                foreach (var d in disposables)
                {
                    d.Dispose();
                }
            }
        }
        else
        {
            using (LogContext.PushProperty("UserId", "anonymous"))
            {
                await next(context);
            }
        }
    }
}
