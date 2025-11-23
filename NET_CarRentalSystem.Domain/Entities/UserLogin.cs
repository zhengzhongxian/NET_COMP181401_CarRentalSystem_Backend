using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class UserLogin
{
    public Guid UserLoginId { get; set; }

    public LoginProvider LoginProvider { get; set; }

    public string ProviderKey { get; set; } = default!;

    public string ProviderDisplayName { get; set; } = default!;

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = default!;
}
