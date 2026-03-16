using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Commands.ProcessViolationPaymentSuccess;

public class ProcessViolationPaymentSuccessCommand : ICommand<bool>
{
    public required PaymentTransaction Transaction { get; init; }

    public required Booking Booking { get; init; }
}

public class ProcessViolationPaymentSuccessCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<ProcessViolationPaymentSuccessCommand, bool>
{
    public async Task<bool> Handle(ProcessViolationPaymentSuccessCommand request, CancellationToken ct)
    {
        var transaction = request.Transaction;
        var booking = request.Booking;

        var violation = await unitOfWork.GetWriteRepository<BookingViolation>()
            .GetFirstOrDefaultAsync(v => v.PaymentTransactionId == transaction.Id, cancellationToken: ct);

        if (violation is null) return false;

        violation.Status = ViolationStatus.Paid;
        violation.ResolvedAt = DateTime.UtcNow;
        violation.ResolvedBy = "System";
        unitOfWork.GetWriteRepository<BookingViolation>().Update(violation);

        var customer = await unitOfWork.GetWriteRepository<Customer>()
            .GetByIdAsync(booking.CustomerId, ct);

        var hasOtherViolations = await unitOfWork.GetWriteRepository<BookingViolation>()
            .ExistsAsync(
                v => v.BookingId == booking.Id
                     && v.Id != violation.Id
                     && v.Status != ViolationStatus.Resolved
                     && v.Status != ViolationStatus.Paid,
                ct);

        if (!hasOtherViolations && customer is not null)
        {
            customer.HasActiveViolation = false;
            unitOfWork.GetWriteRepository<Customer>().Update(customer);
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

        return true;
    }
}
