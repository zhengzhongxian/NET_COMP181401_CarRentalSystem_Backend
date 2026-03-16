using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;

namespace NET_CarRentalSystem.Application.Features.Bookings.Consumers;

public class ReturnDeadlineReminderConsumer(
    IEmailService emailService,
    ILogger<ReturnDeadlineReminderConsumer> logger) : IConsumer<ReturnDeadlineReminderEvent>
{
    private const string EmailTemplateName = "ReturnDeadlineReminderEmail.html";
    private const string EmailSubject = "⏰ Nhắc nhở: Còn 15 phút nữa là đến hạn trả xe - Renticar";

    public async Task Consume(ConsumeContext<ReturnDeadlineReminderEvent> context)
    {
        var msg = context.Message;

        try
        {
            if (string.IsNullOrWhiteSpace(msg.CustomerEmail))
            {
                logger.LogWarning(
                    "[ReturnDeadlineReminderConsumer] No customer email for BookingId={BookingId}",
                    msg.BookingId);
                return;
            }

            logger.LogInformation(
                "[ReturnDeadlineReminderConsumer] Sending reminder email for BookingId={BookingId}, Email={Email}",
                msg.BookingId, msg.CustomerEmail);

            var placeholders = new Dictionary<string, string>
            {
                { "{{CustomerName}}", msg.CustomerName },
                { "{{BookingId}}", msg.BookingId.ToString().ToUpper()[..8] },
                { "{{Manufacturer}}", msg.Manufacturer },
                { "{{Model}}", msg.Model },
                { "{{Color}}", msg.Color },
                { "{{NumberPlate}}", msg.NumberPlate },
                { "{{PickupLocation}}", msg.PickupLocationName },
                { "{{ReturnLocation}}", msg.ReturnLocationName },
                { "{{EndDate}}", msg.EndDate.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
                { "{{AppUrl}}", "https://renticar.com" }
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                msg.CustomerEmail,
                EmailSubject,
                EmailTemplateName,
                placeholders,
                context.CancellationToken);

            logger.LogInformation(
                "[ReturnDeadlineReminderConsumer] ✅ Sent reminder email for BookingId={BookingId}",
                msg.BookingId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[ReturnDeadlineReminderConsumer] ❌ Failed to send reminder email for BookingId={BookingId}",
                msg.BookingId);
            throw;
        }
    }
}

