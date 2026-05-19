using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class DepositPaymentEmailStrategy(
    IEmailService emailService,
    IConfiguration configuration,
    ILogger<DepositPaymentEmailStrategy> logger) : IPaymentEmailStrategy
{
    public TransactionType TransactionType => TransactionType.Deposit;

    public async Task SendAsync(
        Customer customer,
        User user,
        BookingReadFlat booking,
        VehicleReadFlat vehicle,
        PaymentEmailEvent @event,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[DepositPaymentEmailStrategy] Preparing deposit payment email. Email={Email}, BookingId={BookingId}, Amount={Amount}VND",
                user.Email, booking.BookingId, @event.Amount);

            var vehicleImages = string.IsNullOrEmpty(vehicle.ImagesJson)
                ? []
                : vehicle.ImagesJson.FromJson<List<GetVehicleImageDto>>() ?? [];

            logger.LogInformation("[DepositPaymentEmailStrategy] Retrieved {ImageCount} vehicle images for BookingId={BookingId}",
                vehicleImages.Count, booking.BookingId);

            var vehicleImagesHtml = GenerateVehicleImagesHtml(vehicleImages);
            var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";

            var emailData = new Dictionary<string, string>
            {
                { "{{CustomerName}}", $"{customer.FirstName} {customer.LastName}" },
                { "{{BookingId}}", booking.BookingId.ToString() },
                { "{{Manufacturer}}", vehicle.Manufacturer },
                { "{{Model}}", vehicle.Model },
                { "{{Color}}", vehicle.Color ?? "N/A" },
                { "{{StartDate}}", booking.StartDate.ToString("dd/MM/yyyy HH:mm") },
                { "{{EndDate}}", booking.EndDate.ToString("dd/MM/yyyy HH:mm") },
                { "{{PickupLocation}}", booking.PickupLocationName },
                { "{{DiscountRate}}", $"{(booking.DiscountRate * 100):0.##}%" },
                { "{{DepositAmount}}", @event.Amount.ToString("N0") + " VND" },
                { "{{VehicleImages}}", vehicleImagesHtml },
                { "{{AppUrl}}", appUrl }
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                user.Email,
                "Thanh toán tiền cọc thành công - Renticar",
                AppConstants.EmailTemplates.DepositPaymentSuccess,
                emailData,
                cancellationToken
            );
            
            logger.LogInformation(
                "[DepositPaymentEmailStrategy] Deposit payment email sent successfully. Email={Email}, BookingId={BookingId}, TemplateKey={TemplateKey}",
                user.Email, booking.BookingId, AppConstants.EmailTemplates.DepositPaymentSuccess);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[DepositPaymentEmailStrategy] Failed to send deposit payment email. Email={Email}, BookingId={BookingId}, Error={ErrorMessage}",
                user.Email, booking.BookingId, ex.Message);
            throw;
        }
    }

    private static string GenerateVehicleImagesHtml(List<GetVehicleImageDto> images)
    {
        if (images.Count == 0)
            return "<p style='margin: 20px 0; color: #999; font-size: 13px;'>Không có hình ảnh xe</p>";

        var html = "<table role='presentation' width='100%' cellpadding='0' cellspacing='0' border='1' style='margin-bottom: 25px; border-collapse: collapse; border: 1px solid #333333;'>";
        
        for (var i = 0; i < images.Count; i++)
        {
            html += $@"
                <tr>
                    <td style='color: #666666; font-size: 12px; text-transform: uppercase; font-weight: 600; padding: 12px 15px; border: 1px solid #333333; width: 30%;'>Ảnh xe {i + 1}</td>
                    <td style='padding: 12px 15px; border: 1px solid #333333;'>
                        <img src='{images[i].ImageUrl}' alt='Ảnh xe {i + 1}' style='width: 100%; max-width: 400px; height: auto; display: block;'>
                    </td>
                </tr>";
        }
        
        html += "</table>";
        return html;
    }
}
