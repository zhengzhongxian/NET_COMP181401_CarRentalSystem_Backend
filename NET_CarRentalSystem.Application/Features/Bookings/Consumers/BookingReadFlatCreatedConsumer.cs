using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Bookings.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Bookings.Consumers;

public class BookingReadFlatCreatedConsumer(
    ILogger<BookingReadFlatCreatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityCreatedConsumerBase<BookingCreatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "booking_read_flat";

    protected override string InsertColumns => """
                                                booking_id_src, customer_id, customer_name, customer_email, customer_phone,
                                                vehicle_id, vehicle_price_per_hour, vehicle_model_id, number_plate, 
                                                vehicle_status, pickup_location_id, pickup_location_name, return_location_id, 
                                                return_location_name, status, start_date, end_date, total_price, 
                                                deposit_ratio, discount_rate, late_penalty_ratio, mileage_start, description, 
                                                fuel_level_start,
                                                swap_reason, booking_images_json, booking_violations_json, return_images_json, metadata, 
                                                created_at, created_by, updated_at, updated_by, is_deleted
                                                """;

    protected override string InsertValues => """
                                               @Id, @CustomerId, @CustomerName, @CustomerEmail, @CustomerPhone,
                                               @VehicleId, @VehiclePricePerHour, @VehicleModelId, @NumberPlate,
                                               @VehicleStatus, @PickupLocationId, @PickupLocationName, @ReturnLocationId,
                                               @ReturnLocationName, @Status, @StartDate, @EndDate, @TotalPrice,
                                               @DepositRatio, @DiscountRate, @LatePenaltyRatio, @MileageStart, @Description,
                                               @FuelLevelStart,
                                               @SwapReason, @BookingImagesJson, @BookingViolationsJson, @ReturnImagesJson, @Metadata,
                                               @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, 0
                                               """;

    protected override object CreateParameters(BookingCreatedEvent msg)
    {
        return new
        {
            msg.Id,
            msg.CustomerId,
            msg.CustomerName,
            msg.CustomerEmail,
            msg.CustomerPhone,
            msg.VehicleId,
            msg.VehiclePricePerHour,
            msg.VehicleModelId,
            msg.NumberPlate,
            msg.VehicleStatus,
            msg.PickupLocationId,
            msg.PickupLocationName,
            msg.ReturnLocationId,
            msg.ReturnLocationName,
            Status = msg.Status.ToString(),
            msg.StartDate,
            msg.EndDate,
            msg.TotalPrice,
            msg.DepositRatio,
            msg.DiscountRate,
            msg.LatePenaltyRatio,
            msg.MileageStart,
            msg.FuelLevelStart,
            msg.Description,
            msg.SwapReason,
            msg.BookingImagesJson,
            BookingViolationsJson = (string?)null,
            ReturnImagesJson = (string?)null,
            msg.Metadata,
            msg.CreatedAt,
            msg.CreatedBy,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}
