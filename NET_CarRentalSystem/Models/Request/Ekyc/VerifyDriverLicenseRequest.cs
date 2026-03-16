using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Ekyc;

public class VerifyDriverLicenseRequest
{
    [Required(ErrorMessage = "Ảnh mặt trước GPLX là bắt buộc")]
    public IFormFile FrontImage { get; set; } = default!;

    [Required(ErrorMessage = "Ảnh mặt sau GPLX là bắt buộc")]
    public IFormFile BackImage { get; set; } = default!;
}

