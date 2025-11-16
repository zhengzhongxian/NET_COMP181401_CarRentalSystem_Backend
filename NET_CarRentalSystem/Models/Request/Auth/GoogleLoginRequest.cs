using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class GoogleLoginRequest
{
    [Required]
    public required string IdToken { get; set; } = default!;
}