namespace NET_CarRentalSystem.API.Models.Request.Roles;

public class UpdateRoleRequest
{
    public string Name { get; set; } = string.Empty;
    
    public string? Description { get; set; }
}

