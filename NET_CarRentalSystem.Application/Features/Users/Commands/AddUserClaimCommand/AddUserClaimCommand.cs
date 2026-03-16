using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Users.Commands.AddUserClaimCommand;

public class AddUserClaimCommand : ICommand<(bool Success, string Message)>
{
    public Guid UserId { get; set; }

    public string ClaimValue { get; set; } = default!;
}

public class AddUserClaimCommandHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<AddUserClaimCommand, (bool Success, string Message)>
{
    private const string PermissionClaimType = "Permission";

    private static readonly HashSet<string> EkycPermissions = 
        [.. ReflectionHelper.GetConstants<string>(typeof(PermissionConstants.Ekyc))];

    public async Task<(bool Success, string Message)> Handle(AddUserClaimCommand request, CancellationToken cancellationToken)
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

        var allPermissions = PermissionConstants.GetAllPermissions();

        if (!allPermissions.Contains(request.ClaimValue))
        {
            return (false, UserMessage.Claim.InvalidPermission);
        }

        var existingClaim = await userClaimRepo.GetFirstOrDefaultAsync(
            uc => uc.UserId == request.UserId && uc.ClaimValue == request.ClaimValue,
            cancellationToken);

        if (existingClaim != null)
        {
            return (false, UserMessage.Claim.AlreadyHasClaim);
        }

        var newClaim = new UserClaim
        {
            UserId = request.UserId,
            ClaimType = PermissionClaimType,
            ClaimValue = request.ClaimValue
        };

        await userClaimRepo.AddAsync(newClaim, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (true, UserMessage.Claim.AddSuccess);
    }
}
