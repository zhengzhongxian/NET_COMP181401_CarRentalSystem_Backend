using MediatR;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CancelBookingCommand;

public class CancelBookingCommand : ICommand<(bool, string)>
{
    public required Guid BookingId { get; set; }
    
    public required string CancellationReason { get; set; }
}

public class CancelBookingCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    IPublishEndpoint publishEndpoint,
    ICacheService cacheService) : IRequestHandler<CancelBookingCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(CancelBookingCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var userId = currentUserService.GetUserId();
            if (userId == null)
                return (false, BookingMessage.Cancel.Error);

            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetFirstOrDefaultAsync(c => c.UserId == userId.Value, ct);

            if (customer == null)
                return (false, BookingMessage.Create.CustomerNotFound);

            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, ct);

            if (booking == null)
                return (false, BookingMessage.Cancel.BookingNotFound);

            if (booking.CustomerId != customer.CustomerId)
                return (false, BookingMessage.Cancel.NotYourBooking);

            if (booking.Status == BookingStatus.Cancelled)
                return (false, BookingMessage.Cancel.AlreadyCancelled);

            if (booking.Status != BookingStatus.DepositPaid)
                return (false, BookingMessage.Cancel.InvalidBookingStatus);

            var settings = await unitOfWork.GetReadRepository<SystemSetting>().GetAsync(cancellationToken: ct);
            var maxCancellations = settings.GetInt(SystemSettingConstants.CancellationSettings.MaxCancellationsPerMonth, 3);
            var refundableHoursLimit = settings.GetInt(SystemSettingConstants.CancellationSettings.RefundableHoursLimit, 24);

            var currentCancellationCount = await GetCancellationCountAsync(customer.CustomerId, ct);
            
            if (currentCancellationCount >= maxCancellations)
                return (false, string.Format(BookingMessage.Cancel.MaxCancellationsReached, maxCancellations));

            booking.Status = BookingStatus.Cancelled;
            booking.CancellationReason = request.CancellationReason;
            unitOfWork.GetWriteRepository<Booking>().Update(booking);

            customer.IsRenting = false;
            unitOfWork.GetWriteRepository<Customer>().Update(customer);

            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetByIdAsync(booking.VehicleModelId, ct);
            
            if (vehicleModel != null)
            {
                vehicleModel.Status = VehicleStatus.Available;
                vehicleModel.LastAvailableAt = DateTime.UtcNow;
                unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);
            }

            await unitOfWork.SaveChangesAsync(ct);
            
            await IncrementCancellationCountAsync(customer.CustomerId, ct);

            var timeSinceBooking = DateTime.UtcNow - booking.CreatedAt;
            var hoursSinceBooking = timeSinceBooking!.Value.TotalHours;
            var isRefundEligible = hoursSinceBooking <= refundableHoursLimit;
            string resultMessage;

            if (isRefundEligible)
            {
                var depositTransaction = await unitOfWork.GetWriteRepository<PaymentTransaction>()
                    .GetFirstOrDefaultAsync(
                        t => t.BookingId == booking.Id && 
                             t.Type == TransactionType.Deposit && 
                             t.Status == TransactionStatus.Success, 
                        ct);

                if (depositTransaction != null)
                {
                    var refundRequest = new RefundRequest
                    {
                        BookingId = booking.Id,
                        CustomerId = customer.CustomerId,
                        Amount = depositTransaction.Amount,
                        Status = RefundStatus.Pending,
                        Reason = request.CancellationReason
                    };

                    await unitOfWork.GetWriteRepository<RefundRequest>().AddAsync(refundRequest, ct);
                    await unitOfWork.SaveChangesAsync(ct);
                    
                    var refundEmailEvent = new RefundEmailEvent
                    {
                        RefundRequestId = refundRequest.Id,
                        BookingId = booking.Id,
                        CustomerId = customer.CustomerId,
                        Amount = depositTransaction.Amount,
                        Reason = request.CancellationReason,
                        EmailType = RefundEmailType.Notification,
                        CreatedAt = DateTime.UtcNow
                    };
                    
                    await publishEndpoint.Publish(refundEmailEvent, ct);
                }
                
                resultMessage = BookingMessage.Cancel.SuccessWithRefundRequest;
            }
            else
            {
                resultMessage = BookingMessage.Cancel.SuccessNoRefund;
            }

            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(booking.VehicleId, ct);
            
            if (vehicle != null)
            {
                var allModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                    .GetAsync(
                        filter: vm => vm.VehicleId == vehicle.Id,
                        cancellationToken: ct);

                vehicle.AvailableCount = allModels.Count(vm => vm.Status == VehicleStatus.Available);
                unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);

                var modelsJson = allModels.Select(vm => new CreateJsonVehicleModelDto
                {
                    Id = vm.Id,
                    NumberPlate = vm.NumberPlate,
                    Mileage = vm.Mileage,
                    Status = vm.Status,
                    ConditionNotes = vm.ConditionNotes,
                    LocationId = vm.LocationId,
                    LocationName = vm.Location?.Name,
                    Address = vm.Location?.Address,
                    LastAvailableAt = vm.LastAvailableAt
                }).ToList().ToJson();

                var vehicleUpdatedEvent = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ =>
                    new VehicleModelsUpdatedEvent
                    {
                        VehicleModelsJson = modelsJson,
                        AvailableCount = vehicle.AvailableCount,
                        Id = default,
                        CreatedAt = default,
                        CreatedBy = null,
                        UpdatedAt = default,
                        UpdatedBy = null
                    });

                await publishEndpoint.Publish(vehicleUpdatedEvent, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }

            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(
                b => new BookingUpdatedEvent
                {
                    Status = b.Status,
                    CancellationReason = b.CancellationReason,
                    Id = default,
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);

            return (true, resultMessage);

        }, cancellationToken);
    }
    
    private async Task<int> GetCancellationCountAsync(Guid customerId, CancellationToken ct)
    {
        var key = CacheKeyHelper.GetCancellationCacheKey(customerId);
        var countStr = await cacheService.GetStringAsync(key, ct);
        return int.TryParse(countStr, out var count) ? count : 0;
    }
    
    private async Task IncrementCancellationCountAsync(Guid customerId, CancellationToken ct)
    {
        var key = CacheKeyHelper.GetCancellationCacheKey(customerId);
        var currentCount = await GetCancellationCountAsync(customerId, ct);
        var newCount = currentCount + 1;
        
        var endOfMonth = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1)
            .AddMonths(1)
            .AddSeconds(-1);
        
        await cacheService.SetStringAsync(key, newCount.ToString(), endOfMonth, ct);
    }
}
