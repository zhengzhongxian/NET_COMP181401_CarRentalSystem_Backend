using FluentValidation;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

namespace NET_CarRentalSystem.Application.Features.RefundRequests.Commands.ApproveRefundRequestCommand;

public class ApproveRefundRequestCommandValidator : AbstractValidator<ApproveRefundRequestCommand>
{
    public ApproveRefundRequestCommandValidator()
    {
        RuleFor(x => x.RefundRequestId)
            .NotEmpty()
            .WithMessage(RefundRequestValidationMessage.RefundRequestIdRequired);
    }
}

