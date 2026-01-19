namespace NET_CarRentalSystem.Application.Interfaces.Services.Notifications;

public interface INotificationHub
{
    Task SendToUserAsync<T>(string userId, string method, T payload, CancellationToken ct = default) where T : class;

    Task SendToGroupAsync<T>(string group, string method, T payload, CancellationToken ct = default) where T : class;

    Task SendToAllAsync<T>(string method, T payload, CancellationToken ct = default) where T : class;

    Task SendToRoleAsync<T>(string role, string method, T payload, CancellationToken ct = default) where T : class;
}
