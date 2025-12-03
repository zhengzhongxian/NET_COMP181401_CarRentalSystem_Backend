using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleAttributesCommand;

public class AddVehicleAttributesCommandValidator : AbstractValidator<AddVehicleAttributesCommand>
{
    public AddVehicleAttributesCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Attributes)
            .NotNull().WithMessage(VehicleValidationMessage.AddAttributes.AttributesRequired)
            .Must(attributes => attributes.Count > 0).WithMessage(VehicleValidationMessage.AddAttributes.AttributesMinCount);

        RuleForEach(x => x.Attributes).ChildRules(attribute =>
        {
            attribute.RuleFor(x => x.Key).NotEmpty().WithMessage(VehicleValidationMessage.AddAttributes.AttributeKeyRequired);
            attribute.RuleFor(x => x.Value).NotEmpty().WithMessage(VehicleValidationMessage.AddAttributes.AttributeValueRequired);
        });
    }
}
