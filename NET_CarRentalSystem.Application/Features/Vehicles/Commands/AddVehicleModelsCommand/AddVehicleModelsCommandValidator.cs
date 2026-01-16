using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleModelsCommand;

public class AddVehicleModelsCommandValidator : AbstractValidator<AddVehicleModelsCommand>
{
    public AddVehicleModelsCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.VehicleModels)
            .NotEmpty().WithMessage(VehicleValidationMessage.AddVehicleModels.VehicleModelsRequired)
            .Must(x => x.Count > 0).WithMessage(VehicleValidationMessage.AddVehicleModels.VehicleModelsMinCount)
            .Must(x => x.All(m => !string.IsNullOrWhiteSpace(m.NumberPlate)))
            .WithMessage(VehicleValidationMessage.AddVehicleModels.AllNumberPlatesRequired);

        RuleForEach(x => x.VehicleModels).ChildRules(rule =>
        {
            rule.RuleFor(m => m.NumberPlate)
                .NotEmpty().WithMessage(VehicleValidationMessage.NumberPlateRequired)
                .MaximumLength(20).WithMessage(VehicleValidationMessage.NumberPlateMaxLength);

            rule.RuleFor(m => m.Mileage)
                .GreaterThanOrEqualTo(0).WithMessage(VehicleValidationMessage.MileageNegative);
        });
    }
}

