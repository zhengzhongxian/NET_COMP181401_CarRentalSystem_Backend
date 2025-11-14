namespace NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtpCommand;

public class SendOtpParams
{
    public required string UserName {get;set;}
    
    public required string Email {get;set;}
    
    public required string Name {get;set;}
}