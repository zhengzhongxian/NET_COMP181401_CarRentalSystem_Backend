using MediatR;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessFinalPaymentSuccess;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class FinalPaymentStrategy(IMediator mediator) : IPaymentCommandStrategy
{
    public TransactionType TransactionType => TransactionType.FinalPayment;

    public async Task<bool> ExecuteAsync(PaymentTransaction transaction, Booking booking, CancellationToken cancellationToken)
    {
        return await mediator.Send(new ProcessFinalPaymentSuccessCommand
        {
            Transaction = transaction,
            Booking = booking
        }, cancellationToken);
    }
}
