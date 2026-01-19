using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleModelsCommand;

public class UpdateVehicleModelsCommandValidator : AbstractValidator<UpdateVehicleModelsCommand>
{
    public UpdateVehicleModelsCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.VehicleModelId)
            .NotEmpty().WithMessage(VehicleValidationMessage.AddVehicleModels.VehicleModelsRequired);

        RuleFor(x => x.NumberPlate)
            .NotEmpty().WithMessage(VehicleValidationMessage.NumberPlateRequired)
            .MaximumLength(20).WithMessage(VehicleValidationMessage.NumberPlateMaxLength);

        RuleFor(x => x.Mileage)
            .GreaterThanOrEqualTo(0).WithMessage(VehicleValidationMessage.MileageNegative);
    }
}

