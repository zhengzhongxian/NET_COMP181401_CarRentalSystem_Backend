using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CompleteBookingCommand;

public class CompleteBookingCommand : ICommand<(bool Success, string Message, int LoyaltyPointsAwarded, int TotalLoyaltyPoints)>
{
    public Guid BookingId { get; set; }
}

public class CompleteBookingCommandHandler(IUnitOfWork unitOfWork, IPublishEndpoint publishEndpoint) 
    : IRequestHandler<CompleteBookingCommand, (bool, string, int, int)>
{
    public async Task<(bool, string, int, int)> Handle(
        CompleteBookingCommand request,
        CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, ct);

            if (booking == null)
                return (false, BookingMessage.CompleteBooking.BookingNotFound, 0, 0);
            
            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetFirstOrDefaultAsync(c => c.CustomerId == booking.CustomerId, cancellationToken: ct);

            if (customer == null)
                return (false, BookingMessage.CompleteBooking.BookingNotFound, 0, 0);

            // Ensure navigation property is set for later use (LoyaltyPoints update)
            booking.Customer = customer;

            var violations = await unitOfWork.GetWriteRepository<BookingViolation>()
                .GetAsync(v => v.BookingId == booking.Id, cancellationToken: ct);

            if (booking.Status != BookingStatus.Returned)
                return (false, BookingMessage.CompleteBooking.InvalidStatus, 0, 0);

            if (booking.Status == BookingStatus.Completed)
                return (false, BookingMessage.CompleteBooking.AlreadyCompleted, 0, 0);

            var unresolvedViolations = violations
                .Where(v => v.Status != ViolationStatus.Resolved && v.Status != ViolationStatus.Paid)
                .ToList();

            if (unresolvedViolations.Count != 0)
                return (false, BookingMessage.CompleteBooking.HasUnresolvedViolations, 0, 0);

            var settings = await unitOfWork.GetReadRepository<SystemSetting>()
                .GetAsync(cancellationToken: ct);

            var loyaltyPointsPerBooking = settings.GetInt(
                SystemSettingConstants.BookingSettings.LoyaltyPointsPerBooking, 
                100);
            
            booking.Status = BookingStatus.Completed;
            
            var depositAmount = booking.TotalPrice * booking.DepositRatio;
            var refundScheduledDate = (booking.ActualEndDate ?? DateTime.UtcNow).AddDays(30);
            booking.DepositRefundScheduledAt = refundScheduledDate;
            
            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            
            var depositRefundRequest = new RefundRequest
            {
                BookingId = booking.Id,
                CustomerId = booking.CustomerId,
                Amount = depositAmount,
                Status = RefundStatus.Pending,
                IsDepositRefund = true,
                ScheduledAt = refundScheduledDate,
                Reason = $"Hoàn tiền cọc ({booking.DepositRatio * 100}%) sau 30 ngày kể từ khi trả xe. " +
                         $"Dự kiến hoàn: {refundScheduledDate:dd/MM/yyyy HH:mm} UTC",
                CreatedAt = DateTime.UtcNow
            };
            
            await unitOfWork.GetWriteRepository<RefundRequest>().AddAsync(depositRefundRequest, ct);
            
            booking.Customer.LoyaltyPoints += loyaltyPointsPerBooking;
            
            var hasOtherActiveViolations = await unitOfWork.GetWriteRepository<BookingViolation>()
                .ExistsAsync(
                    v => v.Booking.CustomerId == booking.CustomerId 
                         && v.BookingId != booking.Id
                         && v.Status != ViolationStatus.Resolved 
                         && v.Status != ViolationStatus.Paid,
                    ct);

            if (!hasOtherActiveViolations)
            {
                booking.Customer.HasActiveViolation = false;
            }
            
            booking.Customer.IsRenting = false;
            unitOfWork.GetWriteRepository<Customer>().Update(booking.Customer);
            
            var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetFirstOrDefaultAsync(vm => vm.Id == booking.VehicleModelId, ct);

            if (vehicleModel != null)
            {
                vehicleModel.Status = VehicleStatus.Available;
                vehicleModel.LastAvailableAt = DateTime.UtcNow;
                unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);
            }
            
            await unitOfWork.SaveChangesAsync(ct);
            
            if (vehicleModel != null)
            {
                var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                    .GetByIdAsync(vehicleModel.VehicleId, ct);

                if (vehicle != null)
                {
                    var allModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                        .GetAsync(filter: vm => vm.VehicleId == vehicle.Id, cancellationToken: ct);

                    vehicle.AvailableCount = allModels.Count(m => m.Status == VehicleStatus.Available);
                    unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);

                    var locationIds = allModels
                        .Where(vm => vm.LocationId.HasValue)
                        .Select(vm => vm.LocationId!.Value)
                        .Distinct()
                        .ToList();
                    
                    var locations = await unitOfWork.GetWriteRepository<Location>()
                        .GetAsync(filter: l => locationIds.Contains(l.Id), cancellationToken: ct);
                    var locationDict = locations.ToDictionary(l => l.Id);

                    var modelsDto = allModels.Select(vm =>
                    {
                        var vmLocation = vm.LocationId.HasValue && locationDict.TryGetValue(vm.LocationId.Value, out var loc) ? loc : null;
                        return new CreateJsonVehicleModelDto
                        {
                            Id = vm.Id,
                            NumberPlate = vm.NumberPlate,
                            Mileage = vm.Mileage,
                            LocationId = vm.LocationId,
                            LocationName = vmLocation?.Name,
                            Address = vmLocation?.Address,
                            Status = vm.Status,
                            ConditionNotes = vm.ConditionNotes,
                            LastAvailableAt = vm.LastAvailableAt
                        };
                    }).ToList();

                    var vehicleModelsEvent = vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ => new VehicleModelsUpdatedEvent
                    {
                        Id = vehicle.Id,
                        VehicleModelsJson = modelsDto.ToJson(),
                        AvailableCount = vehicle.AvailableCount,
                        CreatedAt = default,
                        CreatedBy = null,
                        UpdatedAt = default,
                        UpdatedBy = null
                    });

                    await publishEndpoint.Publish(vehicleModelsEvent, ct);
                    await unitOfWork.SaveChangesAsync(ct);
                }
            }

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

            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ => new BookingUpdatedEvent
            {
                Status = booking.Status,
                DepositRefundScheduledAt = booking.DepositRefundScheduledAt,
                BookingViolationsJson = violationsJson,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            
            await unitOfWork.SaveChangesAsync(ct);

            var message = string.Format(
                BookingMessage.CompleteBooking.Success, 
                loyaltyPointsPerBooking);

            return (true, message, loyaltyPointsPerBooking, booking.Customer.LoyaltyPoints);


        }, cancellationToken);
    }
}

