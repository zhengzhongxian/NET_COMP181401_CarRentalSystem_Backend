using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleModelsCommand;

public class DeleteVehicleModelsCommandValidator : AbstractValidator<DeleteVehicleModelsCommand>
{
    public DeleteVehicleModelsCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.VehicleModelId)
            .NotEmpty().WithMessage(VehicleValidationMessage.AddVehicleModels.VehicleModelsRequired);
    }
}

