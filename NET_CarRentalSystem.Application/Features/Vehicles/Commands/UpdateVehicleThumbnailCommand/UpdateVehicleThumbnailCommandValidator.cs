using FluentValidation;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;

public class UpdateVehicleThumbnailCommandValidator : AbstractValidator<UpdateVehicleThumbnailCommand>
{
    public UpdateVehicleThumbnailCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Thumbnail)
            .Must(ValidateFile)
            .WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }

    private static bool ValidateFile(FileModel file)
    {
        return file.Content.Length > 0 && !string.IsNullOrEmpty(file.FileName);
    }
}