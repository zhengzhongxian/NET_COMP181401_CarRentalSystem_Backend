using MassTransit;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Bookings.Consumers;

public class BookingReturnViolationConsumer(
    IEmailService emailService, 
    ILogger<BookingReturnViolationConsumer> logger) : IConsumer<BookingReturnViolationEvent>
{
    public async Task Consume(ConsumeContext<BookingReturnViolationEvent> context)
    {
        var msg = context.Message;
        try
        {
            if (string.IsNullOrWhiteSpace(msg.CustomerEmail))
            {
                logger.LogWarning("BookingReturnViolationEvent: no customer email for booking {BookingId}", msg.BookingId);
                return;
            }

            var placeholders = new Dictionary<string, string>
            {
                { "{CustomerName}", msg.CustomerName },
                { "{BookingId}", msg.BookingId.ToString()[..8] },
                { "{ViolationDetails}", msg.ViolationDetailsHtml },
                { "{ViolationCount}", msg.ViolationCount.ToString() },
                { "{TotalAmount}", msg.TotalAmount.ToString("N0") }
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                msg.CustomerEmail,
                "Thông báo vi phạm - Renticar",
                AppConstants.EmailTemplates.ViolationNotification,
                placeholders,
                context.CancellationToken);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error while processing BookingReturnViolationEvent for booking {BookingId}", msg.BookingId);
            throw;
        }
    }
}

