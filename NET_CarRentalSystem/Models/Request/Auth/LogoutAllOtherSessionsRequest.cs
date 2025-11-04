using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LogoutAllOtherSessionsRequest
{
    [Required]
    public required string CurrentRefreshToken { get; set; }
}

