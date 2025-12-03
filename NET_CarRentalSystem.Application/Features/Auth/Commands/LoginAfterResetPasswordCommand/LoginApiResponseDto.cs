namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LoginAfterResetPasswordCommand;

public class LoginApiResponseDto
{
    public string AccessToken { get; set; } = default!;

    public string RefreshToken { get; set; } = default!;
    
    public DateTime AccessTokenExpiry { get; set; }
    
    public DateTime RefreshTokenExpiry { get; set; }
}