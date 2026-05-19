using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Strategies;

public class FinalPaymentEmailStrategy(
    IEmailService emailService,
    IConfiguration configuration,
    ILogger<FinalPaymentEmailStrategy> logger) : IPaymentEmailStrategy
{
    public TransactionType TransactionType => TransactionType.FinalPayment;

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
                "[FinalPaymentEmailStrategy] Preparing full payment email. Email={Email}, BookingId={BookingId}, Amount={Amount}VND",
                user.Email, booking.BookingId, @event.Amount);

            var bookingImages = string.IsNullOrEmpty(booking.BookingImagesJson)
                ? []
                : booking.BookingImagesJson.FromJson<List<GetBookingImageDto>>() ?? [];

            logger.LogInformation("[FinalPaymentEmailStrategy] Retrieved {ImageCount} booking images for BookingId={BookingId}",
                bookingImages.Count, booking.BookingId);

            var bookingImagesHtml = GenerateBookingImagesHtml(bookingImages);
            var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";

            var depositAmount = booking.TotalPrice * booking.DepositRatio;
            // Thanh toán 100% giá thuê (tiền cọc giữ riêng, hoàn trả sau 30 ngày)
            var finalAmount = booking.TotalPrice;

            logger.LogInformation(
                "[FinalPaymentEmailStrategy] Calculating amounts. TotalPrice={TotalPrice}VND, DepositRatio={DepositRatio}, DepositAmount={DepositAmount}VND, FinalAmount={FinalAmount}VND (100%)",
                booking.TotalPrice, booking.DepositRatio, depositAmount, finalAmount);

            var emailData = new Dictionary<string, string>
            {
                { "{{CustomerName}}", $"{customer.FirstName} {customer.LastName}" },
                { "{{BookingId}}", booking.BookingId.ToString() },
                { "{{Manufacturer}}", vehicle.Manufacturer },
                { "{{Model}}", vehicle.Model },
                { "{{Color}}", vehicle.Color ?? "N/A" },
                { "{{NumberPlate}}", booking.NumberPlate ?? "N/A" },
                { "{{StartDate}}", booking.StartDate.ToString("dd/MM/yyyy HH:mm") },
                { "{{EndDate}}", booking.EndDate.ToString("dd/MM/yyyy HH:mm") },
                { "{{PickupLocation}}", booking.PickupLocationName },
                { "{{TotalAmount}}", booking.TotalPrice.ToString("N0") + " VND" },
                { "{{DepositAmount}}", depositAmount.ToString("N0") + " VND" },
                { "{{FinalAmount}}", finalAmount.ToString("N0") + " VND" },
                { "{{DiscountRate}}", $"{(booking.DiscountRate * 100):0.##}%" },
                { "{{MileageStart}}", booking.MileageStart.ToString("N0") },
                { "{{FuelLevelEnd}}", booking.FuelLevelEnd?.ToString() ?? "N/A" },
                { "{{FuelPrice}}", booking.FuelPrice.HasValue ? booking.FuelPrice.Value.ToString("N0") + " VND" : "N/A" },
                { "{{ConditionNotes}}", booking.ConditionNotes ?? "Tốt" },
                { "{{BookingImages}}", bookingImagesHtml },
                { "{{AppUrl}}", appUrl },
                { "{{DepositRefundNote}}", $"Tiền cọc {depositAmount:N0} VND sẽ được hoàn trả sau 30 ngày kể từ khi trả xe, nếu không có vi phạm phát sinh." }
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                user.Email,
                "Thanh toán toàn bộ thành công - Renticar",
                AppConstants.EmailTemplates.FullPaymentSuccess,
                emailData,
                cancellationToken
            );
            
            logger.LogInformation(
                "[FinalPaymentEmailStrategy] Full payment email sent successfully. Email={Email}, BookingId={BookingId}, TemplateKey={TemplateKey}, FinalAmount={FinalAmount}VND",
                user.Email, booking.BookingId, AppConstants.EmailTemplates.FullPaymentSuccess, finalAmount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[FinalPaymentEmailStrategy] Failed to send full payment email. Email={Email}, BookingId={BookingId}, Error={ErrorMessage}",
                user.Email, booking.BookingId, ex.Message);
            throw;
        }
    }

    private static string GenerateBookingImagesHtml(List<GetBookingImageDto> images)
    {
        if (images.Count == 0)
            return "<p style='margin: 20px 0; color: #999; font-size: 13px;'>Không có hình ảnh booking</p>";

        var html = "<h3 style='margin: 30px 0 15px 0; font-size: 16px; font-weight: 700; color: #0d9488; text-transform: uppercase;'>Hình ảnh xe khi lấy</h3>";
        html += "<table role='presentation' width='100%' cellpadding='0' cellspacing='0' border='1' style='margin-bottom: 25px; border-collapse: collapse; border: 1px solid #333333;'>";
        
        for (var i = 0; i < images.Count; i++)
        {
            html += $@"
                <tr>
                    <td style='color: #666666; font-size: 12px; text-transform: uppercase; font-weight: 600; padding: 12px 15px; border: 1px solid #333333; width: 30%;'>Ảnh {i + 1}</td>
                    <td style='padding: 12px 15px; border: 1px solid #333333;'>
                        <img src='{images[i].ImageUrl}' alt='Ảnh {i + 1}' style='width: 100%; max-width: 400px; height: auto; display: block;'>
                    </td>
                </tr>";
        }
        
        html += "</table>";
        return html;
    }
}
