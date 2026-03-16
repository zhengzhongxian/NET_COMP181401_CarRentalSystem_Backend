namespace NET_CarRentalSystem.API.Models.Request.Roles;

public class CreateRoleClaimRequest
{
    public Guid RoleId { get; set; }
    
    public string ClaimType { get; set; } = "Permission";
    
    public string ClaimValue { get; set; } = string.Empty;
}

