using System.Threading.RateLimiting;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Extensions;

public static class RateLimitingExtensions
{
    public static IServiceCollection AddRateLimitingServices(this IServiceCollection services)
    {
        services.AddRateLimiter(options =>
        {
            options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(
                context => RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: context.User.Identity?.Name 
                                  ?? context.Connection.RemoteIpAddress?.ToString() 
                                  ?? "anonymous",
                    factory: _ => new FixedWindowRateLimiterOptions
                    {
                        AutoReplenishment = true,
                        PermitLimit = 100,
                        Window = TimeSpan.FromMinutes(1)
                    }));

            options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
            
            options.OnRejected = async (context, cancellationToken) =>
            {
                context.HttpContext.Response.ContentType = "application/json";
                var response = ApiResponse.ErrorResult(
                    "Bạn đã gửi quá nhiều yêu cầu. Vui lòng thử lại sau.",
                    StatusCodes.Status429TooManyRequests);
                await context.HttpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            };
        });

        return services;
    }

    public static IApplicationBuilder UseRateLimitingMiddleware(this IApplicationBuilder app)
    {
        app.UseRateLimiter();
        return app;
    }
}
