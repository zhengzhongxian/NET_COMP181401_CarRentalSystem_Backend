using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.GenerateBookingContractCommand;

public class GenerateBookingContractCommandValidator : AbstractValidator<GenerateBookingContractCommand>
{
    public GenerateBookingContractCommandValidator()
    {
        RuleFor(x => x.BookingId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.BookingIdRequired);
    }
}

