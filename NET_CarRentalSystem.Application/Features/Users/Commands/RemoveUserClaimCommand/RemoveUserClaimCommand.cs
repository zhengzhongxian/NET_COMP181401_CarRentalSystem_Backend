using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.RemoveUserClaimCommand;

public class RemoveUserClaimCommand : ICommand<(bool Success, string Message)>
{
    public Guid UserId { get; set; }

    public string ClaimValue { get; set; } = default!;
}

public class RemoveUserClaimCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<RemoveUserClaimCommand, (bool Success, string Message)>
{
    private static readonly HashSet<string> EkycPermissions = 
        [.. ReflectionHelper.GetConstants<string>(typeof(PermissionConstants.Ekyc))];

    public async Task<(bool Success, string Message)> Handle(RemoveUserClaimCommand request, CancellationToken cancellationToken)
    {
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var userClaimRepo = unitOfWork.GetWriteRepository<UserClaim>();

        var user = await userRepo.GetByIdAsync(request.UserId, cancellationToken);
        if (user == null)
        {
            return (false, UserMessage.NotFound);
        }

        if (EkycPermissions.Contains(request.ClaimValue))
        {
            return (false, UserMessage.Claim.EkycPermissionNotAllowed);
        }

        var existingClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == request.UserId && uc.ClaimValue == request.ClaimValue,
            cancellationToken);

        if (existingClaim == null)
        {
            return (false, UserMessage.Claim.DoesNotHaveClaim);
        }

        userClaimRepo.Remove(existingClaim, hardDelete: true);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Claim.RemoveSuccess);
    }
}
