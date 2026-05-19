using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Payments.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Payments.Consumers;

public class PaymentEmailEventConsumer(
    IEnumerable<IPaymentEmailStrategy> emailStrategies,
    IUnitOfWork unitOfWork,
    ILogger<PaymentEmailEventConsumer> logger) : IConsumer<PaymentEmailEvent>
{
    private readonly Dictionary<TransactionType, IPaymentEmailStrategy> _strategyMap =
        emailStrategies.ToDictionary(s => s.TransactionType);

    public async Task Consume(ConsumeContext<PaymentEmailEvent> context)
    {
        var @event = context.Message;
        
        logger.LogInformation(
            "[PaymentEmailEventConsumer] Started processing PaymentEmailEvent. BookingId={BookingId}, CustomerId={CustomerId}, TransactionType={TransactionType}, Amount={Amount}",
            @event.BookingId, @event.CustomerId, @event.TransactionType, @event.Amount);
        
        var customer = await unitOfWork.GetReadRepository<Customer>()
            .GetFirstOrDefaultAsync(c => c.CustomerId == @event.CustomerId, cancellationToken: context.CancellationToken);

        if (customer == null)
        {
            logger.LogError("[PaymentEmailEventConsumer] Failed: Customer not found. CustomerId={CustomerId}", @event.CustomerId);
            return;
        }

        var user = await unitOfWork.GetReadRepository<User>()
            .GetFirstOrDefaultAsync(u => u.Id == customer.UserId, cancellationToken: context.CancellationToken);

        if (user == null)
        {
            logger.LogError("[PaymentEmailEventConsumer] Failed: User not found. UserId={UserId}", customer.UserId);
            return;
        }
        
        logger.LogInformation("[PaymentEmailEventConsumer] Found customer and user. Email={Email}, CustomerId={CustomerId}", 
            user.Email, @event.CustomerId);
        
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
            if (_strategyMap.TryGetValue(@event.TransactionType, out var strategy))
            {
                logger.LogInformation("[PaymentEmailEventConsumer] Sending {TransactionType} payment email for BookingId={BookingId}",
                    @event.TransactionType, @event.BookingId);
                await strategy.SendAsync(customer, user, booking, vehicle, @event, context.CancellationToken);
            }
            else
            {
                logger.LogWarning("[PaymentEmailEventConsumer] No email strategy found for TransactionType={TransactionType}",
                    @event.TransactionType);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "[PaymentEmailEventConsumer] Exception occurred while sending payment email. BookingId={BookingId}, CustomerId={CustomerId}, Error={ErrorMessage}",
                @event.BookingId, @event.CustomerId, ex.Message);
            throw;
        }
    }
}
