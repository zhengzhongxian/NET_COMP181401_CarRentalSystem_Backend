using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class User : BaseEntity<Guid>
{
    public string UserName { get; set; }

    public string Password { get; set; }

    public string Email { get; set; }

    public bool IsVerified { get; set; }

    public UserStatus Status { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = [];

    public virtual ICollection<UserClaim> UserClaims { get; set; } = [];

    public virtual ICollection<UserLogin> UserLogins { get; set; } = [];

    public virtual ICollection<UserToken> UserTokens { get; set; } = [];

    public virtual ICollection<UserSession> UserSessions { get; set; } = [];
}
