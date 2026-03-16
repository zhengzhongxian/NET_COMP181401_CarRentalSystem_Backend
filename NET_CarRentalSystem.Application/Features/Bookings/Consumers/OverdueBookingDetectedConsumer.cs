using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Bookings.Consumers;

public class OverdueBookingDetectedConsumer(
    IEmailService emailService,
    ILogger<OverdueBookingDetectedConsumer> logger) : IConsumer<OverdueBookingDetectedEvent>
{
    public async Task Consume(ConsumeContext<OverdueBookingDetectedEvent> context)
    {
        var msg = context.Message;
        
        try
        {
            logger.LogInformation(
                "[OverdueBookingConsumer] Processing overdue booking: BookingId={BookingId}, Severity={Severity}, OverdueMinutes={OverdueMinutes}",
                msg.BookingId, msg.Severity, msg.OverdueMinutes);

            // 1. Gửi email cảnh báo cho khách hàng
            if (!string.IsNullOrWhiteSpace(msg.CustomerEmail))
            {
                await SendCustomerWarningEmailAsync(msg, context.CancellationToken);
            }
            else
            {
                logger.LogWarning(
                    "[OverdueBookingConsumer] No customer email for BookingId={BookingId}",
                    msg.BookingId);
            }
            
            if (msg.NotifyAdmin && !string.IsNullOrWhiteSpace(msg.AdminEmail))
            {
                await SendAdminAlertEmailAsync(msg, context.CancellationToken);
            }

            logger.LogInformation(
                "[OverdueBookingConsumer] Completed processing for BookingId={BookingId}",
                msg.BookingId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[OverdueBookingConsumer] Error processing OverdueBookingDetectedEvent for BookingId={BookingId}",
                msg.BookingId);
            throw;
        }
    }

    private async Task SendCustomerWarningEmailAsync(OverdueBookingDetectedEvent msg, CancellationToken ct)
    {
        try
        {
            var overdueHours = msg.OverdueMinutes / 60;
            var overdueRemainingMinutes = msg.OverdueMinutes % 60;
            var overdueText = overdueHours > 0
                ? $"{overdueHours} giờ {overdueRemainingMinutes} phút"
                : $"{overdueRemainingMinutes} phút";

            var severityText = msg.Severity switch
            {
                "Critical" => "🚨 KHẨN CẤP",
                "Urgent" => "⚠️ QUAN TRỌNG",
                _ => "⏰ NHẮC NHỞ"
            };

            var placeholders = new Dictionary<string, string>
            {
                { "{{CustomerName}}", msg.CustomerName },
                { "{{BookingId}}", msg.BookingId.ToString()[..8].ToUpper() },
                { "{{NumberPlate}}", msg.NumberPlate },
                { "{{VehicleInfo}}", msg.VehicleInfo },
                { "{{PickupLocation}}", msg.PickupLocationName },
                { "{{EndDate}}", msg.EndDate.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
                { "{{OverdueTime}}", overdueText },
                { "{{Severity}}", severityText },
                { "{{SeverityLevel}}", msg.Severity },
                { "{{AppUrl}}", "https://renticar.com" }
            };

            var subject = msg.Severity switch
            {
                "Critical" => $"🚨 KHẨN CẤP: Xe {msg.NumberPlate} đã quá hạn trả {overdueText} - Renticar",
                "Urgent" => $"⚠️ Cảnh báo: Xe {msg.NumberPlate} đã quá hạn trả {overdueText} - Renticar",
                _ => $"⏰ Nhắc nhở: Xe {msg.NumberPlate} đã quá hạn trả - Renticar"
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                msg.CustomerEmail!,
                subject,
                AppConstants.EmailTemplates.OverdueBookingWarning,
                placeholders,
                ct);

            logger.LogInformation(
                "[OverdueBookingConsumer] ✅ Sent warning email to customer {Email} for BookingId={BookingId}",
                msg.CustomerEmail, msg.BookingId);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[OverdueBookingConsumer] ❌ Failed to send customer warning email for BookingId={BookingId}",
                msg.BookingId);
        }
    }

    private async Task SendAdminAlertEmailAsync(OverdueBookingDetectedEvent msg, CancellationToken ct)
    {
        try
        {
            var adminEmails = msg.AdminEmail!.Split(';', StringSplitOptions.RemoveEmptyEntries);
            
            var overdueHours = msg.OverdueMinutes / 60;
            var overdueText = $"{overdueHours} giờ {msg.OverdueMinutes % 60} phút";

            var placeholders = new Dictionary<string, string>
            {
                { "{{CustomerName}}", msg.CustomerName },
                { "{{CustomerEmail}}", msg.CustomerEmail ?? "N/A" },
                { "{{CustomerPhone}}", msg.CustomerPhone ?? "N/A" },
                { "{{BookingId}}", msg.BookingId.ToString()[..8].ToUpper() },
                { "{{NumberPlate}}", msg.NumberPlate },
                { "{{VehicleInfo}}", msg.VehicleInfo },
                { "{{PickupLocation}}", msg.PickupLocationName },
                { "{{StartDate}}", msg.StartDate.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
                { "{{EndDate}}", msg.EndDate.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
                { "{{OverdueTime}}", overdueText },
                { "{{OverdueMinutes}}", msg.OverdueMinutes.ToString() },
                { "{{DetectedAt}}", msg.DetectedAt.ToLocalTime().ToString("HH:mm - dd/MM/yyyy") },
                { "{{AdminUrl}}", "https://admin.renticar.com/bookings" }
            };

            var subject = $"🚨 CẢNH BÁO: Khách hàng không trả xe - {msg.NumberPlate} (Quá hạn {overdueText})";

            foreach (var adminEmail in adminEmails)
            {
                try
                {
                    await emailService.SendTemplateEmailViaGmailApiAsync(
                        adminEmail.Trim(),
                        subject,
                        AppConstants.EmailTemplates.OverdueBookingAdminAlert,
                        placeholders,
                        ct);

                    logger.LogInformation(
                        "[OverdueBookingConsumer] ✅ Sent admin alert to {AdminEmail} for BookingId={BookingId}",
                        adminEmail, msg.BookingId);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex,
                        "[OverdueBookingConsumer] ❌ Failed to send admin alert to {AdminEmail}",
                        adminEmail);
                }
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[OverdueBookingConsumer] ❌ Failed to send admin alert emails for BookingId={BookingId}",
                msg.BookingId);
        }
    }
}

