using System.ComponentModel.DataAnnotations;
using NET_CarRentalSystem.API.Attributes;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LoginRequest
{
    [UsernameOrEmail]
    public required string UsernameOrEmail { get; set; }
    
    [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có từ 8 đến 100 ký tự.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$",
        ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, và 1 ký tự đặc biệt.")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}