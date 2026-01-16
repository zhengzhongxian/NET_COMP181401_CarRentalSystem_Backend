using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Application.Models.Payments.PayOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Configurations;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class RefundProcessingJob(
    ILogger<RefundProcessingJob> logger,
    IServiceScopeFactory serviceScopeFactory,
    IOptions<RefundProcessingJobConfig> configOptions) : IJob
{
    private readonly RefundProcessingJobConfig _config = configOptions.Value;

    public async Task Execute(IJobExecutionContext context)
    {
        logger.LogInformation(
            "[RefundProcessingJob] Starting refund processing at {Time}. BatchSize={BatchSize}, MaxRetries={MaxRetries}",
            DateTime.UtcNow, _config.BatchSize, _config.MaxRetryAttempts);
        
        using var scope = serviceScopeFactory.CreateScope();
        var serviceProvider = scope.ServiceProvider;
        
        var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
        
        var approvedRefunds = (await unitOfWork.GetReadRepository<RefundRequest>()
            .GetAsync(
                filter: r => r.Status == RefundStatus.Approved,
                sortBy: "CreatedAt",
                sortDirection: "asc",
                cancellationToken: context.CancellationToken
            ))
            .Take(_config.BatchSize)  
            .ToList();

        logger.LogInformation(
            "[RefundProcessingJob] Found {Count} approved refund requests (Batch limit: {BatchSize})",
            approvedRefunds.Count, _config.BatchSize);

        if (approvedRefunds.Count == 0)
        {
            logger.LogInformation("[RefundProcessingJob] No approved refunds to process");
            return;
        }

        var processedCount = 0;
        var failedCount = 0;

        foreach (var refund in approvedRefunds)
        {
            try
            {
                logger.LogInformation(
                    "[RefundProcessingJob] Processing refund {RefundId} for booking {BookingId}, Amount={Amount}VND", 
                    refund.Id, refund.BookingId, refund.Amount);
                
                var success = await ProcessRefundWithRetryAsync(unitOfWork, serviceProvider, refund, context.CancellationToken);
                
                if (success)
                {
                    processedCount++;
                    logger.LogInformation("[RefundProcessingJob] ✅ Successfully processed refund {RefundId}", refund.Id);
                }
                else
                {
                    failedCount++;
                    logger.LogWarning(
                        "[RefundProcessingJob] ⚠️ Failed to process refund {RefundId} after {MaxRetries} retries", 
                        refund.Id, _config.MaxRetryAttempts);
                }
            }
            catch (Exception ex)
            {
                failedCount++;
                logger.LogError(ex,
                    "[RefundProcessingJob] ❌ Unhandled exception processing refund {RefundId}: {ErrorMessage}", 
                    refund.Id, ex.Message);
            }
        }
        
        logger.LogInformation(
            "[RefundProcessingJob] Refund processing completed at {Time}. Processed: {ProcessedCount}, Failed: {FailedCount}, Total: {TotalCount}",
            DateTime.UtcNow, processedCount, failedCount, approvedRefunds.Count);
    }

    private async Task<bool> ProcessRefundWithRetryAsync(
        IUnitOfWork unitOfWork,
        IServiceProvider serviceProvider,
        RefundRequest refund,
        CancellationToken cancellationToken)
    {
        var attemptCount = 0;

        while (attemptCount < _config.MaxRetryAttempts)
        {
            try
            {
                attemptCount++;
                logger.LogInformation(
                    "[RefundProcessingJob] Attempt {AttemptNumber}/{MaxAttempts} for RefundId={RefundId}",
                    attemptCount, _config.MaxRetryAttempts, refund.Id);
                
                var result = await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
                {
                    var latestRefund = await unitOfWork.GetWriteRepository<RefundRequest>()
                        .GetByIdAsync(refund.Id, ct);
                    
                    if (latestRefund == null)
                    {
                        logger.LogWarning(
                            "[RefundProcessingJob] Refund {RefundId} not found in database. Skipping...",
                            refund.Id);
                        return null; 
                    }
                    
                    if (latestRefund.Status != RefundStatus.Approved)
                    {
                        logger.LogWarning(
                            "[RefundProcessingJob] Refund {RefundId} status is {Status} (expected Approved). Skipping...",
                            refund.Id, latestRefund.Status);
                        return null; 
                    }
                    
                    var paymentTransaction = (await unitOfWork.GetReadRepository<PaymentTransaction>()
                        .GetAsync(
                            filter: pt => pt.BookingId == latestRefund.BookingId && pt.Status == TransactionStatus.Success,
                            sortBy: "CreatedAt",
                            sortDirection: "desc",
                            cancellationToken: ct
                        ))
                        .FirstOrDefault();

                    if (paymentTransaction == null)
                    {
                        logger.LogWarning(
                            "[RefundProcessingJob] No completed payment transaction found for booking {BookingId}. Skipping refund {RefundId}...",
                            latestRefund.BookingId, refund.Id);
                        return null; 
                    }
                    
                    var payOsService = serviceProvider.GetRequiredService<IPayOsService>();
                    var paymentInfo = await payOsService.GetPaymentLinkInformationAsync(paymentTransaction.TransactionCode);
                    
                    logger.LogInformation(
                        "[RefundProcessingJob] Payment status from PayOS: OrderCode={OrderCode}, Status={Status}, AmountPaid={AmountPaid}, AmountRemaining={AmountRemaining}",
                        paymentInfo.OrderCode, paymentInfo.Status, paymentInfo.AmountPaid, paymentInfo.AmountRemaining);
                    
                    if (paymentInfo.AmountRemaining > 0)
                    {
                        logger.LogWarning(
                            "[RefundProcessingJob] Payment for refund {RefundId} not fully paid. Remaining: {Remaining}VND. Skipping...",
                            refund.Id, paymentInfo.AmountRemaining);
                        return null; 
                    }
                    
                    logger.LogInformation(
                        "[RefundProcessingJob] Processing actual refund for RefundId={RefundId}, Amount={Amount}VND",
                        latestRefund.Id, latestRefund.Amount);
                    
                    var payoutRequest = new CreatePayoutRequest
                    {
                        ReferenceId = latestRefund.Id.ToString(),
                        Amount = (long)latestRefund.Amount,
                        Description = $"Refund for booking {latestRefund.BookingId}",
                        ToBin = "",
                        ToAccountNumber = "",
                        TransactionCode = paymentTransaction.TransactionCode
                    };
                    
                    var refundResponse = await payOsService.RefundPaymentAsync(payoutRequest);
                    
                    if (string.IsNullOrEmpty(refundResponse.Id))
                    {
                        logger.LogError(
                            "[RefundProcessingJob] Failed to refund {Amount}VND for RefundId={RefundId}",
                            latestRefund.Amount, latestRefund.Id);
                        return null;
                    }
                    
                    logger.LogInformation(
                        "[RefundProcessingJob] Successfully created payout. PayoutId={PayoutId}, ApprovalState={ApprovalState}",
                        refundResponse.Id, refundResponse.ApprovalState);
                    
                    latestRefund.Status = RefundStatus.Processed;
                    latestRefund.ProcessedAt = DateTime.UtcNow;
                    latestRefund.AdminNotes = $"Successfully refunded {latestRefund.Amount}VND to customer account.";

                    unitOfWork.GetWriteRepository<RefundRequest>().Update(latestRefund);
                    await unitOfWork.SaveChangesAsync(ct);

                    logger.LogInformation("[RefundProcessingJob] ✅ Refund {RefundId} processed successfully", latestRefund.Id);

                    return latestRefund;

                }, cancellationToken);
                
                if (result == null)
                {
                    logger.LogInformation("[RefundProcessingJob] Skipping refund {RefundId} due to validation issues", refund.Id);
                    return true; 
                }
                
                var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();

                var refundEmailEvent = new RefundEmailEvent
                {
                    RefundRequestId = result.Id,
                    BookingId = result.BookingId,
                    CustomerId = result.CustomerId,
                    Amount = result.Amount,
                    Reason = result.Reason,
                    EmailType = RefundEmailType.Success,
                };

                await publishEndpoint.Publish(refundEmailEvent, cancellationToken);

                logger.LogInformation("[RefundProcessingJob] Published RefundEmailEvent for RefundId={RefundId}", refund.Id);
                
                return true; 
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex,
                    "[RefundProcessingJob] Attempt {AttemptNumber} failed for RefundId={RefundId}: {ErrorMessage}",
                    attemptCount, refund.Id, ex.Message);
                
                if (attemptCount < _config.MaxRetryAttempts)
                {
                    await Task.Delay(_config.RetryDelayMs, cancellationToken);
                    continue;
                }
                
                await HandleRefundProcessingFailureAsync(unitOfWork, serviceProvider, refund, ex, cancellationToken);
                return false;
            }
        }

        return false;
    }

    private async Task HandleRefundProcessingFailureAsync(
        IUnitOfWork unitOfWork,
        IServiceProvider serviceProvider,
        RefundRequest refund,
        Exception exception,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogError(
                "[RefundProcessingJob] Handling failure for RefundId={RefundId} after {MaxRetries} attempts",
                refund.Id, _config.MaxRetryAttempts);
            
            var processingLog = new RefundProcessingLog
            {
                Id = Guid.NewGuid(),
                RefundRequestId = refund.Id,
                ErrorMessage = exception.Message,
                StackTrace = exception.StackTrace,
                RetryCount = _config.MaxRetryAttempts,
                Status = RefundProcessingLogStatus.ManualInterventionRequired,
                LastAttemptAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow
            };

            await unitOfWork.GetWriteRepository<RefundProcessingLog>()
                .AddAsync(processingLog, cancellationToken);
            
            var latestRefund = await unitOfWork.GetWriteRepository<RefundRequest>()
                .GetByIdAsync(refund.Id, cancellationToken);

            if (latestRefund != null)
            {
                latestRefund.Status = RefundStatus.Failed;
                latestRefund.AdminNotes = 
                    $"Processing failed after {_config.MaxRetryAttempts} attempts. " +
                    $"Last error: {exception.Message}. " +
                    $"Time: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}. " +
                    $"Admin action required.";

                unitOfWork.GetWriteRepository<RefundRequest>().Update(latestRefund);
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);
            
            var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();

            var adminAlertEvent = new RefundProcessingFailedEvent
            {
                RefundRequestId = refund.Id,
                BookingId = refund.BookingId,
                Amount = refund.Amount,
                FailureReason = exception.Message,
                StackTrace = exception.StackTrace,
                RetryAttempts = _config.MaxRetryAttempts,
                FailedAt = DateTime.UtcNow
            };

            await publishEndpoint.Publish(adminAlertEvent, cancellationToken);

            logger.LogError(
                "[RefundProcessingJob] ❌ CRITICAL: RefundId={RefundId} requires manual intervention. " +
                "Alert published to admins. LogId={LogId}",
                refund.Id, processingLog.Id);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundProcessingJob] ❌❌ CRITICAL: Error handling failure for RefundId={RefundId}. " +
                "This refund may be orphaned and requires immediate manual review!",
                refund.Id);
            throw;
        }
    }
}