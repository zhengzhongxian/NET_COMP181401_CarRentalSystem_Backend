using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class Role : BaseEntity
{
    public Guid RoleId { get; set; }

    public string Name { get; set; }

    public string NormalizedName { get; set; }

    public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

    public virtual ICollection<UserRole> UserRoles { get; set; } = [];

    public virtual ICollection<RoleClaim> RoleClaims { get; set; } = [];
}

