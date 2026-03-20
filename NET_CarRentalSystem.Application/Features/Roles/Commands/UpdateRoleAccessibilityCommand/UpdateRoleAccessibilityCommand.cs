using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.UpdateRoleAccessibilityCommand;

public class UpdateRoleAccessibilityCommand : ICommand<(bool Success, string Message)>
{
    public Guid RoleId { get; set; }
    public RoleAccessibility Accessibility { get; set; }
}

public class UpdateRoleAccessibilityCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<UpdateRoleAccessibilityCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(UpdateRoleAccessibilityCommand request, CancellationToken cancellationToken)
    {
        var roleRepo = unitOfWork.GetWriteRepository<Role>();

        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);

        if (role == null)
        {
            return (false, RoleMessage.Update.NotFound);
        }

        role.Accessibility = request.Accessibility;

        roleRepo.Update(role);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RoleMessage.Update.Success);
    }
}
