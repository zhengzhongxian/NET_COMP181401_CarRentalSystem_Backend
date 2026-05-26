using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.ActivateSession;

public class ActivateImpersonationCommand : ICommand<(string Message, ActivateImpersonationResult? Result)>
{
    public string ImpersonationToken { get; set; } = string.Empty;
}

public class ActivateImpersonationResult
{
    public string AccessToken { get; set; } = string.Empty;
    public DateTime AccessTokenExpiry { get; set; }
    public string AdminUserName { get; set; } = string.Empty;
    public int RemainingMinutes { get; set; }
    public DateTime ExpiresAt { get; set; }
}
