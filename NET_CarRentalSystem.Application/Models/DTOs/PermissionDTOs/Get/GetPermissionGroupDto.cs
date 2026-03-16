namespace NET_CarRentalSystem.Application.Models.DTOs.PermissionDTOs.Get;

public class GetPermissionGroupDto
{
    public string GroupName { get; set; } = string.Empty;
    
    public List<GetPermissionDto> Permissions { get; set; } = [];
}

public class GetPermissionDto
{
    public string Name { get; set; } = string.Empty;
    
    public string Value { get; set; } = string.Empty;
}

