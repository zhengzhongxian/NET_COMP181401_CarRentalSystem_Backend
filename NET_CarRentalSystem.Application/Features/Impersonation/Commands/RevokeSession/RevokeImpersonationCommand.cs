using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.RevokeSession;

public class RevokeImpersonationCommand : ICommand<(string Message, bool Success)>
{
    public string ImpersonationToken { get; set; } = string.Empty;
}
