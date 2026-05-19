using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CreateBookingCommand;

public class PayOsCreateBookingPaymentStrategy(IPayOsService payOsService) : ICreateBookingPaymentStrategy
{
    public PaymentMethod PaymentMethod => PaymentMethod.PayOs;

    public async Task<CreateBookingPaymentStrategyResult> ProcessAsync(
        CreateBookingPaymentStrategyContext context,
        CancellationToken cancellationToken)
    {
        var payOsRequest = new PayOsCreateRequest
        {
            TransactionCode = context.Transaction.TransactionCode,
            TotalAmount = (long)context.Transaction.Amount,
            TransactorName = $"{context.Customer.FirstName} {context.Customer.LastName}",
            TransactorEmail = context.User.Email,
            TransactorPhone = context.Customer.PhoneNumber,
            TransactorAddress = context.Customer.Address ?? "N/A",
            Description = "Dat coc thue xe"
        };

        var payOsResponse = await payOsService.CreatePaymentAsync(payOsRequest);

        var expireDate = payOsResponse.ExpiredAt.HasValue
            ? (DateTime?)DateTimeOffset.FromUnixTimeSeconds(payOsResponse.ExpiredAt.Value).UtcDateTime
            : null;

        return new CreateBookingPaymentStrategyResult(
            payOsResponse.CheckoutUrl,
            payOsResponse.QrCode,
            expireDate,
            payOsResponse.PaymentLinkId);
    }
}
