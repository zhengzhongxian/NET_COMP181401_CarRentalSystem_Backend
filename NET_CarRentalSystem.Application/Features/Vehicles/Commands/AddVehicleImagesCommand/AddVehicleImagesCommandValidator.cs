using FluentValidation;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleImagesCommand;

public class AddVehicleImagesCommandValidator : AbstractValidator<AddVehicleImagesCommand>
{
    public AddVehicleImagesCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.Images)
            .NotNull().WithMessage(VehicleValidationMessage.AddImages.ImagesRequired)
            .Must(images => images.Count > 0).WithMessage(VehicleValidationMessage.AddImages.ImagesMinCount);

        RuleForEach(x => x.Images)
            .Must(ValidateFile).WithMessage(VehicleValidationMessage.Create.ThumbnailInvalid);
    }

    private static bool ValidateFile(FileModel file)
    {
        return file.Content.Length > 0 && !string.IsNullOrEmpty(file.FileName);
    }
}