using MediatR;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Queries;

public record GetActiveImpersonationSessionQuery : IRequest<ActiveImpersonationSessionDto?>;

public class ActiveImpersonationSessionDto
{
    public string ImpersonationToken { get; set; } = string.Empty;
    public string DeveloperCode { get; set; } = string.Empty;
    public string DeveloperUserName { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public int RemainingMinutes { get; set; }
    public DateTime ExpiresAt { get; set; }
}
