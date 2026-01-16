using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.RefundRequests.Commands.RejectRefundRequestCommand;

public class RejectRefundRequestCommandValidator : AbstractValidator<RejectRefundRequestCommand>
{
    public RejectRefundRequestCommandValidator()
    {
        RuleFor(x => x.RefundRequestId)
            .NotEmpty()
            .WithMessage(RefundRequestValidationMessage.RefundRequestIdRequired);

        RuleFor(x => x.AdminNotes)
            .NotEmpty()
            .WithMessage(RefundRequestValidationMessage.AdminNotesRequired)
            .MaximumLength(500)
            .WithMessage(RefundRequestValidationMessage.AdminNotesMaxLength);
    }
}