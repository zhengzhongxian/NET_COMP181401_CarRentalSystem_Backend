namespace NET_CarRentalSystem.API.Models.Response.Permissions;

public class GetPermissionGroupResponse
{
    public string GroupName { get; set; } = string.Empty;
    
    public List<GetPermissionResponse> Permissions { get; set; } = [];
}

public class GetPermissionResponse
{
    public string Name { get; set; } = string.Empty;
    
    public string Value { get; set; } = string.Empty;
}

