namespace NET_CarRentalSystem.Application.Models.DTOs.UserDTOs.Get;

public class GetUserListDto
{
    public Guid UserId { get; set; }
    
    public string? UserName { get; set; }
    
    public string? Email { get; set; }
    
    public string? Status { get; set; }
    
    public bool IsVerified { get; set; }
    
    public string? RoleName { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}

