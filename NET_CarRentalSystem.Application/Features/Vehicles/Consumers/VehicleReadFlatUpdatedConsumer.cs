using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatUpdatedConsumer(
    ILogger<VehicleReadFlatUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityUpdatedConsumerBase<VehicleUpdatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";
    
    protected override string IdColumn => "vehicle_id";

    protected override string UpdateSetClause => @"
        number_plate = @NumberPlate,
        manufacturer = @Manufacturer,
        model = @Model,
        color = @Color,
        mileage = @Mileage,
        price_per_hour = @PricePerHour,
        thumbnail = @Thumbnail,
        description = @Description,
        last_checkout_at = @LastCheckoutAt,
        rating = @Rating,
        status = @Status,
        condition_notes = @ConditionNotes,
        real_time_location = @RealTimeLocation,
        location_id = @LocationId,
        location_name = @LocationName,
        vehicle_category_id = @VehicleCategoryId,
        category_name = @CategoryName,
        fuel_id = @FuelId,
        fuel_name = @FuelName,
        transmission_id = @TransmissionId,
        transmission_name = @TransmissionName,
        metadata = @Metadata,
        updated_at = @UpdatedAt,
        updated_by = @UpdatedBy";

    protected override object CreateParameters(VehicleUpdatedEvent msg)
    {
        return new
        {
            msg.Id,
            msg.NumberPlate,
            msg.Manufacturer,
            msg.Model,
            msg.Color,
            msg.Mileage,
            msg.PricePerHour,
            msg.Thumbnail,
            msg.Description,
            msg.LastCheckoutAt,
            msg.Rating,
            msg.Status,
            msg.ConditionNotes,
            msg.RealTimeLocation,
            msg.LocationId,
            msg.LocationName,
            msg.VehicleCategoryId,
            msg.CategoryName,
            msg.FuelId,
            msg.FuelName,
            msg.TransmissionId,
            msg.TransmissionName,
            msg.Metadata,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}