namespace NET_CarRentalSystem.API.Models.Request.Roles;

public class UpdateRoleClaimRequest
{
    public string ClaimType { get; set; } = "Permission";
    
    public string ClaimValue { get; set; } = string.Empty;
}

