using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.RefundRequests.Commands.ApproveRefundRequestCommand;

public class ApproveRefundRequestCommand : ICommand<(bool, string)>
{
    public required Guid RefundRequestId { get; set; }
    
    public string? AdminNotes { get; set; }
}

public class ApproveRefundRequestCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService) : IRequestHandler<ApproveRefundRequestCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(ApproveRefundRequestCommand request, CancellationToken cancellationToken)
    {
        var refundRequest = await unitOfWork.GetWriteRepository<RefundRequest>()
            .GetByIdAsync(request.RefundRequestId, cancellationToken);

        if (refundRequest == null)
            return (false, RefundRequestMessage.Approve.NotFound);
        
        var adminId = currentUserService.GetUserId();
        
        refundRequest.Status = RefundStatus.Approved;
        refundRequest.AdminNotes = request.AdminNotes;
        refundRequest.ApprovedBy = adminId;
        refundRequest.ApprovedAt = DateTime.UtcNow;

        unitOfWork.GetWriteRepository<RefundRequest>().Update(refundRequest);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RefundRequestMessage.Approve.Success);
    }
}

