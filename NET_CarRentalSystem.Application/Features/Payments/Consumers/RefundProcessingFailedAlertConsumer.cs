using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

/// <summary>
/// Consumer xử lý khi RefundProcessingJob thất bại
/// Gửi alert email tới admin để xử lý thủ công
/// </summary>
public class RefundProcessingFailedAlertConsumer(
    ILogger<RefundProcessingFailedAlertConsumer> logger,
    IEmailService emailService,
    IUnitOfWork unitOfWork,
    IConfiguration configuration) : IConsumer<RefundProcessingFailedEvent>
{
    public async Task Consume(ConsumeContext<RefundProcessingFailedEvent> context)
    {
        var @event = context.Message;

        try
        {
            logger.LogError(
                "[RefundProcessingFailedAlertConsumer] ❌ CRITICAL ALERT: Refund processing failed. " +
                "RefundRequestId={RefundRequestId}, BookingId={BookingId}, Amount={Amount}VND, Reason={Reason}",
                @event.RefundRequestId, @event.BookingId, @event.Amount, @event.FailureReason);

            // Lấy danh sách admin để gửi alert
            var admins = await GetAdminEmailsAsync(context.CancellationToken);

            if (admins.Count == 0)
            {
                logger.LogError("[RefundProcessingFailedAlertConsumer] No admin emails found to send alert");
                return;
            }

            logger.LogInformation("[RefundProcessingFailedAlertConsumer] Found {AdminCount} admins to notify", admins.Count);

            var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";

            var emailData = new Dictionary<string, string>
            {
                { "RefundRequestId", @event.RefundRequestId.ToString() },
                { "BookingId", @event.BookingId.ToString() },
                { "Amount", @event.Amount.ToString("N0") + " VND" },
                { "FailureReason", @event.FailureReason },
                { "StackTrace", @event.StackTrace ?? "N/A" },
                { "RetryAttempts", @event.RetryAttempts.ToString() },
                { "FailedAt", @event.FailedAt.ToString("dd/MM/yyyy HH:mm:ss") },
                { "AdminDashboardUrl", $"{appUrl}/admin/refunds/pending" },
                { "AppUrl", appUrl }
            };

            // Gửi alert email tới từng admin
            foreach (var adminEmail in admins)
            {
                try
                {
                    logger.LogInformation("[RefundProcessingFailedAlertConsumer] Sending alert to admin. Email={Email}, RefundRequestId={RefundRequestId}",
                        adminEmail, @event.RefundRequestId);

                    await emailService.SendTemplateEmailViaGmailApiAsync(
                        adminEmail,
                        "⚠️ URGENT: Refund Processing Failed - Manual Action Required",
                        AppConstants.EmailTemplates.RefundProcessingFailureAlert, // Sẽ tạo template này
                        emailData,
                        context.CancellationToken
                    );

                    logger.LogInformation("[RefundProcessingFailedAlertConsumer] Alert sent successfully to {Email}", adminEmail);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "[RefundProcessingFailedAlertConsumer] Failed to send alert to admin. Email={Email}, Error={ErrorMessage}",
                        adminEmail, ex.Message);
                    // Tiếp tục gửi email tới admin khác
                }
            }

            logger.LogError("[RefundProcessingFailedAlertConsumer] ❌ CRITICAL: RefundRequestId={RefundRequestId} requires immediate admin attention",
                @event.RefundRequestId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundProcessingFailedAlertConsumer] Exception occurred processing RefundProcessingFailedEvent for RefundRequestId={RefundRequestId}",
                @event.RefundRequestId);
            throw;
        }
    }

    private async Task<List<string>> GetAdminEmailsAsync(CancellationToken cancellationToken)
    {
        try
        {
            var adminUsers = await unitOfWork.GetReadRepository<User>()
                .GetAsync(
                    filter: u => u.UserRoles.Any(ur => ur.Role.Name == RoleConstants.Admin) && !string.IsNullOrEmpty(u.Email),
                    cancellationToken: cancellationToken
                );

            var adminEmails = adminUsers
                .Where(u => !string.IsNullOrEmpty(u.Email))
                .Select(u => u.Email)
                .Distinct()
                .ToList();

            logger.LogInformation("[RefundProcessingFailedAlertConsumer] Retrieved {AdminCount} admin emails", adminEmails.Count);

            return adminEmails;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[RefundProcessingFailedAlertConsumer] Error retrieving admin emails");
            return [];
        }
    }
}

