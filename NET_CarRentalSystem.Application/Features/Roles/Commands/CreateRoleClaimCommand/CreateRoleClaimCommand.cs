using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.CreateRoleClaimCommand;

public class CreateRoleClaimCommand : ICommand<(bool Success, Guid? ClaimId, string Message)>
{
    public Guid RoleId { get; set; }
    
    public string ClaimType { get; set; } = "Permission";
    
    public string ClaimValue { get; set; } = string.Empty;
}

public class CreateRoleClaimCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<CreateRoleClaimCommand, (bool Success, Guid? ClaimId, string Message)>
{
    public async Task<(bool Success, Guid? ClaimId, string Message)> Handle(CreateRoleClaimCommand request, CancellationToken cancellationToken)
    {
        // Check if ClaimValue exists in PermissionConstants
        var allPermissions = PermissionConstants.GetAllPermissions();
        if (!allPermissions.Contains(request.ClaimValue))
        {
            return (false, null, RoleMessage.Claim.InvalidPermission);
        }

        var roleRepo = unitOfWork.GetWriteRepository<Role>();
        var roleClaimRepo = unitOfWork.GetWriteRepository<RoleClaim>();

        // Check if role exists
        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
        {
            return (false, null, RoleMessage.Update.NotFound);
        }

        // Check if claim already exists for this role
        var existingClaim = await roleClaimRepo.GetFirstOrDefaultAsync(
            rc => rc.RoleId == request.RoleId && rc.ClaimValue == request.ClaimValue,
            cancellationToken);

        if (existingClaim != null)
        {
            return (false, null, RoleMessage.Claim.AlreadyExists);
        }

        var roleClaim = new RoleClaim
        {
            Id = Guid.NewGuid(),
            RoleId = request.RoleId,
            ClaimType = request.ClaimType,
            ClaimValue = request.ClaimValue
        };

        await roleClaimRepo.AddAsync(roleClaim, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, roleClaim.Id, RoleMessage.Claim.CreateSuccess);
    }
}

