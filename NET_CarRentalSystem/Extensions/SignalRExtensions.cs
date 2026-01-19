using NET_CarRentalSystem.Infrastructure.Hubs;

namespace NET_CarRentalSystem.API.Extensions;

public static class SignalRExtensions
{
    public static WebApplication UseSignalRHubs(this WebApplication app)
    {
        app.MapHub<NotificationHub>("/hubs/notification");

        return app;
    }
}
