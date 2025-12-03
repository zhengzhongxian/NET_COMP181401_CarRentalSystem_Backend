using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Commands.UpdateTransmissionCommand;

public class UpdateTransmissionCommandValidator : AbstractValidator<UpdateTransmissionCommand>
{
    public UpdateTransmissionCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(TranmissionValidationMessage.IdRequired);

        RuleFor(x => x.Name)
            .MaximumLength(100).WithMessage(TranmissionValidationMessage.NameMaxLength);

        RuleFor(x => x.Code)
            .MaximumLength(50).WithMessage(TranmissionValidationMessage.CodeMaxLength);
    }
}

