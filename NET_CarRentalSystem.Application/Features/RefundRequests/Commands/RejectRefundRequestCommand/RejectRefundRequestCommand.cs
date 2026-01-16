using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.RefundRequests.Commands.RejectRefundRequestCommand;

public class RejectRefundRequestCommand : ICommand<(bool, string)>
{
    public required Guid RefundRequestId { get; set; }
    
    public required string AdminNotes { get; set; }
}

public class RejectRefundRequestCommandHandler(
    IUnitOfWork unitOfWork,
    ICurrentUserService currentUserService) : IRequestHandler<RejectRefundRequestCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(RejectRefundRequestCommand request, CancellationToken cancellationToken)
    {
        var refundRequest = await unitOfWork.GetWriteRepository<RefundRequest>()
            .GetByIdAsync(request.RefundRequestId, cancellationToken);

        if (refundRequest == null)
            return (false, RefundRequestMessage.Reject.NotFound);


        var adminId = currentUserService.GetUserId();
        
        refundRequest.Status = RefundStatus.Rejected;
        refundRequest.AdminNotes = request.AdminNotes;
        refundRequest.ApprovedBy = adminId;
        refundRequest.ApprovedAt = DateTime.UtcNow;

        unitOfWork.GetWriteRepository<RefundRequest>().Update(refundRequest);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RefundRequestMessage.Reject.Success);
    }
}

