using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.DeleteRoleCommand;

public class DeleteRoleCommand : ICommand<(bool Success, string Message)>
{
    public Guid RoleId { get; set; }
}

public class DeleteRoleCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<DeleteRoleCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        var roleRepo = unitOfWork.GetWriteRepository<Role>();
        var userRoleRepo = unitOfWork.GetWriteRepository<UserRole>();
        var roleClaimRepo = unitOfWork.GetWriteRepository<RoleClaim>();

        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
        {
            return (false, RoleMessage.Delete.NotFound);
        }
        
        var hasUsers = await userRoleRepo.ExistsAsync(
            ur => ur.RoleId == request.RoleId,
            cancellationToken);

        if (hasUsers)
        {
            return (false, RoleMessage.Delete.HasUsers);
        }
        
        var hasClaims = await roleClaimRepo.ExistsAsync(
            rc => rc.RoleId == request.RoleId,
            cancellationToken);

        if (hasClaims)
        {
            return (false, RoleMessage.Delete.HasClaims);
        }

        roleRepo.Remove(role);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RoleMessage.Delete.Success);
    }
}

