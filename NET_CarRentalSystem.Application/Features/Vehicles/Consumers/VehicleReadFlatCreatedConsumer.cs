using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatCreatedConsumer(
    ILogger<VehicleReadFlatCreatedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<VehicleCreatedEvent>
{
    private const string TableName = "vehicle_read_flat";

    private const string InsertColumns = """
                                               vehicle_id, manufacturer, model, title, color, 
                                               price_per_hour, thumbnail, description, rating, available_count,
                                               vehicle_category_id, category_name, fuel_id, fuel_name, 
                                               transmission_id, transmission_name, vehicle_models_json, 
                                               images_json, attributes_json, metadata, required_license_class,
                                               created_at, created_by, updated_at, updated_by, is_deleted
                                         """;

    private const string InsertValues = """
                                              @Id, @Manufacturer, @Model, @Title, @Color,
                                              @PricePerHour, @Thumbnail, @Description, @Rating, 0,
                                              @VehicleCategoryId, @CategoryName, @FuelId, @FuelName,
                                              @TransmissionId, @TransmissionName, @VehicleModelsJson,
                                              @ImagesJson, @AttributesJson, @Metadata, @RequiredLicenseClass,
                                              @CreatedAt, @CreatedBy, @UpdatedAt, @UpdatedBy, 0
                                        """;

    public async Task Consume(ConsumeContext<VehicleCreatedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation(
            "[VehicleCreatedEvent] Starting creation process in {Table} with ID: {Id}...",
            TableName,
            msg.Id
        );

        var sql = $"""
                   INSERT INTO {TableName} ({InsertColumns})
                   VALUES ({InsertValues})
                   """;

        var param = new
        {
            msg.Id,
            msg.Manufacturer,
            msg.Model,
            msg.Title,
            msg.Color,
            msg.PricePerHour,
            msg.Thumbnail,
            msg.Description,
            msg.Rating,
            msg.VehicleCategoryId,
            msg.CategoryName,
            msg.FuelId,
            msg.FuelName,
            msg.TransmissionId,
            msg.TransmissionName,
            msg.VehicleModelsJson,
            msg.ImagesJson,
            msg.AttributesJson,
            msg.Metadata,
            msg.RequiredLicenseClass,
            msg.CreatedAt,
            msg.CreatedBy,
            msg.UpdatedAt,
            msg.UpdatedBy
        };

        await dapperRepository.ExecuteAsync(sql, param, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleCreatedEvent] Successfully created in {Table}: {Id} at {CreatedAt} by {CreatedBy}",
            TableName,
            msg.Id,
            msg.CreatedAt,
            msg.CreatedBy ?? "System"
        );
    }
}