namespace NET_CarRentalSystem.API.Models.Response.Roles;

public class GetRoleClaimResponse
{
    public Guid Id { get; set; }
    
    public Guid RoleId { get; set; }
    
    public string? RoleName { get; set; }
    
    public string? ClaimType { get; set; }
    
    public string? ClaimValue { get; set; }
}

