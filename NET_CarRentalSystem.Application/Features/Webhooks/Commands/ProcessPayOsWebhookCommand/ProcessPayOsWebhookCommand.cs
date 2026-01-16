using MediatR;
using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;

namespace NET_CarRentalSystem.Application.Features.Webhooks.Commands.ProcessPayOsWebhookCommand;

public class ProcessPayOsWebhookCommand : ICommand<bool>
{
    public required PayOsWebhookData WebhookData { get; set; }
}

public class ProcessPayOsWebhookCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    ICacheService cacheService,
    ILogger<ProcessPayOsWebhookCommandHandler> logger) : IRequestHandler<ProcessPayOsWebhookCommand, bool>
{
    private static readonly TimeSpan CustomerLockTimeout = TimeSpan.FromSeconds(30);
    
    public async Task<bool> Handle(ProcessPayOsWebhookCommand request, CancellationToken cancellationToken)
    {
        // Note: Transaction updates được bảo vệ bởi RowVersion (optimistic concurrency)
        // Nếu Webhook và SyncJob cùng update → 1 thằng thành công, 1 thằng nhận DbUpdateConcurrencyException
        return await ProcessWebhookAsync(request, cancellationToken);
    }
    
    private async Task<bool> ProcessWebhookAsync(ProcessPayOsWebhookCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var webhookLog = new WebhookLog
            {
                EventType = "PaymentCompleted",
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
            
            // Idempotency check: Nếu transaction đã được xử lý thì bỏ qua
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
            
            // Critical check: Nếu booking đã bị cancelled (do customer đặt booking mới)
            // thì không xử lý - tiền đã được tạo RefundRequest trong CreateBooking
            if (booking.Status == BookingStatus.Cancelled)
            {
                webhookLog.Status = WebhookLogStatus.Failed;
                webhookLog.ErrorCode = WebhookErrorCode.BookingAlreadyCancelled;
                webhookLog.ProcessedAt = DateTime.UtcNow;
                await unitOfWork.SaveChangesAsync(ct);
                logger.LogWarning(
                    "[Webhook] Booking {BookingId} was cancelled. Transaction {TransactionCode} will be refunded via RefundRequest.",
                    booking.Id, transaction.TransactionCode);
                return false;
            }
            
            // Customer Lock: Serialize operations liên quan đến customer state
            // - Ngăn CreateBooking tạo booking mới trong khi đang process payment
            // - Đảm bảo Customer.IsRenting được update đúng
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
                return await ProcessPaymentSuccessAsync(transaction, booking, webhookLog, ct);
            }
            finally
            {
                await cacheService.ReleaseLockAsync(customerLockKey, customerLockValue, ct);
            }
        }, cancellationToken);
    }
    
    private async Task<bool> ProcessPaymentSuccessAsync(
        PaymentTransaction transaction, 
        Booking booking,
        WebhookLog webhookLog,
        CancellationToken ct)
    {
        transaction.Status = TransactionStatus.Success;
        unitOfWork.GetWriteRepository<PaymentTransaction>().Update(transaction);

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetByIdAsync(booking.CustomerId, ct);
        
        var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
            .GetByIdAsync(booking.VehicleModelId, ct);

        switch (transaction.Type)
        {
            case TransactionType.Deposit:
            {
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
            }
            case TransactionType.FinalPayment:
            {
                booking.Status = BookingStatus.InProgress;
                unitOfWork.GetWriteRepository<Booking>().Update(booking);

                if (customer is not null)
                {
                    customer.IsRenting = true;
                    unitOfWork.GetWriteRepository<Customer>().Update(customer);
                }
                break;
            }
            case TransactionType.ViolationPayment:
            {
                // Update violation status to Paid
                var violation = await unitOfWork.GetWriteRepository<BookingViolation>()
                    .GetFirstOrDefaultAsync(
                        v => v.PaymentTransactionId == transaction.Id,
                        cancellationToken: ct);

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

                    // Rebuild violations JSON and publish BookingUpdatedEvent so read-flat is up-to-date
                    var allViolations = await unitOfWork.GetWriteRepository<BookingViolation>()
                        .GetAsync(v => v.BookingId == booking.Id, null, null, ct);

                    var violationsDto = allViolations.Select(v => new CreateJsonBookingViolationDto
                    {
                        Id = v.Id,
                        ViolationType = v.ViolationType.ToString(),
                        Amount = v.Amount,
                        Description = v.Description,
                        Details = v.Details,
                        Status = v.Status.ToString()
                    }).ToList();

                    var violationsJson = violationsDto.ToJson();

                    var bookingViolationsUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
                    {
                        BookingViolationsJson = violationsJson,
                        Id = default,
                        CreatedAt = default,
                        CreatedBy = null,
                        UpdatedAt = default,
                        UpdatedBy = null
                    });

                    await publishEndpoint.Publish(bookingViolationsUpdatedEvent, ct);
                    await unitOfWork.SaveChangesAsync(ct);
                }
                break;
            }
        }
        
        // SaveChanges here - nếu có DbUpdateConcurrencyException sẽ được catch ở trên
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
        
        logger.LogInformation("[Webhook] PaymentEmailEvent published for BookingId={BookingId}", booking.Id);
        
        webhookLog.Status = WebhookLogStatus.Success;
        webhookLog.ErrorCode = WebhookErrorCode.None;
        webhookLog.ProcessedAt = DateTime.UtcNow;
        webhookLog.ProcessedBy = "System";
        
        await unitOfWork.SaveChangesAsync(ct);

        logger.LogInformation("[Webhook] Successfully processed transaction {TransactionCode}", transaction.TransactionCode);
        return true;
    }
}
