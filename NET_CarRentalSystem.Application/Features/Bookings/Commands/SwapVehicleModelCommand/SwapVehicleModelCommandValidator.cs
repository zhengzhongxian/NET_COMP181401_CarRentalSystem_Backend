using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.SwapVehicleModelCommand;

public class SwapVehicleModelCommandValidator : AbstractValidator<SwapVehicleModelCommand>
{
    public SwapVehicleModelCommandValidator()
    {
        RuleFor(x => x.BookingId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.BookingIdRequired);

        RuleFor(x => x.NewVehicleModelId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.NewVehicleModelIdRequired);

        RuleFor(x => x.OldVehicleModelStatus)
            .IsInEnum()
            .WithMessage(BookingValidationMessage.OldVehicleModelStatusInvalid);
    }
}
