using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Notifications;

/// <summary>
/// Strategy interface for sending refund emails based on RefundEmailType.
/// Each implementation handles a specific email template (Notification, Success).
/// </summary>
public interface IRefundEmailStrategy
{
    RefundEmailType EmailType { get; }

    Task SendAsync(
        string email,
        Customer customer,
        BookingReadFlat? booking,
        string vehicleName,
        RefundEmailEvent @event,
        string appUrl,
        CancellationToken cancellationToken);
}
