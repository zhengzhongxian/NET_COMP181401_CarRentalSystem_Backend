using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using System.Text.Json;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Infrastructure.Configurations;

namespace NET_CarRentalSystem.Infrastructure.Services.Scheduling.Jobs;

[DisallowConcurrentExecution]
public class ReturnDeadlineReminderJob(
    ILogger<ReturnDeadlineReminderJob> logger,
    IServiceScopeFactory serviceScopeFactory,
    IOptions<ReturnDeadlineReminderJobConfig> configOptions) : IJob
{
    private readonly ReturnDeadlineReminderJobConfig _config = configOptions.Value;
    private const string EmailTemplateName = "ReturnDeadlineReminderEmail.html";
    private const string EmailSubject = "⏰ Nhắc nhở: Còn 15 phút nữa là đến hạn trả xe - Renticar";

    public async Task Execute(IJobExecutionContext context)
    {
        try
        {
            logger.LogInformation(
                "[ReturnDeadlineReminderJob] Starting return deadline reminder check at {Time}. ReminderMinutes={ReminderMinutes}, Tolerance={Tolerance}",
                DateTime.UtcNow, _config.ReminderMinutesBefore, _config.ToleranceMinutes);

            using var scope = serviceScopeFactory.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            var emailService = serviceProvider.GetRequiredService<IEmailService>();

            var now = DateTime.UtcNow;
            var reminderWindowStart = now.AddMinutes(_config.ReminderMinutesBefore - _config.ToleranceMinutes);
            var reminderWindowEnd = now.AddMinutes(_config.ReminderMinutesBefore + _config.ToleranceMinutes);

            var bookingsToRemind = await unitOfWork.GetReadRepository<BookingReadFlat>()
                .GetQueryable()
                .Where(b => b.Status == BookingStatus.InProgress &&
                            b.EndDate >= reminderWindowStart &&
                            b.EndDate <= reminderWindowEnd)
                .ToListAsync(context.CancellationToken);

            logger.LogInformation(
                "[ReturnDeadlineReminderJob] Found {Count} bookings approaching return deadline (Window: {Start} to {End})",
                bookingsToRemind.Count, reminderWindowStart, reminderWindowEnd);

            if (bookingsToRemind.Count == 0)
            {
                logger.LogInformation("[ReturnDeadlineReminderJob] No bookings require reminder at this time");
                return;
            }

            var sentCount = 0;
            var failedCount = 0;

            foreach (var booking in bookingsToRemind)
            {
                try
                {
                    await SendReminderEmailAsync(emailService, booking, context.CancellationToken);
                    sentCount++;
                    logger.LogInformation(
                        "[ReturnDeadlineReminderJob] ✅ Sent reminder email for BookingId={BookingId}, CustomerEmail={Email}",
                        booking.BookingId, booking.CustomerEmail);
                }
                catch (Exception ex)
                {
                    failedCount++;
                    logger.LogError(ex,
                        "[ReturnDeadlineReminderJob] ❌ Failed to send reminder email for BookingId={BookingId}",
                        booking.BookingId);
                }
            }

            logger.LogInformation(
                "[ReturnDeadlineReminderJob] Completed at {Time}. Sent: {SentCount}, Failed: {FailedCount}, Total: {TotalCount}",
                DateTime.UtcNow, sentCount, failedCount, bookingsToRemind.Count);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[ReturnDeadlineReminderJob] Fatal error during return deadline reminder processing");
            throw;
        }
    }

    private async Task SendReminderEmailAsync(
        IEmailService emailService,
        BookingReadFlat booking,
        CancellationToken cancellationToken)
    {
        var customerEmail = booking.CustomerEmail;
        if (string.IsNullOrEmpty(customerEmail))
        {
            logger.LogWarning("[ReturnDeadlineReminderJob] Skipping BookingId={BookingId} - No customer email", booking.BookingId);
            return;
        }

        var customerName = booking.CustomerName ?? customerEmail;
        var returnLocation = booking.ReturnLocationName ?? booking.PickupLocationName;

        // Parse Metadata to get vehicle details
        var manufacturer = "N/A";
        var model = "N/A";
        var color = "N/A";

        if (!string.IsNullOrEmpty(booking.Metadata))
        {
            try
            {
                using var doc = JsonDocument.Parse(booking.Metadata);
                var root = doc.RootElement;
                
                if (root.TryGetProperty("Manufacturer", out var manuProp))
                    manufacturer = manuProp.GetString() ?? "N/A";
                if (root.TryGetProperty("Model", out var modelProp))
                    model = modelProp.GetString() ?? "N/A";
                if (root.TryGetProperty("Color", out var colorProp))
                    color = colorProp.GetString() ?? "N/A";
            }
            catch (JsonException ex)
            {
                logger.LogWarning(ex, "[ReturnDeadlineReminderJob] Failed to parse Metadata for BookingId={BookingId}", booking.BookingId);
            }
        }

        var placeholders = new Dictionary<string, string>
        {
            { "{{CustomerName}}", customerName },
            { "{{BookingId}}", booking.BookingId.ToString().ToUpper()[..8] },
            { "{{Manufacturer}}", manufacturer },
            { "{{Model}}", model },
            { "{{Color}}", color },
            { "{{NumberPlate}}", booking.NumberPlate ?? "N/A" },
            { "{{PickupLocation}}", booking.PickupLocationName },
            { "{{ReturnLocation}}", returnLocation },
            { "{{EndDate}}", booking.EndDate.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
            { "{{AppUrl}}", "https://renticar.com" }
        };

        await emailService.SendTemplateEmailViaGmailApiAsync(
            customerEmail,
            EmailSubject,
            EmailTemplateName,
            placeholders,
            cancellationToken);
    }
}
