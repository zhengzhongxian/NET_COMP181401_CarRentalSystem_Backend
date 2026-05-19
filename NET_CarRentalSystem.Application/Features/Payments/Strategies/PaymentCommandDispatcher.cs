using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class PaymentCommandDispatcher(
    IEnumerable<IPaymentCommandStrategy> strategies,
    ILogger<PaymentCommandDispatcher> logger) : IPaymentCommandDispatcher
{
    private readonly Dictionary<TransactionType, IPaymentCommandStrategy> _strategyMap =
        strategies.ToDictionary(s => s.TransactionType);

    public async Task<bool> DispatchAsync(PaymentTransaction transaction, Booking booking, CancellationToken cancellationToken)
    {
        if (_strategyMap.TryGetValue(transaction.Type, out var strategy))
        {
            logger.LogInformation(
                "[PaymentCommandDispatcher] Dispatching {TransactionType} for TransactionCode={TransactionCode}",
                transaction.Type, transaction.TransactionCode);
            
            return await strategy.ExecuteAsync(transaction, booking, cancellationToken);
        }

        logger.LogWarning(
            "[PaymentCommandDispatcher] No strategy found for TransactionType={TransactionType}, TransactionCode={TransactionCode}",
            transaction.Type, transaction.TransactionCode);
        
        return true;
    }
}
