using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Domain.Entities;
using MassTransit;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Violations.Commands.ResolveViolationCommand;

public class ResolveViolationCommand : ICommand<(bool Success, string Message)>
{
    public required Guid ViolationId { get; set; }
}

public class ResolveViolationCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<ResolveViolationCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(ResolveViolationCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async ct =>
        {
            var violation = await unitOfWork.GetWriteRepository<BookingViolation>()
                .GetFirstOrDefaultAsync(v => v.Id == request.ViolationId, ct);

            if (violation == null)
                return (false, ViolationMessage.Resolve.NotFound);

            if (violation.Status == ViolationStatus.Resolved)
                return (false, ViolationMessage.Resolve.InvalidStatus);
            
            violation.Status = ViolationStatus.Resolved;
            unitOfWork.GetWriteRepository<BookingViolation>().Update(violation);

            await unitOfWork.SaveChangesAsync(ct);
            
            var booking = await unitOfWork.GetWriteRepository<Booking>()
                .GetFirstOrDefaultAsync(b => b.Id == violation.BookingId, ct);

            if (booking != null)
            {
                // Rebuild violations json from write DB
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
                    BookingViolationsJson = violationsJson,
                    Id = default,
                    CreatedAt = default,
                    CreatedBy = null,
                    UpdatedAt = default,
                    UpdatedBy = null
                });

                await publishEndpoint.Publish(bookingUpdatedEvent, ct);
                await unitOfWork.SaveChangesAsync(ct);
            }

            return (true, ViolationMessage.Resolve.Success);
        }, cancellationToken);
    }
}
