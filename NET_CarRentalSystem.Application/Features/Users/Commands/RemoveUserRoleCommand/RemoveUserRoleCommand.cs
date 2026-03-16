using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.RemoveUserRoleCommand;

public class RemoveUserRoleCommand : ICommand<(bool Success, string Message)>
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}

public class RemoveUserRoleCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<RemoveUserRoleCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(RemoveUserRoleCommand request, CancellationToken cancellationToken)
    {
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var roleRepo = unitOfWork.GetWriteRepository<Role>();
        var userRoleRepo = unitOfWork.GetWriteRepository<UserRole>();

        // Check if user exists
        var user = await userRepo.GetByIdAsync(request.UserId, cancellationToken);
        if (user == null)
        {
            return (false, UserMessage.NotFound);
        }

        // Check if role exists
        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
        {
            return (false, UserMessage.Role.RoleNotFound);
        }

        // Find the user role assignment
        var existingUserRole = await userRoleRepo.GetFirstOrDefaultAsync(
            ur => ur.UserId == request.UserId && ur.RoleId == request.RoleId,
            cancellationToken);

        if (existingUserRole == null)
        {
            return (false, UserMessage.Role.DoesNotHaveRole);
        }

        // If removing Admin role, check if this is the last admin
        if (role.NormalizedName == RoleConstants.Admin.ToUpperInvariant())
        {
            var adminRoleCount = await userRoleRepo.GetListAsync(
                ur => ur.RoleId == request.RoleId,
                cancellationToken);

            if (adminRoleCount.Count <= 1)
            {
                return (false, UserMessage.Role.CannotRemoveLastAdminRole);
            }
        }

        // Remove user role (hard delete since UserRole doesn't have soft delete)
        userRoleRepo.Remove(existingUserRole, hardDelete: true);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Role.RemoveSuccess);
    }
}
