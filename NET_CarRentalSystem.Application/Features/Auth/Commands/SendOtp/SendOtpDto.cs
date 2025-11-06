namespace NET_CarRentalSystem.Application.Features.Auth.Commands.SendOtp;

public class SendOtpDto
{
    public required string UserName {get;set;}
    
    public required string Email {get;set;}
    
    public required string Name {get;set;}
}