using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;

public class NoExternalCreateBookingPaymentStrategy : ICreateBookingPaymentStrategy
{
    public PaymentMethod PaymentMethod => PaymentMethod.InCash;

    public Task<CreateBookingPaymentStrategyResult> ProcessAsync(
        CreateBookingPaymentStrategyContext context,
        CancellationToken cancellationToken)
    {
        return Task.FromResult(CreateBookingPaymentStrategyResult.Empty);
    }
}
