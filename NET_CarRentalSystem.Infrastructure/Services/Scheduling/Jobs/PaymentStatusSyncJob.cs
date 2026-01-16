using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Quartz;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Application.Interfaces.Services.Payments;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

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
            var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();
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
            var writeRepo = unitOfWork.GetWriteRepository<PaymentTransaction>();
            var logRepo = unitOfWork.GetWriteRepository<TransactionProcessingLog>();

            // Note: Transaction updates được bảo vệ bởi RowVersion
            // Không cần Transaction Lock - nếu Webhook đã update trước thì sẽ có DbUpdateConcurrencyException
            foreach (var transaction in pendingTransactions)
            {
                try
                {
                    await ProcessTransactionAsync(
                        transaction, unitOfWork, payOsService, publishEndpoint, cacheService,
                        writeRepo, logRepo, maxRetry, context.CancellationToken);
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    // RowVersion conflict: Webhook đã xử lý trước
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
        IPublishEndpoint publishEndpoint,
        ICacheService cacheService,
        IWriteRepository<PaymentTransaction> writeRepo,
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
                    logger.LogInformation("[PaymentStatusSyncJob] Transaction {TransactionCode} is PAID on PayOS", transaction.TransactionCode);
                    
                    await unitOfWork.ExecuteInTransactionAsync(async (cancellationToken) =>
                    {
                        // Re-check transaction status (idempotency)
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
                        
                        // Update transaction - nếu Webhook đã update thì sẽ có DbUpdateConcurrencyException
                        latestTransaction.Status = TransactionStatus.Success;
                        writeRepo.Update(latestTransaction);
                        await unitOfWork.SaveChangesAsync(cancellationToken);
                        
                        if (booking != null)
                        {
                            await HandleSuccessfulPayment(unitOfWork, publishEndpoint, cacheService, 
                                latestTransaction, booking, cancellationToken);
                        }
                        
                        await MarkLogAsResolved(logRepo, unitOfWork, latestTransaction.Id, cancellationToken);
                    }, ct);
                    break;
                    
                case "EXPIRED":
                case "CANCELLED":
                    logger.LogWarning("[PaymentStatusSyncJob] Transaction {TransactionCode} status is {Status}", 
                        transaction.TransactionCode, payOsResponse.Status);
                    
                    await unitOfWork.ExecuteInTransactionAsync(async (cancellationToken) =>
                    {
                        var booking = await unitOfWork.GetWriteRepository<Booking>()
                            .GetFirstOrDefaultAsync(b => b.Id == transaction.BookingId, cancellationToken);
                        
                        if (booking != null)
                        {
                            booking.Status = BookingStatus.Expired;
                            unitOfWork.GetWriteRepository<Booking>().Update(booking);
                            
                            var customer = await unitOfWork.GetWriteRepository<Customer>()
                                .GetByIdAsync(booking.CustomerId, cancellationToken);
                            
                            if (customer is { IsRenting: true })
                            {
                                customer.IsRenting = false;
                                unitOfWork.GetWriteRepository<Customer>().Update(customer);
                            }
                            
                            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
                            {
                                Status = BookingStatus.Expired,
                                Id = default,
                                CreatedAt = default,
                                CreatedBy = null,
                                UpdatedAt = default,
                                UpdatedBy = null
                            });
                            
                            await publishEndpoint.Publish(bookingUpdatedEvent, cancellationToken);
                        }
                        
                        writeRepo.Remove(transaction);
                        await unitOfWork.SaveChangesAsync(cancellationToken);
                        
                        logger.LogInformation("[PaymentStatusSyncJob] Deleted expired/cancelled transaction {TransactionCode}", 
                            transaction.TransactionCode);
                    }, ct);
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

    private async Task HandleSuccessfulPayment(
        IUnitOfWork unitOfWork,
        IPublishEndpoint publishEndpoint,
        ICacheService cacheService,
        PaymentTransaction transaction,
        Booking booking,
        CancellationToken ct)
    {
        // Customer Lock: Serialize customer operations
        var customerLockKey = CacheKeyHelper.GetCustomerPaymentLockKey(booking.CustomerId);
        var customerLockValue = Guid.NewGuid().ToString();
        var customerLockAcquired = await cacheService.AcquireLockAsync(customerLockKey, customerLockValue, CustomerLockTimeout, ct);
        
        if (!customerLockAcquired)
        {
            logger.LogWarning("[PaymentStatusSyncJob] Customer {CustomerId} has operation in progress. Will retry later.", booking.CustomerId);
            return;
        }
        
        try
        {
            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetByIdAsync(booking.CustomerId, ct);
            
            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetByIdAsync(booking.VehicleModelId, ct);
            
            switch (transaction.Type)
            {
                case TransactionType.Deposit:
                    booking.Status = BookingStatus.DepositPaid;
                    unitOfWork.GetWriteRepository<Booking>().Update(booking);
                    
                    if (customer is not null)
                    {
                        customer.IsRenting = true;
                        unitOfWork.GetWriteRepository<Customer>().Update(customer);
                    }

                    if (vehicleModel is not null)
                    {
                        vehicleModel.Status = VehicleStatus.Rented;
                        unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);
                    }
                    break;
                    
                case TransactionType.FinalPayment:
                    booking.Status = BookingStatus.InProgress;
                    unitOfWork.GetWriteRepository<Booking>().Update(booking);
                    
                    if (customer is not null)
                    {
                        customer.IsRenting = true;
                        unitOfWork.GetWriteRepository<Customer>().Update(customer);
                    }
                    break;
                
                case TransactionType.ViolationPayment:
                    // Update violation status to Paid (same as Webhook handling)
                    var violation = await unitOfWork.GetWriteRepository<BookingViolation>()
                        .GetFirstOrDefaultAsync(v => v.PaymentTransactionId == transaction.Id, cancellationToken: ct);

                    if (violation is not null)
                    {
                        violation.Status = ViolationStatus.Paid;
                        violation.ResolvedAt = DateTime.UtcNow;
                        violation.ResolvedBy = "System";
                        unitOfWork.GetWriteRepository<BookingViolation>().Update(violation);

                        // Check if customer has any other unresolved violations
                        var hasOtherViolations = await unitOfWork.GetReadRepository<BookingViolation>()
                            .ExistsAsync(
                                v => v.Booking.CustomerId == booking.CustomerId
                                     && v.Id != violation.Id
                                     && v.Status != ViolationStatus.Resolved
                                     && v.Status != ViolationStatus.Paid,
                                ct);

                        if (!hasOtherViolations && customer is not null)
                        {
                            customer.HasActiveViolation = false;
                            unitOfWork.GetWriteRepository<Customer>().Update(customer);
                        }
                    }
                    break;
            }
            
            await unitOfWork.SaveChangesAsync(ct);
            
            // Update vehicle available count
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(booking.VehicleId, ct);

            if (vehicle is not null)
            {
                var vehicleModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                    .GetAsync(filter: m => m.VehicleId == vehicle.Id, cancellationToken: ct);
                
                vehicle.AvailableCount = vehicleModels.Count(m => m.Status == VehicleStatus.Available);
                unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);

                var jsonModels = new List<CreateJsonVehicleModelDto>();
                
                foreach (var model in vehicleModels)
                {
                    Location? location = null;
                    if (model.LocationId.HasValue)
                    {
                        location = await unitOfWork.GetReadRepository<Location>()
                            .GetByIdAsync(model.LocationId.Value, ct);
                    }

                    jsonModels.Add(new CreateJsonVehicleModelDto
                    {
                        Id = model.Id,
                        NumberPlate = model.NumberPlate,
                        Mileage = model.Mileage,
                        Status = model.Status,
                        ConditionNotes = model.ConditionNotes,
                        LastAvailableAt = model.LastAvailableAt,
                        LocationId = model.LocationId,
                        LocationName = location?.Name,
                        Address = location?.Address
                    });
                }

                var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ => new VehicleModelsUpdatedEvent
                {
                    VehicleModelsJson = jsonModels.ToJson(),
                    AvailableCount = vehicle.AvailableCount,
                    Id = vehicle.Id,
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

                await publishEndpoint.Publish(evt, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }
            
            // Publish booking updated event
            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
            {
                Status = booking.Status,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            // Publish payment email event - consumer will query all needed data
            var paymentEmailEvent = new PaymentEmailEvent
            {
                TransactionId = transaction.Id,
                BookingId = booking.Id,
                CustomerId = booking.CustomerId,
                VehicleId = booking.VehicleId,
                TransactionType = transaction.Type,
                Amount = transaction.Amount,
                CreatedAt = DateTime.UtcNow
            };
            
            await publishEndpoint.Publish(paymentEmailEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            logger.LogInformation("[PaymentStatusSyncJob] Successfully processed transaction {TransactionCode}", 
                transaction.TransactionCode);
        }
        finally
        {
            await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, ct);
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