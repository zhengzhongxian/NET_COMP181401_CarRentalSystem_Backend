using FluentValidation;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;

public class CreateVehicleCommandValidator : AbstractValidator<CreateVehicleCommand>
{
    public CreateVehicleCommandValidator()
    {
        RuleFor(x => x.NumberPlate)
            .NotEmpty().WithMessage(VehicleValidationMessage.NumberPlateRequired)
            .MaximumLength(20).WithMessage(VehicleValidationMessage.NumberPlateMaxLength);

        RuleFor(x => x.Manufacturer)
            .NotEmpty().WithMessage(VehicleValidationMessage.ManufacturerRequired)
            .MaximumLength(50).WithMessage(VehicleValidationMessage.ManufacturerMaxLength);

        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(VehicleValidationMessage.ModelRequired)
            .MaximumLength(50).WithMessage(VehicleValidationMessage.ModelMaxLength);

        RuleFor(x => x.Mileage)
            .GreaterThanOrEqualTo(0).WithMessage(VehicleValidationMessage.MileageNegative);

        RuleFor(x => x.PricePerHour)
            .GreaterThan(0).WithMessage(VehicleValidationMessage.PriceGreaterThanZero);

        RuleFor(x => x.Rating)
            .InclusiveBetween(0, 5).WithMessage(VehicleValidationMessage.RatingRange);

        RuleFor(x => x.Thumbnail)
            .Must(ValidateFile).When(x => x.Thumbnail != null)
            .WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }

    private static bool ValidateFile(FileModel? file)
    {
        if (file == null) return true;
        return file.Content.Length > 0 && !string.IsNullOrEmpty(file.FileName);
    }
}