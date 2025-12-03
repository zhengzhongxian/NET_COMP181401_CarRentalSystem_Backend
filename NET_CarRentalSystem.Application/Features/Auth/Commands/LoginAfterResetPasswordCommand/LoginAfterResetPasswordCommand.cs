using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;

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
        var decryptedEmail = cryptographyService.DecryptAes(tokenParts[0]);
        
        
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