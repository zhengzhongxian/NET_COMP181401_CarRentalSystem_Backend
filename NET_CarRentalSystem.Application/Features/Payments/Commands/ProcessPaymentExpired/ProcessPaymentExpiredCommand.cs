using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessPaymentExpired;

public class ProcessPaymentExpiredCommand : ICommand<bool>
{
    public required PaymentTransaction Transaction { get; init; }
}

public class ProcessPaymentExpiredCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<ProcessPaymentExpiredCommand, bool>
{
    public async Task<bool> Handle(ProcessPaymentExpiredCommand request, CancellationToken ct)
    {
        var transaction = request.Transaction;

        var booking = await unitOfWork.GetWriteRepository<Booking>()
            .GetFirstOrDefaultAsync(b => b.Id == transaction.BookingId, ct);

        if (booking is not null)
        {
            booking.Status = BookingStatus.Expired;
            unitOfWork.GetWriteRepository<Booking>().Update(booking);

            var customer = await unitOfWork.GetWriteRepository<Customer>()
                .GetByIdAsync(booking.CustomerId, ct);

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

            await publishEndpoint.Publish(bookingUpdatedEvent, ct);
        }

        unitOfWork.GetWriteRepository<PaymentTransaction>().Remove(transaction);
        await unitOfWork.SaveChangesAsync(ct);

        return true;
    }
}
