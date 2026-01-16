using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class User : BaseEntity<Guid>, IRowVersion
{
    public string UserName { get; set; } = default!;

    public string Password { get; set; } = default!;

    public string Email { get; set; } = default!;

    public bool IsVerified { get; set; }

    public UserStatus Status { get; set; }

    public byte[] RowVersion { get; set; } = [];

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = [];

    public virtual ICollection<UserClaim> UserClaims { get; set; } = [];

    public virtual ICollection<UserLogin> UserLogins { get; set; } = [];

    public virtual ICollection<UserToken> UserTokens { get; set; } = [];

    public virtual ICollection<UserSession> UserSessions { get; set; } = [];
}
