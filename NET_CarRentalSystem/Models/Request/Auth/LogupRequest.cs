using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class LogupRequest
{
    [Required(ErrorMessage = "Tên đăng nhập là bắt buộc.")]
    [StringLength(50, MinimumLength = 5, ErrorMessage = "Tên đăng nhập phải từ 5 đến 50 ký tự.")]
    [RegularExpression(@"^[a-zA-Z0-9_.]+$", ErrorMessage = "Tên đăng nhập chỉ được chứa chữ cái, số, dấu gạch dưới và dấu chấm.")]
    public required string UserName { get; set; }

    [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có từ 8 đến 100 ký tự.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$", ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, và 1 ký tự đặc biệt.")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [Required(ErrorMessage = "Xác nhận mật khẩu là bắt buộc.")]
    [Compare(nameof(Password), ErrorMessage = "Mật khẩu và xác nhận mật khẩu không khớp.")]
    [DataType(DataType.Password)]
    public required string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Mã OTP là bắt buộc.")]
    public required string Otp { get; set; }

    [Required(ErrorMessage = "Email là bắt buộc.")]
    [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
    public required string Email { get; set; }


    [Required(ErrorMessage = "Tên là bắt buộc.")]
    public required string FirstName { get; set; }

    [Required(ErrorMessage = "Họ là bắt buộc.")]
    public required string LastName { get; set; }

    [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
    public DateTime Dob { get; set; }

    [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
    [RegularExpression(@"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$", ErrorMessage = "Số điện thoại không hợp lệ.")]
    public required string PhoneNumber { get; set; }

    public string? Address { get; set; }
}
