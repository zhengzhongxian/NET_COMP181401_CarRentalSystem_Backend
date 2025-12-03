using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Consumers;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatCreatedConsumer(
    ILogger<VehicleReadFlatCreatedConsumer> logger,
    IDapperRepository dapperRepository) : EntityCreatedConsumerBase<VehicleCreatedEvent, Guid>(logger, dapperRepository)
{
    protected override string TableName => "vehicle_read_flat";

    protected override string InsertColumns => """

                                                       vehicle_id, number_plate, manufacturer, model, color, mileage, 
                                                       price_per_hour, thumbnail, description, last_checkout_at, rating, 
                                                       status, condition_notes, real_time_location, location_id, location_name,
                                                       vehicle_category_id, category_name, fuel_id, fuel_name, 
                                                       transmission_id, transmission_name, images_json, attributes_json, 
                                                       metadata, created_at, created_by, updated_at, updated_by, is_deleted
                                               """;

    protected override string InsertValues => """

                                                      @Id, @NumberPlate, @Manufacturer, @Model, @Color, @Mileage,
                                                      @PricePerHour, @Thumbnail, @Description, @LastCheckoutAt, @Rating,
                                                      @Status, @ConditionNotes, @RealTimeLocation, @LocationId, @LocationName,
                                                      @VehicleCategoryId, @CategoryName, @FuelId, @FuelName,
                                                      @TransmissionId, @TransmissionName, @ImagesJson, @AttributesJson,
                                                      @Metadata, @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, 0
                                              """;

    protected override object CreateParameters(VehicleCreatedEvent msg)
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
            msg.ImagesJson,
            msg.AttributesJson,
            msg.Metadata,
            msg.CreatedAt,
            msg.CreatedBy,
            msg.UpdatedAt,
            msg.UpdatedBy
        };
    }
}