using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;

namespace NET_CarRentalSystem.Application.Features.Impersonation.Commands.CreateSession;

public class CreateImpersonationSessionCommand : ICommand<(string Message, string? Token)>
{
    public string DeveloperCode { get; set; } = string.Empty;
    
    public int DurationMinutes { get; set; }
}
