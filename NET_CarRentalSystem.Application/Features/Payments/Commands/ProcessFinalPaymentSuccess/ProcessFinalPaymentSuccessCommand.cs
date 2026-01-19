using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessFinalPaymentSuccess;

public class ProcessFinalPaymentSuccessCommand : ICommand<bool>
{
    public required PaymentTransaction Transaction { get; init; }

    public required Booking Booking { get; init; }
}

public class ProcessFinalPaymentSuccessCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    INotificationHub notificationHub) : IRequestHandler<ProcessFinalPaymentSuccessCommand, bool>
{
    public async Task<bool> Handle(ProcessFinalPaymentSuccessCommand request, CancellationToken ct)
    {
        var transaction = request.Transaction;
        var booking = request.Booking;

        booking.Status = BookingStatus.InProgress;
        unitOfWork.GetWriteRepository<Booking>().Update(booking);

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetByIdAsync(booking.CustomerId, ct);

        if (customer is not null)
        {
            customer.IsRenting = true;
            unitOfWork.GetWriteRepository<Customer>().Update(customer);
        }

        await unitOfWork.SaveChangesAsync(ct);

        await PublishBookingUpdatedEventAsync(booking, ct);

        await PublishPaymentEmailEventAsync(transaction, booking, ct);

        await SendRealTimeNotificationAsync(transaction, booking, customer, ct);

        return true;
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
        var vehicle = await unitOfWork.GetReadRepository<Vehicle>()
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
            NotificationType = "FinalPaymentSuccess",
            Message = $"{customerName} đã thanh toán thành công xe {vehicleName}"
        };

        await notificationHub.SendToRoleAsync("Admin", "ReceivePaymentNotification", notification, ct);
        await notificationHub.SendToRoleAsync("Staff", "ReceivePaymentNotification", notification, ct);
    }
}
