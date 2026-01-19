using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.ChangePasswordCommand;

public class ChangePasswordCommand : ICommand<(string, bool)>
{
    public required string CurrentPassword { get; set; }
    public required string NewPassword { get; set; }
}

public class ChangePasswordCommandHandler(
    IUnitOfWork unitOfWork,
    ICryptographyService cryptographyService,
    ICurrentUserService currentUserService) : IRequestHandler<ChangePasswordCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
    {
        var userId = currentUserService.GetUserId();
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var user = await userRepo.GetFirstAsync(u => u.Id == userId, cancellationToken: cancellationToken);
        
        var userLoginRepo = unitOfWork.GetReadRepository<UserLogin>();
        var hasLocalLogin = await userLoginRepo.ExistsAsync(
            ul => ul.UserId == userId && ul.LoginProvider == LoginProvider.Local,
            cancellationToken: cancellationToken);
        
        if (!hasLocalLogin)
        {
            return (AuthMessage.ChangePassword.OAuthAccountNotSupported, false);
        }
        
        var isCurrentPasswordValid = cryptographyService.VerifyPassword(request.CurrentPassword, user.Password);
        if (!isCurrentPasswordValid)
        {
            return (AuthMessage.ChangePassword.IncorrectCurrentPassword, false);
        }
        
        user.Password = cryptographyService.HashPassword(request.NewPassword);
        userRepo.Update(user);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return (AuthMessage.ChangePassword.Success, true);
    }
}
