namespace NET_CarRentalSystem.API.Models.Response.Users;

public class GetUserListResponse
{
    public Guid UserId { get; set; }
    
    public string? UserName { get; set; }
    
    public string? Email { get; set; }
    
    public string? Status { get; set; }
    
    public bool IsVerified { get; set; }
    
    public string? RoleName { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}

