using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class PaymentStatusSyncJob(ILogger<PaymentStatusSyncJob> logger) : IJob
{
    private static IServiceProvider? _serviceProvider;

    public static void SetServiceProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            logger.LogInformation("[PaymentStatusSyncJob] Starting payment status synchronization at {time}", DateTime.UtcNow);
            
            var unitOfWork = _serviceProvider!.GetRequiredService<IUnitOfWork>();
            var payOsService = _serviceProvider!.GetRequiredService<IPayOsService>();
            
            var pendingTransactions = await unitOfWork.GetReadRepository<PaymentTransaction>()
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
            var maxRetry = int.TryParse(context.JobDetail.JobDataMap.Get("MaxRetry").ToString(), out var result) ? result : 5;
            var writeRepo = unitOfWork.GetWriteRepository<PaymentTransaction>();
            var logRepo = unitOfWork.GetWriteRepository<TransactionProcessingLog>();

            foreach (var transaction in pendingTransactions)
            {
                try
                {
                    logger.LogInformation("[PaymentStatusSyncJob] Checking transaction {TransactionCode}", transaction.TransactionCode);

                    var payOsResponse = await payOsService.GetPaymentLinkInformationAsync(transaction.TransactionCode);

                    if (payOsResponse.Status == "PAID")
                    {
                        logger.LogInformation("[PaymentStatusSyncJob] Transaction {TransactionCode} is PAID on PayOS", transaction.TransactionCode);
                        
                        transaction.Status = TransactionStatus.Success;
                        writeRepo.Update(transaction);
                        await unitOfWork.SaveChangesAsync(context.CancellationToken);
                        
                        await MarkLogAsResolved(logRepo, unitOfWork, transaction.Id, context.CancellationToken);
                    }
                    else
                    {
                        logger.LogWarning("[PaymentStatusSyncJob] Transaction {TransactionCode} status is {Status}", 
                            transaction.TransactionCode, payOsResponse.Status);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "[PaymentStatusSyncJob] Error checking transaction {TransactionCode}", transaction.TransactionCode);
                    
                    await LogPaymentFailure(logRepo, unitOfWork, transaction, ex, maxRetry, context.CancellationToken);
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

    private async Task LogPaymentFailure(
        IWriteRepository<TransactionProcessingLog> logRepo,
        IUnitOfWork unitOfWork,
        PaymentTransaction transaction,
        Exception ex,
        int maxRetry,
        CancellationToken cancellationToken)
    {
        try
        {
            var errorCategory = CategorizeError(ex);
            
            var existingLog = await unitOfWork.GetReadRepository<TransactionProcessingLog>()
                .GetFirstOrDefaultAsync(
                    filter: l => l.PaymentTransactionId == transaction.Id &&
                                l.Status != TransactionLogStatus.Resolved,
                    cancellationToken: cancellationToken
                );

            if (existingLog == null)
            {
                var newLog = new TransactionProcessingLog
                {
                    Id = Guid.NewGuid(),
                    PaymentTransactionId = transaction.Id,
                    TransactionCode = transaction.TransactionCode.ToString(),
                    ErrorMessage = ex.Message,
                    StackTrace = ex.StackTrace,
                    RetryCount = 1,
                    LastAttemptAt = DateTime.UtcNow,
                    Status = TransactionLogStatus.Failed,
                    ErrorCategory = errorCategory,
                    RawResponse = null
                };

                await logRepo.AddAsync(newLog, cancellationToken);
                logger.LogInformation("[PaymentStatusSyncJob] Created processing log for transaction {TransactionCode}, ErrorCategory: {ErrorCategory}", 
                    transaction.TransactionCode, errorCategory);
            }
            else
            {
                existingLog.RetryCount++;
                existingLog.LastAttemptAt = DateTime.UtcNow;
                existingLog.ErrorMessage = ex.Message;
                existingLog.ErrorCategory = errorCategory;

                if (existingLog.RetryCount >= maxRetry)
                {
                    existingLog.Status = TransactionLogStatus.ManualInterventionRequired;
                    logger.LogWarning("[PaymentStatusSyncJob] Transaction {TransactionCode} reached max retry ({MaxRetry}), ErrorCategory: {ErrorCategory}, requires manual intervention", 
                        transaction.TransactionCode, maxRetry, errorCategory);
                }

                logRepo.Update(existingLog);
                logger.LogInformation("[PaymentStatusSyncJob] Updated processing log for transaction {TransactionCode}, RetryCount: {RetryCount}, ErrorCategory: {ErrorCategory}", 
                    transaction.TransactionCode, existingLog.RetryCount, errorCategory);
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);
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
        CancellationToken cancellationToken)
    {
        try
        {
            var logs = await unitOfWork.GetReadRepository<TransactionProcessingLog>()
                .GetAsync(
                    l => l.PaymentTransactionId == transactionId && l.Status != TransactionLogStatus.Resolved,
                    cancellationToken: cancellationToken);

            foreach (var log in logs)
            {
                log.Status = TransactionLogStatus.Resolved;
                logRepo.Update(log);
            }

            if (logs.Count > 0)
            {
                await unitOfWork.SaveChangesAsync(cancellationToken);
                logger.LogInformation("[PaymentStatusSyncJob] Marked {Count} logs as Resolved for transaction {TransactionId}", logs.Count, transactionId);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentStatusSyncJob] Error marking logs as resolved for transaction {TransactionId}", transactionId);
        }
    }

    private static ErrorCategory CategorizeError(Exception ex)
    {
        var exceptionType = ex.GetType();
        var exceptionMessage = ex.Message.ToLower();
        
        if (exceptionType.Name.Contains("HttpRequestException") ||
            exceptionType.Name.Contains("TimeoutException") ||
            exceptionMessage.Contains("timeout") ||
            exceptionMessage.Contains("network") ||
            exceptionMessage.Contains("dns") ||
            exceptionMessage.Contains("connection"))
        {
            return ErrorCategory.Network;
        }
        
        if (exceptionType.Name.Contains("PayOsBusinessException") ||
            exceptionMessage.Contains("payos") ||
            exceptionMessage.Contains("unauthorized") ||
            exceptionMessage.Contains("api error"))
        {
            return ErrorCategory.External;
        }
        
        if (exceptionType.Name.Contains("DbException") ||
            exceptionType.Name.Contains("SqlException") ||
            exceptionMessage.Contains("deadlock") ||
            exceptionMessage.Contains("database") ||
            exceptionMessage.Contains("constraint"))
        {
            return ErrorCategory.Database;
        }
        
        if (exceptionType.Name.Contains("InvalidOperationException") ||
            exceptionType.Name.Contains("ArgumentException") ||
            exceptionType.Name.Contains("FormatException") ||
            exceptionMessage.Contains("invalid") ||
            exceptionMessage.Contains("not found"))
        {
            return ErrorCategory.Logic;
        }
        
        return ErrorCategory.Unknown;
    }
}

