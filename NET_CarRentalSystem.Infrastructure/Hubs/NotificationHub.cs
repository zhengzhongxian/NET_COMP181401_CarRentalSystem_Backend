using Microsoft.AspNetCore.SignalR;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

namespace NET_CarRentalSystem.Infrastructure.Hubs;

public class NotificationHub(ICurrentUserService currentUserService) : Hub
{
    public override async Task OnConnectedAsync()
    {
        var userId = currentUserService.GetUserId()?.ToString();
        var roles = currentUserService.GetRoles();

        if (!string.IsNullOrEmpty(userId))
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"user_{userId}");
        }

        foreach (var role in roles)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"role_{role}");
        }

        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var userId = currentUserService.GetUserId()?.ToString();
        var roles = currentUserService.GetRoles();

        if (!string.IsNullOrEmpty(userId))
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"user_{userId}");
        }

        foreach (var role in roles)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"role_{role}");
        }

        await base.OnDisconnectedAsync(exception);
    }

    public async Task JoinGroup(string groupName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
    }

    public async Task LeaveGroup(string groupName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
    }
}
