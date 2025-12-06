using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleAttributeCommand;

public class UpdateVehicleAttributeCommandValidator : AbstractValidator<UpdateVehicleAttributeCommand>
{
    public UpdateVehicleAttributeCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.AttributeId)
            .NotEmpty().WithMessage("AttributeId không được rỗng");

        RuleFor(x => x.Key)
            .NotEmpty().WithMessage(VehicleValidationMessage.AddAttributes.AttributeKeyRequired);

        RuleFor(x => x.Value)
            .NotEmpty().WithMessage(VehicleValidationMessage.AddAttributes.AttributeValueRequired);
    }
}