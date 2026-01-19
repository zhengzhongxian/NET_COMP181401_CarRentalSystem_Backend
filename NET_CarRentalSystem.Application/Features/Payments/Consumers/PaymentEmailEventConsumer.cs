using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

public class PaymentEmailEventConsumer(
    IEmailService emailService,
    IUnitOfWork unitOfWork,
    IConfiguration configuration,
    ILogger<PaymentEmailEventConsumer> logger) : IConsumer<PaymentEmailEvent>
{
    public async Task Consume(ConsumeContext<PaymentEmailEvent> context)
    {
        var @event = context.Message;
        
        logger.LogInformation(
            "[PaymentEmailEventConsumer] Started processing PaymentEmailEvent. BookingId={BookingId}, CustomerId={CustomerId}, TransactionType={TransactionType}, Amount={Amount}",
            @event.BookingId, @event.CustomerId, @event.TransactionType, @event.Amount);
        
        var include = new IncludeBuilder<Customer>().Include(c => c.User);
        var includeProperties = include.Build();
        
        var customer = await unitOfWork.GetReadRepository<Customer>()
            .GetFirstOrDefaultAsync(
                c => c.CustomerId == @event.CustomerId,
                includeProperties,
                context.CancellationToken
            );

        if (customer?.User is null)
        {
            logger.LogError("[PaymentEmailEventConsumer] Failed: Customer or User not found. CustomerId={CustomerId}", @event.CustomerId);
            return;
        }
        
        logger.LogInformation("[PaymentEmailEventConsumer] Found customer. Email={Email}, CustomerId={CustomerId}", 
            customer.User.Email, @event.CustomerId);
        
        var booking = await unitOfWork.GetReadRepository<BookingReadFlat>()
            .GetFirstOrDefaultAsync(
                b => b.BookingId == @event.BookingId,
                "",
                context.CancellationToken
            );

        if (booking is null)
        {
            logger.LogError("[PaymentEmailEventConsumer] Failed: Booking not found. BookingId={BookingId}", @event.BookingId);
            return;
        }

        logger.LogInformation("[PaymentEmailEventConsumer] Found booking. BookingId={BookingId}, StartDate={StartDate}, EndDate={EndDate}, TotalPrice={TotalPrice}",
            @event.BookingId, booking.StartDate, booking.EndDate, booking.TotalPrice);
        
        var vehicle = await unitOfWork.GetReadRepository<VehicleReadFlat>()
            .GetByIdAsync(@event.VehicleId, context.CancellationToken);

        if (vehicle is null)
        {
            logger.LogError("[PaymentEmailEventConsumer] Failed: Vehicle not found. VehicleId={VehicleId}", @event.VehicleId);
            return;
        }
        
        logger.LogInformation("[PaymentEmailEventConsumer] Found vehicle. VehicleId={VehicleId}, Manufacturer={Manufacturer}, Model={Model}",
            @event.VehicleId, vehicle.Manufacturer, vehicle.Model);

        try
        {
            switch (@event.TransactionType)
            {
                case TransactionType.Deposit:
                    logger.LogInformation("[PaymentEmailEventConsumer] Sending deposit payment email for BookingId={BookingId}", @event.BookingId);
                    await SendDepositPaymentEmailAsync(customer, booking, vehicle, @event, context.CancellationToken);
                    break;

                case TransactionType.FinalPayment:
                    logger.LogInformation("[PaymentEmailEventConsumer] Sending full payment email for BookingId={BookingId}", @event.BookingId);
                    await SendFullPaymentEmailAsync(customer, booking, vehicle, @event, context.CancellationToken);
                    break;
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentEmailEventConsumer] Exception occurred while sending payment email. BookingId={BookingId}, CustomerId={CustomerId}, Error={ErrorMessage}",
                @event.BookingId, @event.CustomerId, ex.Message);
            throw;
        }
    }

    private async Task SendDepositPaymentEmailAsync(
        Customer customer,
        BookingReadFlat booking,
        VehicleReadFlat vehicle,
        PaymentEmailEvent @event,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[PaymentEmailEventConsumer] Preparing deposit payment email. Email={Email}, BookingId={BookingId}, Amount={Amount}VND",
                customer.User!.Email, booking.BookingId, @event.Amount);

            var vehicleImages = string.IsNullOrEmpty(vehicle.ImagesJson)
                ? []
                : vehicle.ImagesJson.FromJson<List<GetVehicleImageDto>>() ?? [];

            logger.LogInformation("[PaymentEmailEventConsumer] Retrieved {ImageCount} vehicle images for BookingId={BookingId}",
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
                customer.User!.Email,
                "Thanh toán tiền cọc thành công - Renticar",
                AppConstants.EmailTemplates.DepositPaymentSuccess,
                emailData,
                cancellationToken
            );
            
            logger.LogInformation(
                "[PaymentEmailEventConsumer] Deposit payment email sent successfully. Email={Email}, BookingId={BookingId}, TemplateKey={TemplateKey}",
                customer.User.Email, booking.BookingId, AppConstants.EmailTemplates.DepositPaymentSuccess);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[PaymentEmailEventConsumer] Failed to send deposit payment email. Email={Email}, BookingId={BookingId}, Error={ErrorMessage}",
                customer.User!.Email, booking.BookingId, ex.Message);
            throw;
        }
    }

    private async Task SendFullPaymentEmailAsync(
        Customer customer,
        BookingReadFlat booking,
        VehicleReadFlat vehicle,
        PaymentEmailEvent @event,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[PaymentEmailEventConsumer] Preparing full payment email. Email={Email}, BookingId={BookingId}, Amount={Amount}VND",
                customer.User!.Email, booking.BookingId, @event.Amount);

            var bookingImages = string.IsNullOrEmpty(booking.BookingImagesJson)
                ? []
                : booking.BookingImagesJson.FromJson<List<GetBookingImageDto>>() ?? [];

            logger.LogInformation("[PaymentEmailEventConsumer] Retrieved {ImageCount} booking images for BookingId={BookingId}",
                bookingImages.Count, booking.BookingId);

            var bookingImagesHtml = GenerateBookingImagesHtml(bookingImages);
            var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";

            var depositAmount = booking.TotalPrice * booking.DepositRatio;
            var finalAmount = booking.TotalPrice - depositAmount;

            logger.LogInformation(
                "[PaymentEmailEventConsumer] Calculating amounts. TotalPrice={TotalPrice}VND, DepositRatio={DepositRatio}, DepositAmount={DepositAmount}VND, FinalAmount={FinalAmount}VND",
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
                { "{{AppUrl}}", appUrl }
            };

            await emailService.SendTemplateEmailViaGmailApiAsync(
                customer.User!.Email,
                "Thanh toán toàn bộ thành công - Renticar",
                AppConstants.EmailTemplates.FullPaymentSuccess,
                emailData,
                cancellationToken
            );
            
            logger.LogInformation(
                "[PaymentEmailEventConsumer] Full payment email sent successfully. Email={Email}, BookingId={BookingId}, TemplateKey={TemplateKey}, FinalAmount={FinalAmount}VND",
                customer.User.Email, booking.BookingId, AppConstants.EmailTemplates.FullPaymentSuccess, finalAmount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[PaymentEmailEventConsumer] Failed to send full payment email. Email={Email}, BookingId={BookingId}, Error={ErrorMessage}",
                customer.User!.Email, booking.BookingId, ex.Message);
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
