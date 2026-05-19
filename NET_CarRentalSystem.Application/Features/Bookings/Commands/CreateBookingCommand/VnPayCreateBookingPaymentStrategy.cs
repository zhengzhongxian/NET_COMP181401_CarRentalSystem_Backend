using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;

public class VnPayCreateBookingPaymentStrategy : ICreateBookingPaymentStrategy
{
    public PaymentMethod PaymentMethod => PaymentMethod.VnPay;

    public Task<CreateBookingPaymentStrategyResult> ProcessAsync(
        CreateBookingPaymentStrategyContext context,
        CancellationToken cancellationToken)
    {
        return Task.FromResult(CreateBookingPaymentStrategyResult.Empty);
    }
}
