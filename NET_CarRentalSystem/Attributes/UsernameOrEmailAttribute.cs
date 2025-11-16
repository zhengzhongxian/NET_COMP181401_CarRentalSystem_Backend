using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace NET_CarRentalSystem.API.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
public partial class UsernameOrEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is not string input || string.IsNullOrWhiteSpace(input))
        {
            return new ValidationResult("Tên đăng nhập hoặc Email là bắt buộc.");
        }
        
        if (new EmailAddressAttribute().IsValid(input))
        {
            return ValidationResult.Success;
        }
        
        if (input.Length is < 5 or > 50)
        {
            return new ValidationResult("Tên đăng nhập phải từ 5 đến 50 ký tự.");
        }

        return !MyRegex().IsMatch(input) ? new ValidationResult("Tên đăng nhập chỉ được chứa chữ cái, số, dấu gạch dưới và dấu chấm.") : ValidationResult.Success;
    }

    [GeneratedRegex(@"^[a-zA-Z0-9_.]+$")]
    private static partial Regex MyRegex();
}
