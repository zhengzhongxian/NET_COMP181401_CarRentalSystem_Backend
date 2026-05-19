using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Notifications;

public interface IPaymentEmailStrategy
{
    TransactionType TransactionType { get; }

    Task SendAsync(
        Customer customer,
        User user,
        BookingReadFlat booking,
        VehicleReadFlat vehicle,
        PaymentEmailEvent @event,
        CancellationToken cancellationToken);
}
