using NET_CarRentalSystem.Application.Common.Abstract;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.Notifications;

public record BookingStatusNotification : BaseNotification
{
    public Guid BookingId { get; init; }

    public BookingStatus OldStatus { get; init; }

    public BookingStatus NewStatus { get; init; }

    public string CustomerName { get; init; } = string.Empty;

    public string VehicleName { get; init; } = string.Empty;

    public string Message { get; init; } = string.Empty;
}
