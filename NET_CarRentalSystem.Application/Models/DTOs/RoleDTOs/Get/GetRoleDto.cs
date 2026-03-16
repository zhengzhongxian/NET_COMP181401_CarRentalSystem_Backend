namespace NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;

public class GetRoleDto
{
    public Guid RoleId { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}

