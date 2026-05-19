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
    IEnumerable<IRefundEmailStrategy> refundStrategies,
    IConfiguration configuration) : IConsumer<RefundEmailEvent>
{
    private readonly Dictionary<RefundEmailType, IRefundEmailStrategy> _strategyMap =
        refundStrategies.ToDictionary(s => s.EmailType);

    public async Task Consume(ConsumeContext<RefundEmailEvent> context)
    {
        var @event = context.Message;
        
        try
        {
            logger.LogInformation(
                "[RefundEmailEventConsumer] Started processing RefundEmailEvent. RefundRequestId={RefundRequestId}, BookingId={BookingId}, CustomerId={CustomerId}, EmailType={EmailType}, Amount={Amount}VND",
                @event.RefundRequestId, @event.BookingId, @event.CustomerId, @event.EmailType, @event.Amount);
            
            // Tìm theo BookingId (booking_id_src), không phải Id
            var bookingFlat = await unitOfWork.GetReadRepository<BookingReadFlat>()
                .GetFirstOrDefaultAsync(b => b.BookingId == @event.BookingId, cancellationToken: context.CancellationToken);
            
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
            
            if (_strategyMap.TryGetValue(@event.EmailType, out var strategy))
            {
                logger.LogInformation("[RefundEmailEventConsumer] Sending {EmailType} refund email. RefundRequestId={RefundRequestId}, Email={Email}",
                    @event.EmailType, @event.RefundRequestId, user.Email);
                await strategy.SendAsync(user.Email, customer, bookingFlat, vehicleName, @event, appUrl, context.CancellationToken);
            }
            else
            {
                logger.LogWarning("[RefundEmailEventConsumer] No email strategy found for EmailType={EmailType}",
                    @event.EmailType);
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
}

