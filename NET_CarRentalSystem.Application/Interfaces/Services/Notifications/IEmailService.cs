namespace NET_CarRentalSystem.Application.Interfaces.Services.Notifications;

public interface IEmailService
{
    Task SendTemplateEmailAsync(
        string toEmail, 
        string subject, 
        string templateName, 
        Dictionary<string, string> placeholders, 
        CancellationToken cancellationToken = default);
    
    Task SendTemplateEmailViaGmailApiAsync(
        string toEmail, 
        string subject, 
        string templateName, 
        Dictionary<string, string> placeholders, 
        CancellationToken cancellationToken = default);
}

