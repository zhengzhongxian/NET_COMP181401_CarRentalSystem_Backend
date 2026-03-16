using FluentValidation;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleImagesCommand;

public class AddVehicleImagesCommandValidator : AbstractValidator<AddVehicleImagesCommand>
{
    public AddVehicleImagesCommandValidator(IOptions<FileValidationSettings> fileSettings)
    {
        var validateFile = new ValidateFile(fileSettings);
        
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Images)
            .NotNull().WithMessage(VehicleValidationMessage.AddImages.ImagesRequired)
            .Must(images => images.Count > 0).WithMessage(VehicleValidationMessage.AddImages.ImagesMinCount);

        RuleForEach(x => x.Images)
            .Must(validateFile.IsValid).WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }
}