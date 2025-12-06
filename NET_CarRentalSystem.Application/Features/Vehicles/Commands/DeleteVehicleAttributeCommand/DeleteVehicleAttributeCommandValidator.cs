using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleAttributeCommand;

public class DeleteVehicleAttributeCommandValidator : AbstractValidator<DeleteVehicleAttributeCommand>
{
    public DeleteVehicleAttributeCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.AttributeId)
            .NotEmpty().WithMessage("AttributeId không được rỗng");
    }
}