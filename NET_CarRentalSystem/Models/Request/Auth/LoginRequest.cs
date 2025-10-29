using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LoginRequest
{
    [Required(ErrorMessage = "Tên đăng nhập hoặc Email là bắt buộc.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Tên đăng nhập phải từ 5 đến 50 ký tự.")]
    [RegularExpression(@"^[a-zA-Z0-9_.]+$", 
        ErrorMessage = "Tên đăng nhập chỉ được chứa chữ cái, số, dấu gạch dưới và dấu chấm.")]
    public required string UsernameOrEmail { get; set; }
    
    [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có từ 8 đến 100 ký tự.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$",
        ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, và 1 ký tự đặc biệt.")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}