using FluentValidation;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Common.Validations;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.UpdateUserAvatarCommand;

public class UpdateUserAvatarCommandValidator : AbstractValidator<UpdateUserAvatarCommand>
{
    public UpdateUserAvatarCommandValidator(IOptions<FileValidationSettings> fileSettings)
    {
        var validateFile = new ValidateFile(fileSettings);
        
        RuleFor(x => x.AvatarFile)
            .NotNull().WithMessage(UserValidationMessage.Avatar.Required)
            .Must(validateFile.IsValid)
            .WithMessage(UserValidationMessage.Avatar.Invalid);
    }
}
