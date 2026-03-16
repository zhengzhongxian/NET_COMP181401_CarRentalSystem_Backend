namespace NET_CarRentalSystem.API.Models.Response.Roles;

public class GetRoleResponse
{
    public Guid RoleId { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}

