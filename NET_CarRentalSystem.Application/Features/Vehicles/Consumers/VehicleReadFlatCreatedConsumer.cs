using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatCreatedConsumer(
    ILogger<VehicleReadFlatCreatedConsumer> logger,
    IDapperRepository dapperRepository,
    IVehicleSearchService vehicleSearchService) : IConsumer<VehicleCreatedEvent>
{
    private const string TableName = "vehicle_read_flat";

    private const string InsertColumns = """
                                               vehicle_id, manufacturer, model, color, 
                                               price_per_hour, thumbnail, description, rating, available_count,
                                               vehicle_category_id, category_name, fuel_id, fuel_name, 
                                               transmission_id, transmission_name, vehicle_models_json, 
                                               images_json, attributes_json, metadata, created_at, created_by, 
                                               updated_at, updated_by, is_deleted
                                         """;

    private const string InsertValues = """
                                              @Id, @Manufacturer, @Model, @Color,
                                              @PricePerHour, @Thumbnail, @Description, @Rating, 0,
                                              @VehicleCategoryId, @CategoryName, @FuelId, @FuelName,
                                              @TransmissionId, @TransmissionName, @VehicleModelsJson,
                                              @ImagesJson, @AttributesJson, @Metadata, @CreatedAt, @CreatedBy,
                                              @UpdatedAt, @UpdatedBy, 0
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

        // 1. Insert to SQL Server
        var sql = $"""
                   INSERT INTO {TableName} ({InsertColumns})
                   VALUES ({InsertValues})
                   """;

        var param = new
        {
            msg.Id,
            msg.Manufacturer,
            msg.Model,
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
        
        try
        {
            var searchDoc = new VehicleSearchDocument
            {
                VehicleId = msg.Id,
                Manufacturer = msg.Manufacturer,
                Model = msg.Model,
                Color = msg.Color,
                PricePerHour = msg.PricePerHour,
                Thumbnail = msg.Thumbnail,
                Description = msg.Description,
                Rating = msg.Rating,
                AvailableCount = 0,
                VehicleCategoryId = msg.VehicleCategoryId,
                CategoryName = msg.CategoryName,
                FuelId = msg.FuelId,
                FuelName = msg.FuelName,
                TransmissionId = msg.TransmissionId,
                TransmissionName = msg.TransmissionName,
                VehicleModelsJson = msg.VehicleModelsJson,
                ImagesJson = msg.ImagesJson,
                AttributesJson = msg.AttributesJson,
                Metadata = msg.Metadata,
                IsDeleted = false,
                CreatedAt = msg.CreatedAt,
                UpdatedAt = msg.UpdatedAt
            };

            await vehicleSearchService.IndexVehicleAsync(searchDoc, ct);
            logger.LogInformation("[VehicleCreatedEvent] Indexed vehicle {Id} to Redis", msg.Id);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "[VehicleCreatedEvent] Failed to index vehicle {Id} to Redis", msg.Id);
        }
    }
}