using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleModelDTOs.Create;
using NET_CarRentalSystem.Application.Models.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessDepositSuccess;

public class ProcessDepositSuccessCommand : ICommand<bool>
{
    public required PaymentTransaction Transaction { get; init; }

    public required Booking Booking { get; init; }
}

public class ProcessDepositSuccessCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    INotificationHub notificationHub) : IRequestHandler<ProcessDepositSuccessCommand, bool>
{
    public async Task<bool> Handle(ProcessDepositSuccessCommand request, CancellationToken ct)
    {
        var transaction = request.Transaction;
        var booking = request.Booking;

        booking.Status = BookingStatus.DepositPaid;
        unitOfWork.GetWriteRepository<Booking>().Update(booking);

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetByIdAsync(booking.CustomerId, ct);

        if (customer is not null)
        {
            customer.IsRenting = true;
            unitOfWork.GetWriteRepository<Customer>().Update(customer);
        }

        var vehicleModel = await unitOfWork.GetWriteRepository<VehicleModel>()
            .GetByIdAsync(booking.VehicleModelId, ct);

        if (vehicleModel is not null)
        {
            vehicleModel.Status = VehicleStatus.Rented;
            unitOfWork.GetWriteRepository<VehicleModel>().Update(vehicleModel);
        }

        await unitOfWork.SaveChangesAsync(ct);

        await UpdateVehicleAvailableCountAsync(booking, ct);

        await PublishBookingUpdatedEventAsync(booking, ct);

        await PublishPaymentEmailEventAsync(transaction, booking, ct);

        await SendRealTimeNotificationAsync(transaction, booking, customer, ct);

        return true;
    }

    private async Task UpdateVehicleAvailableCountAsync(Booking booking, CancellationToken ct)
    {
        var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
            .GetByIdAsync(booking.VehicleId, ct);

        if (vehicle is null) return;

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

    private async Task PublishBookingUpdatedEventAsync(Booking booking, CancellationToken ct)
    {
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
    }

    private async Task PublishPaymentEmailEventAsync(PaymentTransaction transaction, Booking booking, CancellationToken ct)
    {
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
    }

    private async Task SendRealTimeNotificationAsync(
        PaymentTransaction transaction,
        Booking booking,
        Customer? customer,
        CancellationToken ct)
    {
        var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
            .GetByIdAsync(booking.VehicleId, ct);

        var customerName = customer is not null
            ? $"{customer.FirstName} {customer.LastName}"
            : "Khách hàng";

        var vehicleName = vehicle is not null
            ? $"{vehicle.Manufacturer} {vehicle.Model}"
            : "Xe";

        var notification = new PaymentSuccessNotification
        {
            BookingId = booking.Id,
            TransactionType = transaction.Type,
            Amount = transaction.Amount,
            CustomerName = customerName,
            VehicleName = vehicleName,
            NotificationType = "DepositSuccess",
            Message = $"{customerName} đã đặt cọc thành công xe {vehicleName}"
        };

        await notificationHub.SendToAllAsync("ReceivePaymentNotification", notification, ct);
    }
}
