using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Infrastructure.Services.Notifications;

public class EmailService(
    IOptions<EmailSettings> emailSettings, 
    IWebHostEnvironment webHostEnvironment,
    IOptions<GmailApiSettings> gmailApiSettings) : IEmailService
{
    private readonly EmailSettings _emailSettings = emailSettings.Value;
    private readonly GmailApiSettings _gmailApiSettings = gmailApiSettings.Value;

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

    public async Task SendTemplateEmailViaGmailApiAsync(string toEmail, string subject, string templateName, Dictionary<string, string> placeholders, CancellationToken cancellationToken = default)
    {
        var templatePath = Path.Combine(webHostEnvironment.WebRootPath, "emails", templateName);
        var emailBody = await File.ReadAllTextAsync(templatePath, cancellationToken);

        emailBody = placeholders.Aggregate(emailBody, (current, placeholder)
            => current.Replace(placeholder.Key, placeholder.Value));
        
        var subjectEncoded = $"=?UTF-8?B?{Convert.ToBase64String(Encoding.UTF8.GetBytes(subject))}?=";

        var rawMessageBuilder = new StringBuilder();
        rawMessageBuilder.AppendLine($"From: {_gmailApiSettings.SenderName} <{_gmailApiSettings.SenderEmail}>");
        rawMessageBuilder.AppendLine($"To: {toEmail}");
        rawMessageBuilder.AppendLine($"Subject: {subjectEncoded}");
        rawMessageBuilder.AppendLine("MIME-Version: 1.0");
        rawMessageBuilder.AppendLine("Content-Type: text/html; charset=utf-8");
        rawMessageBuilder.AppendLine();
        rawMessageBuilder.AppendLine(emailBody);

        var rawBytes = Encoding.UTF8.GetBytes(rawMessageBuilder.ToString());
        var rawBase64 = Convert.ToBase64String(rawBytes)
            .Replace('+', '-')
            .Replace('/', '_')
            .TrimEnd('=');
        
        var token = new TokenResponse { RefreshToken = _gmailApiSettings.RefreshToken };
        var secrets = new ClientSecrets
        {
            ClientId = _gmailApiSettings.ClientId,
            ClientSecret = _gmailApiSettings.ClientSecret
        };

        var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
        {
            ClientSecrets = secrets,
            Scopes = new[] { GmailService.Scope.GmailSend }
        });

        var credential = new UserCredential(flow, "user", token);

        using var service = new GmailService(new BaseClientService.Initializer
        {
            HttpClientInitializer = credential,
            ApplicationName = AppConstants.Architecture.ApiLayer
        });

        var gmailMessage = new Message { Raw = rawBase64 };

        await service.Users.Messages.Send(gmailMessage, "me").ExecuteAsync(cancellationToken);
    }
}

