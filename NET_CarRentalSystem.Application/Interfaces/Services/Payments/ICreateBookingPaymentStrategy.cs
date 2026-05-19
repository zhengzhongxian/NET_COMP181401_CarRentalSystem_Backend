using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Payments;

/// <summary>
/// Strategy interface for creating booking payment links based on PaymentMethod.
/// Each implementation handles a specific payment method (PayOs, InCash, VnPay, etc.).
/// Strategies should NOT control persistence — that is the handler's responsibility.
/// </summary>
public interface ICreateBookingPaymentStrategy
{
    PaymentMethod PaymentMethod { get; }

    Task<CreateBookingPaymentStrategyResult> ProcessAsync(
        CreateBookingPaymentStrategyContext context,
        CancellationToken cancellationToken);
}

/// <summary>
/// Context passed to payment strategies. Does NOT include IUnitOfWork —
/// persistence is controlled by the calling handler to maintain proper transaction scope.
/// </summary>
public sealed record CreateBookingPaymentStrategyContext(
    PaymentTransaction Transaction,
    Customer Customer,
    User User);

public sealed record CreateBookingPaymentStrategyResult(
    string? PaymentUrl,
    string? QrCode,
    DateTime? ExpireDate,
    string? ExternalTransactionId)
{
    public static CreateBookingPaymentStrategyResult Empty { get; } = new(null, null, null, null);
}
