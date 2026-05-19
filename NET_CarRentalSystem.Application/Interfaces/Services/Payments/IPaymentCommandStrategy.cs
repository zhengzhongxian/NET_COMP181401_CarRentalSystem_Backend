using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

public interface IPaymentCommandStrategy
{
    TransactionType TransactionType { get; }
    
    Task<bool> ExecuteAsync(PaymentTransaction transaction, Booking booking, CancellationToken cancellationToken);
}
