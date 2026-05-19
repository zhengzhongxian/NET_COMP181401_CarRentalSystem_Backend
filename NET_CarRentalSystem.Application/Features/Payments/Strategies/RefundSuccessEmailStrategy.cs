using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class RefundSuccessEmailStrategy(
    IEmailService emailService,
    ILogger<RefundSuccessEmailStrategy> logger) : IRefundEmailStrategy
{
    public RefundEmailType EmailType => RefundEmailType.Success;

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
                "[RefundSuccessEmailStrategy] Preparing refund success email. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
                email, @event.RefundRequestId, @event.Amount);

            var emailData = new Dictionary<string, string>
            {
                { "{{CustomerName}}", $"{customer.FirstName} {customer.LastName}" },
                { "{{RefundAmount}}", @event.Amount.ToString("N0") + " VND" },
                { "{{AppUrl}}", appUrl }
            };
            
            await emailService.SendTemplateEmailViaGmailApiAsync(
                email,
                "Hoàn tiền thành công - Renticar",
                AppConstants.EmailTemplates.RefundSuccess,
                emailData,
                cancellationToken
            );

            logger.LogInformation(
                "[RefundSuccessEmailStrategy] Refund success email sent successfully. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
                email, @event.RefundRequestId, @event.Amount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundSuccessEmailStrategy] Failed to send refund success email. Email={Email}, RefundRequestId={RefundRequestId}, Error={ErrorMessage}",
                email, @event.RefundRequestId, ex.Message);
            throw;
        }
    }
}
