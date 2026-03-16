namespace NET_CarRentalSystem.Application.Models.DTOs.RoleDTOs.Get;

public class GetRoleClaimDto
{
    public Guid Id { get; set; }
    
    public Guid RoleId { get; set; }
    
    public string? RoleName { get; set; }
    
    public string? ClaimType { get; set; }
    
    public string? ClaimValue { get; set; }
}

