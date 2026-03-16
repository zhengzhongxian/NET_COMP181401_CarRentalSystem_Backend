namespace NET_CarRentalSystem.Domain.Entities;

public class UserClaim
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public string ClaimType { get; set; } = default!;

    public string ClaimValue { get; set; } = default!;

    public virtual User? User { get; set; }
}
