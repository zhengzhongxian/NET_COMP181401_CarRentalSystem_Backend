using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.UpdateRoleClaimCommand;

public class UpdateRoleClaimCommand : ICommand<(bool Success, string Message)>
{
    public Guid ClaimId { get; set; }
    
    public string ClaimType { get; set; } = "Permission";
    
    public string ClaimValue { get; set; } = string.Empty;
}

public class UpdateRoleClaimCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<UpdateRoleClaimCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(UpdateRoleClaimCommand request, CancellationToken cancellationToken)
    {
        // Check if ClaimValue exists in PermissionConstants
        var allPermissions = PermissionConstants.GetAllPermissions();
        if (!allPermissions.Contains(request.ClaimValue))
        {
            return (false, RoleMessage.Claim.InvalidPermission);
        }

        var roleClaimRepo = unitOfWork.GetWriteRepository<RoleClaim>();

        var roleClaim = await roleClaimRepo.GetByIdAsync(request.ClaimId, cancellationToken);
        if (roleClaim == null)
        {
            return (false, RoleMessage.Claim.NotFound);
        }

        // Check if claim value already exists for this role (different claim)
        var existingClaim = await roleClaimRepo.GetFirstOrDefaultAsync(
            rc => rc.RoleId == roleClaim.RoleId && rc.ClaimValue == request.ClaimValue && rc.Id != request.ClaimId,
            cancellationToken);

        if (existingClaim != null)
        {
            return (false, RoleMessage.Claim.AlreadyExists);
        }

        roleClaim.ClaimType = request.ClaimType;
        roleClaim.ClaimValue = request.ClaimValue;

        roleClaimRepo.Update(roleClaim);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RoleMessage.Claim.UpdateSuccess);
    }
}

