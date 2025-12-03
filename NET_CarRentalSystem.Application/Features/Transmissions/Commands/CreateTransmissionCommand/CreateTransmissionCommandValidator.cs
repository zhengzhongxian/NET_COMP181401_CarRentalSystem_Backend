using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Commands.CreateTransmissionCommand;

public class CreateTransmissionCommandValidator : AbstractValidator<CreateTransmissionCommand>
{
    public CreateTransmissionCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(TranmissionValidationMessage.NameRequired)
            .MaximumLength(100).WithMessage(TranmissionValidationMessage.NameMaxLength);

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage(TranmissionValidationMessage.CodeRequired)
            .MaximumLength(50).WithMessage(TranmissionValidationMessage.CodeMaxLength);
    }
}

