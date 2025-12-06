using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleImagesCommand;

public class DeleteVehicleImagesCommandValidator : AbstractValidator<DeleteVehicleImagesCommand>
{
    public DeleteVehicleImagesCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty().WithMessage(VehicleValidationMessage.Update.IdRequired);

        RuleFor(x => x.PublicIds)
            .NotNull().WithMessage("Danh sách PublicId không được null")
            .Must(publicIds => publicIds.Count > 0).WithMessage("Phải có ít nhất 1 ảnh để xóa");

        RuleForEach(x => x.PublicIds)
            .NotEmpty().WithMessage("PublicId không được rỗng");
    }
}
