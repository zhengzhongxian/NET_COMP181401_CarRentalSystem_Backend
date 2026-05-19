using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Webhooks.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Webhooks.Consumers;

public class PaymentWebhookConsumer(
    IUnitOfWork unitOfWork,
    IPaymentCommandDispatcher paymentCommandDispatcher,
    ICacheService cacheService,
    ILogger<PaymentWebhookConsumer> logger) : IConsumer<PaymentWebhookEvent>
{
    private static readonly TimeSpan TransactionLockTimeout = TimeSpan.FromSeconds(30);
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(30);

    public async Task Consume(ConsumeContext<PaymentWebhookEvent> context)
    {
        var @event = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation("[PaymentWebhookConsumer] Processing webhook OrderCode={OrderCode}, Amount={Amount}",
            @event.OrderCode, @event.Amount);

        var transactionLockKey = CacheKeyHelper.GetPaymentTransactionLockKey(@event.OrderCode);
        var transactionLockValue = Guid.NewGuid().ToString();
        var lockAcquired = await cacheService.AcquireLockAsync(transactionLockKey, transactionLockValue, TransactionLockTimeout, ct);

        if (!lockAcquired)
        {
            logger.LogWarning("[PaymentWebhookConsumer] Transaction {OrderCode} is being processed by another consumer. Skipping.",
                @event.OrderCode);
            return;
        }

        try
        {
            await unitOfWork.ExecuteInTransactionAsync(async cancellationToken =>
            {
                var webhookLog = new WebhookLog
                {
                    EventType = WebhookEventType.PaymentCompleted,
                    Payload = @event.ToJson(),
                    OrderCode = @event.OrderCode,
                    Reference = @event.Reference,
                    Amount = @event.Amount,
                    Status = WebhookLogStatus.Processing,
                };

                await unitOfWork.GetWriteRepository<WebhookLog>().AddAsync(webhookLog, cancellationToken);

                var transaction = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                    .GetFirstOrDefaultAsync(t => t.TransactionCode == @event.OrderCode, cancellationToken);

                if (transaction is null)
                {
                    webhookLog.Status = WebhookLogStatus.Failed;
                    webhookLog.ErrorCode = WebhookErrorCode.TransactionNotFound;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    await unitOfWork.SaveChangesAsync(cancellationToken);
                    logger.LogWarning("[PaymentWebhookConsumer] Transaction not found for OrderCode={OrderCode}", @event.OrderCode);
                    return;
                }

                if (transaction.Status == TransactionStatus.Success)
                {
                    webhookLog.Status = WebhookLogStatus.Duplicate;
                    webhookLog.ErrorCode = WebhookErrorCode.TransactionAlreadyProcessed;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    await unitOfWork.SaveChangesAsync(cancellationToken);
                    logger.LogInformation("[PaymentWebhookConsumer] Transaction {OrderCode} already processed. Skipping.", @event.OrderCode);
                    return;
                }

                var booking = await unitOfWork.GetWriteRepository<Booking>()
                    .GetFirstOrDefaultAsync(b => b.Id == transaction.BookingId, cancellationToken);

                if (booking is null)
                {
                    webhookLog.Status = WebhookLogStatus.Failed;
                    webhookLog.ErrorCode = WebhookErrorCode.BookingNotFound;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    await unitOfWork.SaveChangesAsync(cancellationToken);
                    logger.LogWarning("[PaymentWebhookConsumer] Booking not found for transaction {OrderCode}", @event.OrderCode);
                    return;
                }

                if (booking.Status == BookingStatus.Cancelled)
                {
                    webhookLog.Status = WebhookLogStatus.Failed;
                    webhookLog.ErrorCode = WebhookErrorCode.BookingAlreadyCancelled;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    await unitOfWork.SaveChangesAsync(cancellationToken);
                    logger.LogWarning("[PaymentWebhookConsumer] Booking {BookingId} was cancelled. OrderCode={OrderCode}",
                        booking.Id, @event.OrderCode);
                    return;
                }

                var customerLockKey = CacheKeyHelper.GetCustomerPaymentLockKey(booking.CustomerId);
                var customerLockValue = Guid.NewGuid().ToString();
                var customerLockAcquired = await cacheService.AcquireLockAsync(customerLockKey, customerLockValue, CustomerLockTimeout, cancellationToken);

                if (!customerLockAcquired)
                {
                    logger.LogWarning("[PaymentWebhookConsumer] Customer {CustomerId} has operation in progress. Will retry via MassTransit.",
                        booking.CustomerId);
                    throw new InvalidOperationException($"Customer {booking.CustomerId} lock not acquired. Retry needed.");
                }

                try
                {
                    transaction.Status = TransactionStatus.Success;
                    unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
                    await unitOfWork.SaveChangesAsync(cancellationToken);

                    var success = await paymentCommandDispatcher.DispatchAsync(transaction, booking, cancellationToken);

                    webhookLog.Status = success ? WebhookLogStatus.Success : WebhookLogStatus.Failed;
                    webhookLog.ErrorCode = success ? WebhookErrorCode.None : WebhookErrorCode.DispatchFailed;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    webhookLog.ProcessedBy = "System";
                    await unitOfWork.SaveChangesAsync(cancellationToken);

                    logger.LogInformation("[PaymentWebhookConsumer] Processed OrderCode={OrderCode}, Success={Success}",
                        @event.OrderCode, success);
                }
                finally
                {
                    await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, cancellationToken);
                }
            }, ct);
        }
        finally
        {
            await cacheService.ReleaseLockAsync(transactionLockKey, transactionLockValue, ct);
        }
    }
}
