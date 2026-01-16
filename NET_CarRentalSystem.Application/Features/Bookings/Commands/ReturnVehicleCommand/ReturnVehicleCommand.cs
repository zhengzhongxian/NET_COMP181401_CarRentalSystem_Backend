using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.ReturnVehicleCommand;

public class ReturnVehicleCommand : ICommand<(bool, string)>
{
    public string? QrToken { get; set; }
}

public class ReturnVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService,
    ICacheService cacheService,
    ICryptographyService cryptographyService,
    IPublishEndpoint publishEndpoint) : IRequestHandler<ReturnVehicleCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(
        ReturnVehicleCommand request,
        CancellationToken cancellationToken)
    {
        #region Validate Token & User

        if (string.IsNullOrWhiteSpace(request.QrToken))
            return (false, BookingMessage.Return.InvalidToken);

        var userId = currentUserService.GetUserId();
        if (userId == null)
            return (false, BookingMessage.Return.Unauthorized);

        string encrypted;
        try
        {
            encrypted = TokenHelper.FromUrlSafeBase64(request.QrToken);
        }
        catch
        {
            return (false, BookingMessage.Return.InvalidToken);
        }

        string payload;
        try
        {
            payload = cryptographyService.DecryptAes(encrypted);
        }
        catch
        {
            return (false, BookingMessage.Return.InvalidToken);
        }

        // payload = "{locationId}:{rawToken}"
        var parts = payload.Split(':', 2);
        if (parts.Length != 2 || !Guid.TryParse(parts[0], out var locationId))
            return (false, BookingMessage.Return.InvalidToken);

        var rawToken = parts[1];

        var cacheKey = CacheKeyHelper.GetQrReturnVehicleKey(rawToken);
        var cachedToken = await cacheService.GetStringAsync(cacheKey, cancellationToken);

        if (string.IsNullOrEmpty(cachedToken))
            return (false, BookingMessage.Return.Expired);

        if (cachedToken != encrypted)
            return (false, BookingMessage.Return.InvalidToken);

        #endregion

        #region Load Customer & Booking

        var customer = await unitOfWork
            .GetReadRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.UserId == userId.Value, cancellationToken: cancellationToken);

        if (customer == null)
            return (false, BookingMessage.Return.CustomerNotFound);

        var booking = await unitOfWork
            .GetWriteRepository<Booking>()
            .GetFirstOrDefaultAsync(
                b => b.CustomerId == customer.Id &&
                     b.Status == BookingStatus.InProgress,
                cancellationToken);

        if (booking == null)
            return (false, BookingMessage.Return.BookingNotFound);

        if (booking.PickupLocationId != Guid.Empty &&
            booking.PickupLocationId != locationId)
            return (false, BookingMessage.Return.InvalidToken);

        #endregion

        #region Update Booking State

        booking.Status = BookingStatus.Returned;
        booking.ActualEndDate = DateTime.UtcNow;
        booking.ReturnLocationId = locationId;

        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            unitOfWork.GetWriteRepository<Booking>().Update(booking);
            await unitOfWork.SaveChangesAsync(ct);

            #region Update Vehicle Model

            var location = await unitOfWork
                .GetReadRepository<Location>()
                .GetByIdAsync(locationId, ct);

            var vehicleModel = await unitOfWork
                .GetWriteRepository<VehicleModel>()
                .GetByIdAsync(booking.VehicleModelId, ct);

            if (vehicleModel != null)
            {
                vehicleModel.LocationId = locationId;
                vehicleModel.RealTimeLocation = location?.Name;
                // Do NOT change vehicleModel.Status here; status update is handled in a later step
                // vehicleModel.Status = VehicleStatus.Available;
                // vehicleModel.LastAvailableAt = DateTime.UtcNow;

                unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);

                // Build JSON for all models of the vehicle using CreateJsonVehicleModelDto
                var allModels = await unitOfWork.GetWriteRepository<VehicleModel>()
                    .GetAsync(filter: vm => vm.VehicleId == vehicleModel.VehicleId, cancellationToken: ct);

                var modelsDto = allModels.Select(vm => new CreateJsonVehicleModelDto
                {
                    Id = vm.Id,
                    NumberPlate = vm.NumberPlate,
                    Mileage = vm.Mileage,
                    LocationId = vm.LocationId,
                    LocationName = vm.Location?.Name,
                    Address = vm.Location?.Address,
                    Status = vm.Status,
                    ConditionNotes = vm.ConditionNotes,
                    LastAvailableAt = vm.LastAvailableAt
                }).ToList();

                var modelsJson = modelsDto.ToJson();

                var vehicleUpdatedEvent = vehicleModel.Vehicle.ToUpdatedEvent<Vehicle, VehicleModelsUpdatedEvent, Guid>(_ => new VehicleModelsUpdatedEvent
                {
                    Id = vehicleModel.VehicleId,
                    VehicleModelsJson = modelsJson,
                    AvailableCount = modelsDto.Count(m => m.Status == VehicleStatus.Available),
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

                await publishEndpoint.Publish(vehicleUpdatedEvent, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }

            #endregion

            #region Publish Booking Updated Event

            var bookingUpdatedEvent =
                booking.ToUpdatedEvent<Booking, BookingUpdatedEvent, Guid>(_ =>
                    new BookingUpdatedEvent
                    {
                        Id = booking.Id,
                        Status = booking.Status,
                        ActualEndDate = booking.ActualEndDate,
                        CreatedAt = default,
                        CreatedBy = null,
                        UpdatedAt = default,
                        UpdatedBy = null,
                    });

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);

            #endregion

            await cacheService.RemoveAsync(cacheKey, ct);

            return (true, BookingMessage.Return.Success);

        }, cancellationToken);

        #endregion
    }
}
