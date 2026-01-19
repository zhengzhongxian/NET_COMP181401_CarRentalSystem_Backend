namespace NET_CarRentalSystem.Application.Common.Abstract;

public abstract record BaseNotification
{
    public DateTime Timestamp { get; init; } = DateTime.UtcNow;

    public string NotificationType { get; init; } = string.Empty;
}
