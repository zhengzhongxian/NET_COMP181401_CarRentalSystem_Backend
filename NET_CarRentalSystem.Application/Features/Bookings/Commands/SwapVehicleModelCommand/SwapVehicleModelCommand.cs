using MediatR;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Update;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.SwapVehicleModelCommand;

public class SwapVehicleModelCommand : ICommand<(SwapVehicleModelDto?, string)>
{
    public Guid BookingId { get; init; }
    
    public Guid NewVehicleModelId { get; init; }
    
    public VehicleStatus OldVehicleModelStatus { get; init; }
    
    public string? Reason { get; init; }
}

public class SwapVehicleModelCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<SwapVehicleModelCommand, (SwapVehicleModelDto?, string)>
{
    public async Task<(SwapVehicleModelDto?, string)> Handle(SwapVehicleModelCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == request.BookingId, cancellationToken: ct);

            if (booking == null)
                return (null, BookingMessage.SwapVehicleModel.BookingNotFound);

            if (booking.Status != BookingStatus.DepositPaid)
                return (null, BookingMessage.SwapVehicleModel.InvalidBookingStatus);

            var oldVehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetFirstOrDefaultAsync(vm => vm.Id == booking.VehicleModelId, cancellationToken: ct);

            if (oldVehicleModel == null)
                return (null, BookingMessage.SwapVehicleModel.OldVehicleModelNotFound);

            var newVehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
                .GetFirstOrDefaultAsync(vm => vm.Id == request.NewVehicleModelId, cancellationToken: ct);

            if (newVehicleModel == null)
                return (null, BookingMessage.SwapVehicleModel.VehicleModelNotFound);

            if (newVehicleModel.Status != VehicleStatus.Available)
                return (null, BookingMessage.SwapVehicleModel.VehicleModelNotAvailable);

            if (newVehicleModel.VehicleId != oldVehicleModel.VehicleId)
                return (null, BookingMessage.SwapVehicleModel.VehicleModelNotSameVehicle);

            if (newVehicleModel.LocationId != oldVehicleModel.LocationId)
                return (null, BookingMessage.SwapVehicleModel.VehicleModelNotAvailable);

            oldVehicleModel.Status = request.OldVehicleModelStatus;
            oldVehicleModel.LastAvailableAt = DateTime.UtcNow;
            
            booking.VehicleModelId = request.NewVehicleModelId;
            booking.SwapReason = request.Reason;

            newVehicleModel.Status = VehicleStatus.Rented;
            newVehicleModel.LastAvailableAt = null;

            unitOfWork.GetWriteRepository<VehicleModel>().Update(oldVehicleModel);
            unitOfWork.GetWriteRepository<VehicleModel>().Update(newVehicleModel);
            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            
            await unitOfWork.SaveChangesAsync(ct);

            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetFirstOrDefaultAsync(v => v.Id == oldVehicleModel.VehicleId, cancellationToken: ct);

            if (vehicle != null)
            {
                var allModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                    .GetAsync(vm => vm.VehicleId == vehicle.Id, cancellationToken: ct);

                var modelsJson = BuildVehicleModelsJson(allModels);
                
                var availableCount = allModels.Count(m => m.Status == VehicleStatus.Available);
                vehicle.AvailableCount = availableCount;

                unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
                await unitOfWork.SaveChangesAsync(ct);

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
            }

            var bookingUpdatedEvent = booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(
                b => new BookingUpdatedEvent
                {
                    VehicleModelId = b.VehicleModelId,
                    NumberPlate = newVehicleModel.NumberPlate,
                    VehicleStatus = newVehicleModel.Status.ToString(),
                    Status = b.Status,
                    SwapReason = b.SwapReason,
                    Description = b.Description,
                    Id = default,
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);

            var resultDto = new SwapVehicleModelDto
            {
                BookingId = booking.Id,
                NewVehicleModelId = newVehicleModel.Id,
                Reason = request.Reason
            };

            return (resultDto, BookingMessage.SwapVehicleModel.Success);

        }, cancellationToken);
    }
    
    private static string BuildVehicleModelsJson(List<VehicleModel> models)
    {
        var modelDtos = models.Select(m => new CreateJsonVehicleModelDto
        {
            Id = m.Id,
            NumberPlate = m.NumberPlate,
            Mileage = m.Mileage,
            Status = m.Status,
            ConditionNotes = m.ConditionNotes,
            LocationId = m.LocationId,
            LocationName = m.Location?.Name,
            Address = m.Location?.Address
        }).ToList();

        return modelDtos.ToJson();
    }
}
