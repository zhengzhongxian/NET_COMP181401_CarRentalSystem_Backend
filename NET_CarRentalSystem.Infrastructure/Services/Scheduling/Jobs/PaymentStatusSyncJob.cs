using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Quartz;
using MediatR;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessDepositSuccess;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessFinalPaymentSuccess;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessPaymentExpired;
using NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessViolationPaymentSuccess;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class PaymentStatusSyncJob(
    ILogger<PaymentStatusSyncJob> logger,
    IServiceScopeFactory serviceScopeFactory) : IJob
{
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(30);

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            logger.LogInformation("[PaymentStatusSyncJob] Starting payment status synchronization at {time}", DateTime.UtcNow);

            using var scope = serviceScopeFactory.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            var payOsService = serviceProvider.GetRequiredService<IPayOsService>();
            var mediator = serviceProvider.GetRequiredService<IMediator>();
            var cacheService = serviceProvider.GetRequiredService<ICacheService>();

            var pendingTransactions = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                .GetAsync(
                    filter: t => t.Status == TransactionStatus.Pending &&
                                t.CreatedAt < DateTime.UtcNow.AddMinutes(-15),
                    sortBy: "CreatedAt",
                    sortDirection: "asc",
                    cancellationToken: context.CancellationToken
                );

            logger.LogInformation("[PaymentStatusSyncJob] Found {Count} pending transactions", pendingTransactions.Count);

            if (pendingTransactions.Count == 0)
            {
                logger.LogInformation("[PaymentStatusSyncJob] No pending transactions to sync");
                return;
            }

            var maxRetryValue = context.JobDetail.JobDataMap.Get("MaxRetry");
            var maxRetry = int.TryParse(maxRetryValue.ToString(), out var result) ? result : 5;
            var logRepo = unitOfWork.GetWriteRepository<TransactionProcessingLog>();

            foreach (var transaction in pendingTransactions)
            {
                try
                {
                    await ProcessTransactionAsync(
                        transaction, unitOfWork, payOsService, mediator, cacheService,
                        logRepo, maxRetry, context.CancellationToken);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    logger.LogInformation(ex, "[PaymentStatusSyncJob] Transaction {TransactionCode} already processed by Webhook. Skipping.",
                        transaction.TransactionCode);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "[PaymentStatusSyncJob] Error processing transaction {TransactionCode}",
                        transaction.TransactionCode);
                }
            }

            logger.LogInformation("[PaymentStatusSyncJob] Payment status synchronization completed at {time}", DateTime.UtcNow);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentStatusSyncJob] Fatal error during payment synchronization");
            throw;
        }
    }

    private async Task ProcessTransactionAsync(
        PaymentTransaction transaction,
        IUnitOfWork unitOfWork,
        IPayOsService payOsService,
        IMediator mediator,
        ICacheService cacheService,
        IWriteRepository<TransactionProcessingLog> logRepo,
        int maxRetry,
        CancellationToken ct)
    {
        try
        {
            logger.LogInformation("[PaymentStatusSyncJob] Checking transaction {TransactionCode}", transaction.TransactionCode);

            var payOsResponse = await payOsService.GetPaymentLinkInformationAsync(transaction.TransactionCode);

            switch (payOsResponse.Status)
            {
                case "PAID":
                    await HandlePaidStatusAsync(transaction, unitOfWork, mediator, cacheService, logRepo, ct);
                    break;

                case "EXPIRED":
                case "CANCELLED":
                    await HandleExpiredStatusAsync(transaction, mediator, ct);
                    logger.LogInformation("[PaymentStatusSyncJob] Processed expired/cancelled transaction {TransactionCode}",
                        transaction.TransactionCode);
                    break;

                default:
                    logger.LogWarning("[PaymentStatusSyncJob] Transaction {TransactionCode} status is {Status}",
                        transaction.TransactionCode, payOsResponse.Status);
                    break;
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentStatusSyncJob] Error checking transaction {TransactionCode}", transaction.TransactionCode);
            await LogPaymentFailure(unitOfWork, logRepo, transaction, ex, maxRetry, ct);
        }
    }

    private async Task HandlePaidStatusAsync(
        PaymentTransaction transaction,
        IUnitOfWork unitOfWork,
        IMediator mediator,
        ICacheService cacheService,
        IWriteRepository<TransactionProcessingLog> logRepo,
        CancellationToken ct)
    {
        logger.LogInformation("[PaymentStatusSyncJob] Transaction {TransactionCode} is PAID on PayOS", transaction.TransactionCode);

        await unitOfWork.ExecuteInTransactionAsync(async cancellationToken =>
        {
            var writeRepo = unitOfWork.GetWriteRepository<PaymentTransaction>();
            var latestTransaction = await writeRepo.GetFirstOrDefaultAsync(
                t => t.Id == transaction.Id, cancellationToken);

            if (latestTransaction == null || latestTransaction.Status == TransactionStatus.Success)
            {
                logger.LogInformation("[PaymentStatusSyncJob] Transaction {TransactionCode} already processed. Skipping.",
                    transaction.TransactionCode);
                return;
            }

            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == latestTransaction.BookingId, cancellationToken);

            if (booking != null && booking.Status == BookingStatus.Cancelled)
            {
                logger.LogWarning("[PaymentStatusSyncJob] Booking {BookingId} was cancelled. Transaction will be handled via RefundRequest.",
                    booking.Id);
                return;
            }

            latestTransaction.Status = TransactionStatus.Success;
            writeRepo.Update(latestTransaction);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            if (booking != null)
            {
                var customerLockKey = CacheKeyHelper.GetCustomerPaymentLockKey(booking.CustomerId);
                var customerLockValue = Guid.NewGuid().ToString();
                var customerLockAcquired = await cacheService.AcquireLockAsync(customerLockKey, customerLockValue, CustomerLockTimeout, cancellationToken);

                if (!customerLockAcquired)
                {
                    logger.LogWarning("[PaymentStatusSyncJob] Customer {CustomerId} has operation in progress. Will retry later.", booking.CustomerId);
                    return;
                }

                try
                {
                    await DispatchPaymentCommandAsync(mediator, latestTransaction, booking, cancellationToken);
                }
                finally
                {
                    await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, cancellationToken);
                }
            }

            await MarkLogAsResolved(logRepo, unitOfWork, latestTransaction.Id, cancellationToken);

            logger.LogInformation("[PaymentStatusSyncJob] Successfully processed transaction {TransactionCode}",
                transaction.TransactionCode);
        }, ct);
    }

    private static async Task HandleExpiredStatusAsync(
        PaymentTransaction transaction,
        IMediator mediator,
        CancellationToken ct)
    {
        await mediator.Send(new ProcessPaymentExpiredCommand { Transaction = transaction }, ct);
    }

    private static async Task DispatchPaymentCommandAsync(
        IMediator mediator,
        PaymentTransaction transaction,
        Booking booking,
        CancellationToken ct)
    {
        switch (transaction.Type)
        {
            case TransactionType.Deposit:
                await mediator.Send(new ProcessDepositSuccessCommand { Transaction = transaction, Booking = booking }, ct);
                break;

            case TransactionType.FinalPayment:
                await mediator.Send(new ProcessFinalPaymentSuccessCommand { Transaction = transaction, Booking = booking }, ct);
                break;

            case TransactionType.ViolationPayment:
                await mediator.Send(new ProcessViolationPaymentSuccessCommand { Transaction = transaction, Booking = booking }, ct);
                break;
        }
    }

    private async Task LogPaymentFailure(
        IUnitOfWork unitOfWork,
        IWriteRepository<TransactionProcessingLog> logRepo,
        PaymentTransaction transaction,
        Exception ex,
        int maxRetry,
        CancellationToken ct)
    {
        try
        {
            var existingLog = await logRepo.GetFirstOrDefaultAsync(
                l => l.PaymentTransactionId == transaction.Id && l.Status != TransactionLogStatus.Resolved, ct);

            var errorCategory = CategorizeError(ex);

            if (existingLog == null)
            {
                var newLog = new TransactionProcessingLog
                {
                    PaymentTransactionId = transaction.Id,
                    TransactionCode = transaction.TransactionCode.ToString(),
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    RetryCount = 1,
                    Status = TransactionLogStatus.Failed,
                    ErrorCategory = errorCategory,
                    LastAttemptAt = DateTime.UtcNow
                };

                await logRepo.AddAsync(newLog, ct);
                await unitOfWork.SaveChangesAsync(ct);

                logger.LogInformation("[PaymentStatusSyncJob] Created processing log for transaction {TransactionCode}, ErrorCategory: {ErrorCategory}",
                    transaction.TransactionCode, errorCategory);
            }
            else
            {
                existingLog.RetryCount++;
                existingLog.LastAttemptAt = DateTime.UtcNow;
                existingLog.ErrorMessage = ex.Message;
                existingLog.StackTrace = ex.StackTrace;
                existingLog.ErrorCategory = errorCategory;

                if (existingLog.RetryCount >= maxRetry)
                {
                    existingLog.Status = TransactionLogStatus.ManualInterventionRequired;
                    logger.LogWarning("[PaymentStatusSyncJob] Transaction {TransactionCode} reached max retry ({MaxRetry}), requires manual intervention",
                        transaction.TransactionCode, maxRetry);
                }

                logRepo.Update(existingLog);
                await unitOfWork.SaveChangesAsync(ct);

                logger.LogInformation("[PaymentStatusSyncJob] Updated processing log for transaction {TransactionCode}, RetryCount: {RetryCount}",
                    transaction.TransactionCode, existingLog.RetryCount);
            }
        }
        catch (Exception logEx)
        {
            logger.LogError(logEx, "[PaymentStatusSyncJob] Error logging payment failure for transaction {TransactionCode}",
                transaction.TransactionCode);
        }
    }

    private async Task MarkLogAsResolved(
        IWriteRepository<TransactionProcessingLog> logRepo,
        IUnitOfWork unitOfWork,
        Guid transactionId,
        CancellationToken ct)
    {
        try
        {
            var logs = await logRepo.GetAsync(
                filter: l => l.PaymentTransactionId == transactionId && l.Status != TransactionLogStatus.Resolved,
                cancellationToken: ct);

            foreach (var log in logs)
            {
                log.Status = TransactionLogStatus.Resolved;
                logRepo.Update(log);
            }

            if (logs.Count > 0)
            {
                await unitOfWork.SaveChangesAsync(ct);
                logger.LogInformation("[PaymentStatusSyncJob] Marked {Count} logs as Resolved for transaction {TransactionId}",
                    logs.Count, transactionId);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentStatusSyncJob] Error marking logs as resolved for transaction {TransactionId}", transactionId);
        }
    }

    private static ErrorCategory CategorizeError(Exception ex)
    {
        return ex switch
        {
            TimeoutException => ErrorCategory.Timeout,
            HttpRequestException => ErrorCategory.Network,
            InvalidOperationException => ErrorCategory.Logic,
            _ => ErrorCategory.Unknown
        };
    }
}