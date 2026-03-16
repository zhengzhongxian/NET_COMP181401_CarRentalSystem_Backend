using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserPhoneCommand;

public class UpdateUserPhoneCommandValidator : AbstractValidator<UpdateUserPhoneCommand>
{
    public UpdateUserPhoneCommandValidator()
    {
        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage(UserValidationMessage.Phone.Required)
            .Matches(@"^(0|\+84)[3|5|7|8|9][0-9]{8}$")
            .WithMessage(UserValidationMessage.Phone.Invalid);
    }
}

