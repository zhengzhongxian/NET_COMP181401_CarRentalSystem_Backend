using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class ChangePasswordRequest
{
    [Required(ErrorMessage = "Mật khẩu hiện tại là bắt buộc.")]
    [DataType(DataType.Password)]
    public required string CurrentPassword { get; set; }
    
    [Required(ErrorMessage = "Mật khẩu mới là bắt buộc.")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu mới phải có từ 8 đến 100 ký tự.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$", ErrorMessage = "Mật khẩu mới phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số, và 1 ký tự đặc biệt.")]
    [DataType(DataType.Password)]
    public required string NewPassword { get; set; }
    
    [Required(ErrorMessage = "Xác nhận mật khẩu mới là bắt buộc.")]
    [Compare(nameof(NewPassword), ErrorMessage = "Mật khẩu mới và xác nhận mật khẩu không khớp.")]
    [DataType(DataType.Password)]
    public required string ConfirmNewPassword { get; set; }
}
