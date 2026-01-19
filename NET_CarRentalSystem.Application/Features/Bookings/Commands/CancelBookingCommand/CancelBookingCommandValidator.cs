using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.CancelBookingCommand;

public class CancelBookingCommandValidator : AbstractValidator<CancelBookingCommand>
{
    public CancelBookingCommandValidator()
    {
        RuleFor(x => x.BookingId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.BookingIdRequired);

        RuleFor(x => x.CancellationReason)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.CancellationReasonRequired)
            .MaximumLength(1000)
            .WithMessage(BookingValidationMessage.CancellationReasonTooLong);
    }
}

