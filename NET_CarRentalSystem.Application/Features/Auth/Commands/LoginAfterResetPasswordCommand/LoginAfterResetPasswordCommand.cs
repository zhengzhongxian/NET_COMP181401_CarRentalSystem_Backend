using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LoginAfterResetPasswordCommand;

public class LoginAfterResetPasswordCommand : ICommand<(string, TokenResponse?)>
{
    public required string ResetPasswordToken { get; set; }
    public required string Password { get; set; }
    public string? IpAddress { get; set; }
    public string? DeviceName { get; set; }
}

public class LoginAfterResetPasswordCommandHandler(
    ICryptographyService cryptographyService,
    IMediator mediator) : IRequestHandler<LoginAfterResetPasswordCommand, (string, TokenResponse?)>
{
    public async Task<(string, TokenResponse?)> Handle(LoginAfterResetPasswordCommand request, CancellationToken cancellationToken)
    {
        var tokenParts = request.ResetPasswordToken.Split('.');
        var urlSafeEncryptedEmail = tokenParts[0];
        var standardBase64 = TokenHelper.FromUrlSafeBase64(urlSafeEncryptedEmail);
        var decryptedEmail = cryptographyService.DecryptAes(standardBase64);
        
        
        var loginApiRequest = new LoginCommand.LoginCommand()
        {
            UsernameOrEmail = decryptedEmail,
            Password = request.Password,
            IpAddress = request.IpAddress,
            DeviceName = request.DeviceName
        };

        return await mediator.Send(loginApiRequest, cancellationToken);
    }
}