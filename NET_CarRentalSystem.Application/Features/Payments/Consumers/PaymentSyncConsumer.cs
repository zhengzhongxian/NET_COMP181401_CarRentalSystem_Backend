using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessPaymentExpired;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

public class PaymentSyncConsumer(
    IUnitOfWork unitOfWork,
    IPayOsService payOsService,
    IPaymentCommandDispatcher paymentCommandDispatcher,
    ICacheService cacheService,
    IMediator mediator,
    ILogger<PaymentSyncConsumer> logger) : IConsumer<PaymentSyncEvent>
{
    private static readonly TimeSpan TransactionLockTimeout = TimeSpan.FromSeconds(30);
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(30);

    public async Task Consume(ConsumeContext<PaymentSyncEvent> context)
    {
        var @event = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation("[PaymentSyncConsumer] Processing TransactionCode={TransactionCode}", @event.TransactionCode);

        var transactionLockKey = CacheKeyHelper.GetPaymentTransactionLockKey(@event.TransactionCode);
        var transactionLockValue = Guid.NewGuid().ToString();
        var lockAcquired = await cacheService.AcquireLockAsync(transactionLockKey, transactionLockValue, TransactionLockTimeout, ct);

        if (!lockAcquired)
        {
            logger.LogWarning("[PaymentSyncConsumer] Transaction {TransactionCode} is being processed. Skipping.",
                @event.TransactionCode);
            return;
        }

        try
        {
            var transaction = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                .GetFirstOrDefaultAsync(t => t.Id == @event.TransactionId, ct);

            if (transaction is null || transaction.Status != TransactionStatus.Pending)
            {
                logger.LogInformation("[PaymentSyncConsumer] Transaction {TransactionCode} not found or already processed.",
                    @event.TransactionCode);
                return;
            }

            var payOsResponse = await payOsService.GetPaymentLinkInformationAsync(transaction.TransactionCode);

            switch (payOsResponse.Status)
            {
                case "PAID":
                    await HandlePaidStatusAsync(transaction, ct);
                    break;

                case "EXPIRED":
                case "CANCELLED":
                    await mediator.Send(new ProcessPaymentExpiredCommand { Transaction = transaction }, ct);
                    logger.LogInformation("[PaymentSyncConsumer] Processed expired/cancelled TransactionCode={TransactionCode}",
                        transaction.TransactionCode);
                    break;

                default:
                    logger.LogWarning("[PaymentSyncConsumer] TransactionCode={TransactionCode} status is {Status}",
                        transaction.TransactionCode, payOsResponse.Status);
                    break;
            }
        }
        catch (Exception ex) when (ex.Message.Contains("concurrency", StringComparison.OrdinalIgnoreCase))
        {
            logger.LogInformation(ex, "[PaymentSyncConsumer] Transaction {TransactionCode} already processed by webhook. Skipping.",
                @event.TransactionCode);
        }
        finally
        {
            await cacheService.ReleaseLockAsync(transactionLockKey, transactionLockValue, ct);
        }
    }

    private async Task HandlePaidStatusAsync(PaymentTransaction transaction, CancellationToken ct)
    {
        logger.LogInformation("[PaymentSyncConsumer] Transaction {TransactionCode} is PAID on PayOS", transaction.TransactionCode);

        await unitOfWork.ExecuteInTransactionAsync(async cancellationToken =>
        {
            var writeRepo = unitOfWork.GetWriteRepository<PaymentTransaction>();
            var latestTransaction = await writeRepo.GetFirstOrDefaultAsync(
                t => t.Id == transaction.Id, cancellationToken);

            if (latestTransaction == null || latestTransaction.Status == TransactionStatus.Success)
            {
                logger.LogInformation("[PaymentSyncConsumer] Transaction {TransactionCode} already processed. Skipping.",
                    transaction.TransactionCode);
                return;
            }

            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == latestTransaction.BookingId, cancellationToken);

            if (booking is { Status: BookingStatus.Cancelled })
            {
                logger.LogWarning("[PaymentSyncConsumer] Booking {BookingId} was cancelled. Will be refunded.",
                    booking.Id);
                return;
            }

            var customerLockKey = CacheKeyHelper.GetCustomerPaymentLockKey(booking!.CustomerId);
            var customerLockValue = Guid.NewGuid().ToString();
            var customerLockAcquired = await cacheService.AcquireLockAsync(customerLockKey, customerLockValue, CustomerLockTimeout, cancellationToken);

            if (!customerLockAcquired)
            {
                logger.LogWarning("[PaymentSyncConsumer] Customer {CustomerId} has operation in progress. Will retry.",
                    booking.CustomerId);
                throw new InvalidOperationException($"Customer {booking.CustomerId} lock not acquired. Retry needed.");
            }

            try
            {
                latestTransaction.Status = TransactionStatus.Success;
                writeRepo.Update(latestTransaction);
                await unitOfWork.SaveChangesAsync(cancellationToken);

                await paymentCommandDispatcher.DispatchAsync(latestTransaction, booking, cancellationToken);

                logger.LogInformation("[PaymentSyncConsumer] Successfully processed TransactionCode={TransactionCode}",
                    transaction.TransactionCode);
            }
            finally
            {
                await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, cancellationToken);
            }
        }, ct);
    }
}
