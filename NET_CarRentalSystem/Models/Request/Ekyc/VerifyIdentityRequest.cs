using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace NET_CarRentalSystem.API.Models.Request.Ekyc;

public class VerifyIdentityRequest
{
    [Required]
    public IFormFile FrontImage { get; set; } = default!;

    [Required]
    public IFormFile BackImage { get; set; } = default!;

    [Required]
    public IFormFile SelfieImage { get; set; } = default!;
}
