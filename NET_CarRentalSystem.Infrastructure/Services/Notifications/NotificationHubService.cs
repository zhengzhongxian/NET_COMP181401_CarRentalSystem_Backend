using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Infrastructure.Hubs;

namespace NET_CarRentalSystem.Infrastructure.Services.Notifications;

public class NotificationHubService(
    IHubContext<NotificationHub> hubContext,
    ILogger<NotificationHubService> logger) : INotificationHub
{
    public async Task SendToUserAsync<T>(string userId, string method, T payload, CancellationToken ct = default) where T : class
    {
        try
        {
            await hubContext.Clients.Group($"user_{userId}").SendAsync(method, payload, ct);
            logger.LogDebug("Sent notification to user {UserId}, method: {Method}", userId, method);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to send notification to user {UserId}", userId);
        }
    }

    public async Task SendToGroupAsync<T>(string group, string method, T payload, CancellationToken ct = default) where T : class
    {
        try
        {
            await hubContext.Clients.Group(group).SendAsync(method, payload, ct);
            logger.LogDebug("Sent notification to group {Group}, method: {Method}", group, method);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to send notification to group {Group}", group);
        }
    }

    public async Task SendToAllAsync<T>(string method, T payload, CancellationToken ct = default) where T : class
    {
        try
        {
            await hubContext.Clients.All.SendAsync(method, payload, ct);
            logger.LogDebug("Sent notification to all clients, method: {Method}", method);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to send notification to all clients");
        }
    }

    public async Task SendToRoleAsync<T>(string role, string method, T payload, CancellationToken ct = default) where T : class
    {
        try
        {
            await hubContext.Clients.Group($"role_{role}").SendAsync(method, payload, ct);
            logger.LogDebug("Sent notification to role {Role}, method: {Method}", role, method);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to send notification to role {Role}", role);
        }
    }
}
