using FluentValidation;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;

public class UpdateVehicleThumbnailCommandValidator : AbstractValidator<UpdateVehicleThumbnailCommand>
{
    public UpdateVehicleThumbnailCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Thumbnail)
            .Must(ValidateFile.IsValidate)
            .WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }
}