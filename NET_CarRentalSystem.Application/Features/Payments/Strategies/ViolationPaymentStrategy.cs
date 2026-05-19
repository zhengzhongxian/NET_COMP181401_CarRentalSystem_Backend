using MediatR;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessViolationPaymentSuccess;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class ViolationPaymentStrategy(IMediator mediator) : IPaymentCommandStrategy
{
    public TransactionType TransactionType => TransactionType.ViolationPayment;

    public async Task<bool> ExecuteAsync(PaymentTransaction transaction, Booking booking, CancellationToken cancellationToken)
    {
        return await mediator.Send(new ProcessViolationPaymentSuccessCommand
        {
            Transaction = transaction,
            Booking = booking
        }, cancellationToken);
    }
}
