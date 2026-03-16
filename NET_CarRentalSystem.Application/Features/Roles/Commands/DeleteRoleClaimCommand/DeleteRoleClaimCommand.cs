using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.DeleteRoleClaimCommand;

public class DeleteRoleClaimCommand : ICommand<(bool Success, string Message)>
{
    public Guid RoleId { get; set; }
    public string ClaimValue { get; set; } = string.Empty;
}

public class DeleteRoleClaimCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<DeleteRoleClaimCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(DeleteRoleClaimCommand request, CancellationToken cancellationToken)
    {
        // Validate claimValue exists in PermissionConstants
        var allPermissions = PermissionConstants.GetAllPermissions();
        if (!allPermissions.Contains(request.ClaimValue))
        {
            return (false, RoleMessage.Claim.NotFound);
        }

        var roleClaimRepo = unitOfWork.GetWriteRepository<RoleClaim>();

        // Find ALL claims matching RoleId + ClaimValue (handles duplicates)
        var roleClaims = await roleClaimRepo.GetListAsync(
            rc => rc.RoleId == request.RoleId && rc.ClaimValue == request.ClaimValue,
            cancellationToken);

        if (roleClaims.Count == 0)
        {
            return (false, RoleMessage.Claim.NotFound);
        }

        roleClaimRepo.RemoveRange(roleClaims, hardDelete: true);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RoleMessage.Claim.DeleteSuccess);
    }
}


