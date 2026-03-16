using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Quartz;
using System.Text.Json;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
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
            var publishEndpoint = serviceProvider.GetRequiredService<IPublishEndpoint>();

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

            var publishedCount = 0;

            foreach (var booking in bookingsToRemind)
            {
                try
                {
                    var reminderEvent = CreateReminderEvent(booking);
                    await publishEndpoint.Publish(reminderEvent, context.CancellationToken);
                    await unitOfWork.SaveChangesAsync(context.CancellationToken);
                    publishedCount++;

                    logger.LogInformation(
                        "[ReturnDeadlineReminderJob] ✅ Published reminder event for BookingId={BookingId}, CustomerEmail={Email}",
                        booking.BookingId, booking.CustomerEmail);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex,
                        "[ReturnDeadlineReminderJob] ❌ Failed to publish reminder event for BookingId={BookingId}",
                        booking.BookingId);
                }
            }

            logger.LogInformation(
                "[ReturnDeadlineReminderJob] Completed at {Time}. Published: {PublishedCount}/{TotalCount} events",
                DateTime.UtcNow, publishedCount, bookingsToRemind.Count);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[ReturnDeadlineReminderJob] Fatal error during return deadline reminder processing");
            throw;
        }
    }

    private ReturnDeadlineReminderEvent CreateReminderEvent(BookingReadFlat booking)
    {
        var customerName = booking.CustomerName ?? booking.CustomerEmail ?? "Khách hàng";
        var returnLocation = booking.ReturnLocationName ?? booking.PickupLocationName;
        
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

        return new ReturnDeadlineReminderEvent
        {
            BookingId = booking.BookingId,
            CustomerName = customerName,
            CustomerEmail = booking.CustomerEmail,
            NumberPlate = booking.NumberPlate ?? "N/A",
            Manufacturer = manufacturer,
            Model = model,
            Color = color,
            PickupLocationName = booking.PickupLocationName,
            ReturnLocationName = returnLocation,
            EndDate = booking.EndDate,
            DetectedAt = DateTime.UtcNow
        };
    }
}
