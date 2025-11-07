namespace NET_CarRentalSystem.Application.Interfaces.Services;

public interface IEmailService
{
    Task SendTemplateEmailAsync(
        string toEmail, 
        string subject, 
        string templateName, 
        Dictionary<string, string> placeholders, 
        CancellationToken cancellationToken = default);
}

