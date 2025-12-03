using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.ResetPasswordCommand;

public class ResetPasswordCommand : ICommand<(string, bool)>
{
    public required string Token { get; set; }
    public required string Password { get; set; }
}

public class ResetPasswordCommandHandler(
    IUnitOfWork unitOfWork,
    ICacheService cacheService,
    ICryptographyService cryptographyService) : IRequestHandler<ResetPasswordCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        var tokenParts = request.Token.Split('.');
        if (tokenParts.Length != 2)
        {
            return (AuthMessage.ResetPassword.InvalidToken, false);
        }
        
        var encryptedEmail = tokenParts[0];
        var decryptedEmail = cryptographyService.DecryptAes(encryptedEmail);
        
        var key = CacheKeyHelper.GetResetPasswordKey(decryptedEmail);
        var cachedResetPasswordDetailsJson = await cacheService.GetStringAsync(key, cancellationToken);
        if (cachedResetPasswordDetailsJson == null)
        {
            return (AuthMessage.ResetPassword.InvalidToken, false);
        }
        
        var cachedResetPasswordDetails = cachedResetPasswordDetailsJson.FromJson<ResetPasswordDetailsDto>()!;
        
        if (cachedResetPasswordDetails.ExpiryTime < DateTime.UtcNow)
        {
            return (AuthMessage.ResetPassword.ExpiredToken, false);
        }
        
        if (cachedResetPasswordDetails.Token != request.Token)
        {
            return (AuthMessage.ResetPassword.InvalidToken, false);
        }
        
        var userRepo = unitOfWork.GetWriteRepository<User>();
        var user = await userRepo.GetFirstAsync(u => u.Email == decryptedEmail, cancellationToken: cancellationToken);
        user.Password = cryptographyService.HashPassword(request.Password);
        userRepo.Update(user);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        await cacheService.RemoveAsync(key, cancellationToken);
        
        return (AuthMessage.ResetPassword.Success, true);
    }
}