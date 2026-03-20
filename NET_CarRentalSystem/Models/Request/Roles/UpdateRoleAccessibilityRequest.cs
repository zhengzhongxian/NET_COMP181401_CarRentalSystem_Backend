using System.ComponentModel.DataAnnotations;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Request.Roles;

public class UpdateRoleAccessibilityRequest
{
    [Required]
    [EnumDataType(typeof(RoleAccessibility))]
    public RoleAccessibility Accessibility { get; set; }
}
