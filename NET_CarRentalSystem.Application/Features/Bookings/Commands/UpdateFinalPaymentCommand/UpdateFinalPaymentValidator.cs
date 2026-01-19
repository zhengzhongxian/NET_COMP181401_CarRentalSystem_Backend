using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateFinalPaymentCommand;

public class UpdateFinalPaymentValidator : AbstractValidator<UpdateFinalPaymentCommand>
{
    public UpdateFinalPaymentValidator()
    {
        RuleFor(x => x.BookingId)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.BookingIdRequired);

        RuleFor(x => x.MileageStart)
            .GreaterThanOrEqualTo(0)
            .WithMessage(BookingValidationMessage.MileageInvalid);
        
        RuleFor(x => x.FuelPrice)
            .GreaterThan(0)
            .WithMessage(BookingValidationMessage.FuelPriceInvalid);

        RuleFor(x => x.ConditionNotes)
            .NotEmpty()
            .WithMessage(BookingValidationMessage.ConditionNotesRequired)
            .MaximumLength(2000)
            .WithMessage(BookingValidationMessage.ConditionNotesTooLong);

        RuleFor(x => x.Images)
            .NotNull()
            .WithMessage(BookingValidationMessage.ImagesRequired)
            .Must(images => images is { Count: >= 4 })
            .WithMessage(BookingValidationMessage.MinimumImagesRequired);
    }
}