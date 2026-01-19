using NET_CarRentalSystem.Application.Common.Abstract;

namespace NET_CarRentalSystem.Application.Models.Notifications;

public record SystemNotification : BaseNotification
{
    public string Title { get; init; } = string.Empty;

    public string Message { get; init; } = string.Empty;

    public string Severity { get; init; } = "info";
}
