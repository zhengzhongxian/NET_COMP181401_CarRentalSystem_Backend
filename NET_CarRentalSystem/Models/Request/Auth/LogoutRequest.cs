using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LogoutRequest
{
    [Required]
    public required string RefreshToken { get; set; }
}

