using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LoginRequest
{
    [Required(ErrorMessage = "Tên đăng nhập hoặc Email là bắt buộc.")]
    public required string UsernameOrEmail { get; set; }
    
    [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}