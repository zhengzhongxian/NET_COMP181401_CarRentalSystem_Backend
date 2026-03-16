using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.UserDTOs;

public class UserDto
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = default!;

    public string Email { get; set; } = default!;

    public string? PhoneNumber { get; set; }

    public string? FullName { get; set; }
    
    public bool IsVerified { get; set; }
    public string Status { get; set; } = default!;
    public UserStatus StatusId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    
    // Roles
    public List<string> Roles { get; set; } = [];
}
