using FluentValidation;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.UpdateFinalPaymentCommand;

public class UpdateFinalPaymentValidator : AbstractValidator<UpdateFinalPaymentCommand>
{
    public UpdateFinalPaymentValidator(IOptions<FileValidationSettings> fileSettings)
    {
        var validateFile = new ValidateFile(fileSettings);
        
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

        When(x => x.Images is { Count: > 0 }, () =>
        {
            RuleFor(x => x.Images)
                .Must(images => images is { Count: >= 4 })
                .WithMessage(BookingValidationMessage.MinimumImagesRequired);

            RuleForEach(x => x.Images)
                .Must(validateFile.IsValid)
                .WithMessage(BookingValidationMessage.ImageInvalid);
        });
    }
}