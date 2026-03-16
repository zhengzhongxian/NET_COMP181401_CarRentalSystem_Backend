using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.AddUserRoleCommand;

public class AddUserRoleCommand : ICommand<(bool Success, string Message)>
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}

public class AddUserRoleCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<AddUserRoleCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(AddUserRoleCommand request, CancellationToken cancellationToken)
    {
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var roleRepo = unitOfWork.GetWriteRepository<Role>();
        var userRoleRepo = unitOfWork.GetWriteRepository<UserRole>();
        
        var user = await userRepo.GetByIdAsync(request.UserId, cancellationToken);
        if (user == null)
        {
            return (false, UserMessage.NotFound);
        }
        
        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
        {
            return (false, UserMessage.Role.RoleNotFound);
        }
        
        var existingUserRole = await userRoleRepo.GetFirstOrDefaultAsync(
            ur => ur.UserId == request.UserId && ur.RoleId == request.RoleId,
            cancellationToken);

        if (existingUserRole != null)
        {
            return (false, UserMessage.Role.AlreadyHasRole);
        }
        
        var newUserRole = new UserRole
        {
            UserId = request.UserId,
            RoleId = request.RoleId
        };

        await userRoleRepo.AddAsync(newUserRole, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Role.AddSuccess);
    }
}
