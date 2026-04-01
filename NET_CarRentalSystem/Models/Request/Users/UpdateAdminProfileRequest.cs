using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Users;

public class UpdateAdminProfileRequest
{
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [Phone]
    [MaxLength(15)]
    public string PhoneNumber { get; set; } = string.Empty;
}
