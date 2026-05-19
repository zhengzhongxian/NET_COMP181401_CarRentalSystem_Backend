using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class RefundNotificationEmailStrategy(
    IEmailService emailService,
    ILogger<RefundNotificationEmailStrategy> logger) : IRefundEmailStrategy
{
    public RefundEmailType EmailType => RefundEmailType.Notification;

    public async Task SendAsync(
        string email,
        Customer customer,
        BookingReadFlat? booking,
        string vehicleName,
        RefundEmailEvent @event,
        string appUrl,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[RefundNotificationEmailStrategy] Preparing refund notification email. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND, Reason={Reason}",
                email, @event.RefundRequestId, @event.Amount, @event.Reason ?? "Không có");

            var emailData = new Dictionary<string, string>
            {
                { "{{CustomerName}}", $"{customer.FirstName} {customer.LastName}" },
                { "{{BookingId}}", booking?.BookingId.ToString() ?? "N/A" },
                { "{{VehicleName}}", vehicleName },
                { "{{RefundAmount}}", @event.Amount.ToString("N0") + " VND" },
                { "{{CancellationReason}}", @event.Reason ?? "Không có lý do" },
                { "{{ProcessingTime}}", "3-5 ngày làm việc" },
                { "{{AppUrl}}", appUrl }
            };
            
            await emailService.SendTemplateEmailViaGmailApiAsync(
                email,
                "Thông báo hoàn tiền - Renticar",
                AppConstants.EmailTemplates.RefundNotification,
                emailData,
                cancellationToken
            );

            logger.LogInformation(
                "[RefundNotificationEmailStrategy] Refund notification email sent successfully. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
                email, @event.RefundRequestId, @event.Amount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundNotificationEmailStrategy] Failed to send refund notification email. Email={Email}, RefundRequestId={RefundRequestId}, Error={ErrorMessage}",
                email, @event.RefundRequestId, ex.Message);
            throw;
        }
    }
}
