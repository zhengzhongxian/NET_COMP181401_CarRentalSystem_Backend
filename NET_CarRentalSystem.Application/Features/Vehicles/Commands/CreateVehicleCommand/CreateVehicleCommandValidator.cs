using FluentValidation;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;

public class CreateVehicleCommandValidator : AbstractValidator<CreateVehicleCommand>
{
    public CreateVehicleCommandValidator(IOptions<FileValidationSettings> fileSettings)
    {
        var validateFile = new ValidateFile(fileSettings);
        
        RuleFor(x => x.Manufacturer)
            .NotEmpty().WithMessage(VehicleValidationMessage.ManufacturerRequired)
            .MaximumLength(50).WithMessage(VehicleValidationMessage.ManufacturerMaxLength);

        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(VehicleValidationMessage.ModelRequired)
            .MaximumLength(50).WithMessage(VehicleValidationMessage.ModelMaxLength);

        RuleFor(x => x.PricePerHour)
            .GreaterThan(0).WithMessage(VehicleValidationMessage.PriceGreaterThanZero);

        RuleFor(x => x.Thumbnail)
            .Must(validateFile.IsValid).When(x => x.Thumbnail != null)
            .WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }
}