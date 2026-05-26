namespace NET_CarRentalSystem.Application.Features.Impersonation;

public class ImpersonationSessionData
{
    public Guid AdminUserId { get; set; }
    public string DeveloperCode { get; set; } = string.Empty;
    public Guid DeveloperUserId { get; set; }
    public string DeveloperUserName { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
}
