using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.UpdateRoleCommand;

public class UpdateRoleCommand : ICommand<(bool Success, string Message)>
{
    public Guid RoleId { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string? Description { get; set; }
}

public class UpdateRoleCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<UpdateRoleCommand, (bool Success, string Message)>
{
    public async Task<(bool Success, string Message)> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var roleRepo = unitOfWork.GetWriteRepository<Role>();

        var role = await roleRepo.GetByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
        {
            return (false, RoleMessage.Update.NotFound);
        }

        // Check if name is already used by another role
        var existingRole = await roleRepo.GetFirstOrDefaultAsync(
            r => r.NormalizedName == request.Name.ToUpperInvariant() && r.Id != request.RoleId,
            cancellationToken);

        if (existingRole != null)
        {
            return (false, RoleMessage.Update.AlreadyExists);
        }

        role.Name = request.Name;
        role.NormalizedName = request.Name.ToUpperInvariant();
        role.Description = request.Description;
        role.ConcurrencyStamp = Guid.NewGuid().ToString();

        roleRepo.Update(role);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, RoleMessage.Update.Success);
    }
}

