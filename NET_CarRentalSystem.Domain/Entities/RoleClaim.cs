using System.Data;

namespace NET_CarRentalSystem.Domain.Entities;

public class RoleClaim
{
    public Guid Id { get; set; }

    public Guid RoleId { get; set; }

    public string ClaimType { get; set; }

    public string ClaimValue { get; set; }

    public virtual Role Role { get; set; }
}