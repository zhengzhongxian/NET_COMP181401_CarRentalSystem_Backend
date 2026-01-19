using System.Net.Mail;
using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.SendVehiclePromotionEmailCommand;

public class SendVehiclePromotionEmailCommandValidator : AbstractValidator<SendVehiclePromotionEmailCommand>
{
    public SendVehiclePromotionEmailCommandValidator()
    {
        RuleFor(x => x.VehicleId)
            .NotEmpty()
            .WithMessage(VehicleEmailValidationMessage.SendPromotion.VehicleIdRequired);

        RuleFor(x => x.Emails)
            .NotEmpty()
            .WithMessage(VehicleEmailValidationMessage.SendPromotion.EmailsRequired)
            .Must(emails => emails.All(IsValidEmail))
            .WithMessage(VehicleEmailValidationMessage.SendPromotion.InvalidEmails);

        RuleFor(x => x.CustomMessage)
            .MaximumLength(500)
            .WithMessage(VehicleEmailValidationMessage.SendPromotion.CustomMessageTooLong);
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
