using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessDepositSuccess;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessFinalPaymentSuccess;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessViolationPaymentSuccess;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Webhooks.Commands.ProcessPayOsWebhookCommand;

public class ProcessPayOsWebhookCommand : ICommand<bool>
{
    public required PayOsWebhookData WebhookData { get; set; }
}

public class ProcessPayOsWebhookCommandHandler(
    IUnitOfWork unitOfWork,
    IMediator mediator,
    ICacheService cacheService,
    ILogger<ProcessPayOsWebhookCommandHandler> logger) : IRequestHandler<ProcessPayOsWebhookCommand, bool>
{
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(30);

    public async Task<bool> Handle(ProcessPayOsWebhookCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            var webhookLog = new WebhookLog
            {
                EventType = WebhookEventType.PaymentCompleted,
                Payload = request.WebhookData.ToJson(),
                OrderCode = request.WebhookData.OrderCode,
                Reference = request.WebhookData.Reference,
                Amount = request.WebhookData.Amount,
                Status = WebhookLogStatus.Processing,
            };

            await unitOfWork.GetWriteRepository<WebhookLog>().AddAsync(webhookLog, ct);

            var transaction = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                .GetFirstOrDefaultAsync(t => t.TransactionCode == request.WebhookData.OrderCode, ct);

            if (transaction is null)
            {
                webhookLog.Status = WebhookLogStatus.Failed;
                webhookLog.ErrorCode = WebhookErrorCode.TransactionNotFound;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                return false;
            }

            if (transaction.Status == TransactionStatus.Success)
            {
                webhookLog.Status = WebhookLogStatus.Duplicate;
                webhookLog.ErrorCode = WebhookErrorCode.TransactionAlreadyProcessed;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                logger.LogInformation("[Webhook] Transaction {TransactionCode} already processed. Skipping.", transaction.TransactionCode);
                return true;
            }

            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == transaction.BookingId, ct);

            if (booking is null)
            {
                webhookLog.Status = WebhookLogStatus.Failed;
                webhookLog.ErrorCode = WebhookErrorCode.BookingNotFound;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                logger.LogWarning("[Webhook] Booking not found for transaction {TransactionCode}", transaction.TransactionCode);
                return false;
            }

            if (booking.Status == BookingStatus.Cancelled)
            {
                webhookLog.Status = WebhookLogStatus.Failed;
                webhookLog.ErrorCode = WebhookErrorCode.BookingAlreadyCancelled;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                logger.LogWarning("[Webhook] Booking {BookingId} was cancelled. Transaction {TransactionCode} will be refunded via RefundRequest.",
                    booking.Id, transaction.TransactionCode);
                return false;
            }

            var customerLockKey = CacheKeyHelper.GetCustomerPaymentLockKey(booking.CustomerId);
            var customerLockValue = Guid.NewGuid().ToString();
            var customerLockAcquired = await cacheService.AcquireLockAsync(customerLockKey, customerLockValue, CustomerLockTimeout, ct);

            if (!customerLockAcquired)
            {
                logger.LogWarning("[Webhook] Customer {CustomerId} has operation in progress. Will retry.", booking.CustomerId);
                webhookLog.Status = WebhookLogStatus.Failed;
                webhookLog.ErrorCode = WebhookErrorCode.CustomerLocked;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                return false;
            }

            try
            {
                transaction.Status = TransactionStatus.Success;
                unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);
                await unitOfWork.SaveChangesAsync(ct);

                var success = await DispatchPaymentCommandAsync(transaction, booking, ct);

                if (success)
                {
                    webhookLog.Status = WebhookLogStatus.Success;
                    webhookLog.ErrorCode = WebhookErrorCode.None;
                    webhookLog.ProcessedAt = DateTime.UtcNow;
                    webhookLog.ProcessedBy = "System";
                    await unitOfWork.SaveChangesAsync(ct);
                    logger.LogInformation("[Webhook] Successfully processed transaction {TransactionCode}", transaction.TransactionCode);
                }

                return success;
            }
            finally
            {
                await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, ct);
            }
        }, cancellationToken);
    }

    private async Task<bool> DispatchPaymentCommandAsync(PaymentTransaction transaction, Booking booking, CancellationToken ct)
    {
        return transaction.Type switch
        {
            TransactionType.Deposit => await mediator.Send(new ProcessDepositSuccessCommand
            {
                Transaction = transaction,
                Booking = booking
            }, ct),

            TransactionType.FinalPayment => await mediator.Send(new ProcessFinalPaymentSuccessCommand
            {
                Transaction = transaction,
                Booking = booking
            }, ct),

            TransactionType.ViolationPayment => await mediator.Send(new ProcessViolationPaymentSuccessCommand
            {
                Transaction = transaction,
                Booking = booking
            }, ct),

            _ => true
        };
    }
}
