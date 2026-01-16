using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateAfterReturnCommand;

public class UpdateAfterReturnCommandValidator : AbstractValidator<UpdateAfterReturnCommand>
{
    public UpdateAfterReturnCommandValidator()
    {
        RuleFor(x => x.BookingId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.BookingIdRequired);

        RuleFor(x => x.MileageEnd)
            .GreaterThanOrEqualTo(0)
            .WithMessage(BookingValidationMessage.MileageInvalid);

        RuleFor(x => x.FuelLevelEnd)
            .InclusiveBetween(0, 100)
            .WithMessage(BookingValidationMessage.FuelLevelInvalid);

        RuleFor(x => x.ReturnImages)
            .NotNull()
            .WithMessage(BookingValidationMessage.ImagesRequired)
            .Must(list => list != null && list.Count >= 4)
            .WithMessage(BookingValidationMessage.MinimumImagesRequired);

        RuleFor(x => x.VehicleDamageNotes)
            .MaximumLength(2000)
            .WithMessage(BookingValidationMessage.ConditionNotesTooLong);
    }
}

