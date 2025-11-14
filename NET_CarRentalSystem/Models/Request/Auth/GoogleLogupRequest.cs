using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Auth;

public class GoogleLogupRequest : GoogleLoginRequest
{
    [Required(ErrorMessage = "Email là bắt buộc.")]
    [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
    public required string Email { get; set; }
    
    public required string GivenName { get; set; }
    
    public required string FamilyName { get; set; }
    
    [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
    [RegularExpression(@"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$", ErrorMessage = "Số điện thoại không hợp lệ.")]
    public required string PhoneNumber { get; set; }
    
    [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
    public DateTime Dob { get; set; }
    
    public string? Address { get; set; }
}