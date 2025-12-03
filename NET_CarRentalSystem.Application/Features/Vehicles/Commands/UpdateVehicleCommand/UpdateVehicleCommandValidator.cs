using FluentValidation;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleCommand;

public class UpdateVehicleCommandValidator : AbstractValidator<UpdateVehicleCommand>
{
    public UpdateVehicleCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

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
        
        RuleFor(x => x.Status)
            .IsEnumName(typeof(VehicleStatus), caseSensitive: false)
            .WithMessage(VehicleValidationMessage.StatusInvalid);
    }
}