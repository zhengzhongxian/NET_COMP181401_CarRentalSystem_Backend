using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.LogupCommand;

public class LogupCommandParams
{
    public required string UserName { get; set; }

    public required string Password { get; set; }

    public required string Otp { get; set; }

    [EmailAddress]
    public required string Email { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public DateTime Dob { get; set; }

    [RegularExpression(@"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$", ErrorMessage = "Invalid phone number format.")]
    public required string PhoneNumber { get; set; }

    public string? Address { get; set; }
}
