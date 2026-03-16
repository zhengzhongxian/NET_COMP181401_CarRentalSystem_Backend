using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Roles.Commands.CreateRoleCommand;

public class CreateRoleCommand : ICommand<(bool Success, Guid? RoleId, string Message)>
{
    public string Name { get; set; } = string.Empty;
    
    public string? Description { get; set; }
}

public class CreateRoleCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<CreateRoleCommand, (bool Success, Guid? RoleId, string Message)>
{
    public async Task<(bool Success, Guid? RoleId, string Message)> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var roleRepo = unitOfWork.GetWriteRepository<Role>();

        var existingRole = await roleRepo.GetFirstOrDefaultAsync(
            r => r.NormalizedName == request.Name.ToUpperInvariant(),
            cancellationToken);

        if (existingRole != null)
        {
            return (false, null, RoleMessage.Create.AlreadyExists);
        }

        var role = new Role
        {
            Name = request.Name,
            NormalizedName = request.Name.ToUpperInvariant(),
            Description = request.Description,
            ConcurrencyStamp = Guid.NewGuid().ToString()
        };

        await roleRepo.AddAsync(role, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, role.Id, RoleMessage.Create.Success);
    }
}

