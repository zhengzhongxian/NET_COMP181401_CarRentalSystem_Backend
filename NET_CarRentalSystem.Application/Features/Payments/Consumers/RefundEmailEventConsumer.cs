using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

public class RefundEmailEventConsumer(
    ILogger<RefundEmailEventConsumer> logger,
    IUnitOfWork unitOfWork,
    IEmailService emailService,
    IConfiguration configuration) : IConsumer<RefundEmailEvent>
{
    public async Task Consume(ConsumeContext<RefundEmailEvent> context)
    {
        var @event = context.Message;
        
        try
        {
            logger.LogInformation(
                "[RefundEmailEventConsumer] Started processing RefundEmailEvent. RefundRequestId={RefundRequestId}, BookingId={BookingId}, CustomerId={CustomerId}, EmailType={EmailType}, Amount={Amount}VND",
                @event.RefundRequestId, @event.BookingId, @event.CustomerId, @event.EmailType, @event.Amount);
            
            var bookingFlat = await unitOfWork.GetReadRepository<BookingReadFlat>()
                .GetByIdAsync(@event.BookingId, context.CancellationToken);
            
            if (bookingFlat == null)
            {
                logger.LogError("[RefundEmailEventConsumer] Failed: BookingReadFlat not found. BookingId={BookingId}", @event.BookingId);
                return;
            }
            
            logger.LogInformation("[RefundEmailEventConsumer] Found booking. BookingId={BookingId}, TotalPrice={TotalPrice}VND, StartDate={StartDate}",
                @event.BookingId, bookingFlat.TotalPrice, bookingFlat.StartDate);
            
            var customer = await unitOfWork.GetReadRepository<Customer>()
                .GetByIdAsync(@event.CustomerId, context.CancellationToken);
            
            if (customer == null)
            {
                logger.LogError("[RefundEmailEventConsumer] Failed: Customer not found. CustomerId={CustomerId}", @event.CustomerId);
                return;
            }
            
            logger.LogInformation("[RefundEmailEventConsumer] Found customer. CustomerId={CustomerId}, Name={CustomerName}",
                @event.CustomerId, $"{customer.FirstName} {customer.LastName}");
            
            var user = await unitOfWork.GetReadRepository<User>()
                .GetFirstOrDefaultAsync(u => u.Id == customer.UserId, cancellationToken: context.CancellationToken);
            
            if (user?.Email == null)
            {
                logger.LogError("[RefundEmailEventConsumer] Failed: User email not found. CustomerId={CustomerId}", @event.CustomerId);
                return;
            }
            
            logger.LogInformation("[RefundEmailEventConsumer] Found user email. Email={Email}, CustomerId={CustomerId}",
                user.Email, @event.CustomerId);
            
            var vehicleRead = await unitOfWork.GetReadRepository<VehicleReadFlat>()
                .GetByIdAsync(bookingFlat.VehicleId, context.CancellationToken);
            
            var vehicleName = vehicleRead != null 
                ? $"{vehicleRead.Manufacturer} {vehicleRead.Model}" 
                : "Unknown";
            
            logger.LogInformation("[RefundEmailEventConsumer] Retrieved vehicle info. VehicleName={VehicleName}, VehicleId={VehicleId}",
                vehicleName, bookingFlat.VehicleId);
            
            var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";
            
            switch (@event.EmailType)
            {
                case RefundEmailType.Notification:
                    logger.LogInformation("[RefundEmailEventConsumer] Sending refund notification email. RefundRequestId={RefundRequestId}, Email={Email}",
                        @event.RefundRequestId, user.Email);
                    await SendRefundNotificationEmailAsync(user.Email, customer, bookingFlat, vehicleName, @event, appUrl, context.CancellationToken);
                    break;
                    
                case RefundEmailType.Success:
                    logger.LogInformation("[RefundEmailEventConsumer] Sending refund success email. RefundRequestId={RefundRequestId}, Email={Email}",
                        @event.RefundRequestId, user.Email);
                    await SendRefundSuccessEmailAsync(user.Email, customer, @event, appUrl, context.CancellationToken);
                    break;
            }
            
            logger.LogInformation("[RefundEmailEventConsumer] Successfully completed refund email processing. RefundRequestId={RefundRequestId}, EmailType={EmailType}",
                @event.RefundRequestId, @event.EmailType);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, 
                "[RefundEmailEventConsumer] Exception occurred while processing refund email. RefundRequestId={RefundRequestId}, BookingId={BookingId}, Error={ErrorMessage}, StackTrace={StackTrace}",
                @event.RefundRequestId, @event.BookingId, ex.Message, ex.StackTrace);
            throw;
        }
    }
    
    private async Task SendRefundNotificationEmailAsync(
        string email,
        Customer customer,
        BookingReadFlat booking,
        string vehicleName,
        RefundEmailEvent @event,
        string appUrl,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[RefundEmailEventConsumer] Preparing refund notification email. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND, Reason={Reason}",
                email, @event.RefundRequestId, @event.Amount, @event.Reason ?? "Không có");

            var emailData = new Dictionary<string, string>
            {
                { "{{CustomerName}}", $"{customer.FirstName} {customer.LastName}" },
                { "{{BookingId}}", booking.BookingId.ToString() },
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
                "[RefundEmailEventConsumer] Refund notification email sent successfully. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
                email, @event.RefundRequestId, @event.Amount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundEmailEventConsumer] Failed to send refund notification email. Email={Email}, RefundRequestId={RefundRequestId}, Error={ErrorMessage}",
                email, @event.RefundRequestId, ex.Message);
            throw;
        }
    }
    
    private async Task SendRefundSuccessEmailAsync(
        string email,
        Customer customer,
        RefundEmailEvent @event,
        string appUrl,
        CancellationToken cancellationToken)
    {
        try
        {
            logger.LogInformation(
                "[RefundEmailEventConsumer] Preparing refund success email. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
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
                "[RefundEmailEventConsumer] Refund success email sent successfully. Email={Email}, RefundRequestId={RefundRequestId}, Amount={Amount}VND",
                email, @event.RefundRequestId, @event.Amount);
        }
        catch (Exception ex)
        {
            logger.LogError(ex,
                "[RefundEmailEventConsumer] Failed to send refund success email. Email={Email}, RefundRequestId={RefundRequestId}, Error={ErrorMessage}",
                email, @event.RefundRequestId, ex.Message);
            throw;
        }
    }
}

