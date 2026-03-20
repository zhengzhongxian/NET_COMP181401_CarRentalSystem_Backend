namespace NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;

public class GetRoleDto
{
    public Guid RoleId { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public string Accessibility { get; set; } = string.Empty;
    
    public DateTime? CreatedAt { get; set; }
}
