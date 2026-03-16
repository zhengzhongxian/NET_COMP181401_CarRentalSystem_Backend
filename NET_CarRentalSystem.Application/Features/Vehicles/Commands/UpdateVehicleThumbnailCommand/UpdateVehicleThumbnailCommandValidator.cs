using FluentValidation;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;

public class UpdateVehicleThumbnailCommandValidator : AbstractValidator<UpdateVehicleThumbnailCommand>
{
    public UpdateVehicleThumbnailCommandValidator(IOptions<FileValidationSettings> fileSettings)
    {
        var validateFile = new ValidateFile(fileSettings);
        
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Thumbnail)
            .Must(validateFile.IsValid)
            .WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }
}