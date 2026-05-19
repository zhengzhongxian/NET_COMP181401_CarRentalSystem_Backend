using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

public interface IPaymentCommandDispatcher
{
    Task<bool> DispatchAsync(PaymentTransaction transaction, Booking booking, CancellationToken cancellationToken);
}
