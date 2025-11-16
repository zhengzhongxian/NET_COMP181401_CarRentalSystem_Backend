using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services;

namespace NET_CarRentalSystem.Infrastructure.Services;

public class EmailService(IOptions<EmailSettings> emailSettings, IWebHostEnvironment webHostEnvironment) : IEmailService
{
    private readonly EmailSettings _emailSettings = emailSettings.Value;

    public async Task SendTemplateEmailAsync(string toEmail, string subject, string templateName, Dictionary<string, string> placeholders, CancellationToken cancellationToken = default)
    {
        var templatePath = Path.Combine(webHostEnvironment.WebRootPath, "emails", templateName);
        var emailBody = await File.ReadAllTextAsync(templatePath, cancellationToken);

        emailBody = placeholders.Aggregate(emailBody, (current, placeholder) 
            => current.Replace(placeholder.Key, placeholder.Value));

        var fromAddress = new MailAddress(_emailSettings.FromEmailAddress, _emailSettings.FromDisplayName);
        var toAddress = new MailAddress(toEmail);

        var smtp = new SmtpClient
        {
            Host = _emailSettings.Smtp.Host,
            Port = _emailSettings.Smtp.Port,
            EnableSsl = _emailSettings.Smtp.EnableSsl,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(_emailSettings.Smtp.EmailAddress, _emailSettings.Smtp.Password)
        };

        using var message = new MailMessage(fromAddress, toAddress);
        message.Subject = subject;
        message.Body = emailBody;
        message.IsBodyHtml = true;

        await smtp.SendMailAsync(message, cancellationToken);
    }
}

