using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatAttributesUpdatedConsumer(
    ILogger<VehicleReadFlatAttributesUpdatedConsumer> logger,
    IDapperRepository dapperRepository,
    IVehicleSearchService vehicleSearchService) : IConsumer<VehicleAttributesUpdatedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    private const string UpdateSetClause = """
                                                 attributes_json = @AttributesJson,
                                                 updated_at = @UpdatedAt,
                                                 updated_by = @UpdatedBy
                                           """;

    public async Task Consume(ConsumeContext<VehicleAttributesUpdatedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation(
            "[VehicleAttributesUpdatedEvent] Starting update process in {Table} with ID: {Id}...",
            TableName,
            msg.Id
        );

        // 1. Update in SQL Server
        var sql = $"""
                   UPDATE {TableName}
                   SET {UpdateSetClause}
                   WHERE {IdColumn} = @Id
                   """;

        var param = new
        {
            msg.Id,
            msg.AttributesJson,
            msg.UpdatedAt,
            msg.UpdatedBy
        };

        await dapperRepository.ExecuteAsync(sql, param, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleAttributesUpdatedEvent] Successfully updated in {Table}: {Id} at {UpdatedAt} by {UpdatedBy}",
            TableName,
            msg.Id,
            msg.UpdatedAt,
            msg.UpdatedBy ?? "System"
        );

        // 2. Update in Redis for FTS
        try
        {
            var selectSql = """
                            SELECT manufacturer, model, color, price_per_hour, thumbnail, description, rating,
                                   available_count, vehicle_category_id, category_name, fuel_id, fuel_name,
                                   transmission_id, transmission_name, vehicle_models_json, images_json,
                                   metadata, is_deleted, created_at
                            FROM vehicle_read_flat
                            WHERE vehicle_id = @Id
                            """;
            
            var existingData = await dapperRepository.QueryFirstOrDefaultAsync<dynamic>(selectSql, new { msg.Id }, cancellationToken: ct);

            if (existingData == null)
            {
                logger.LogWarning("[VehicleAttributesUpdatedEvent] Vehicle {Id} not found in DB, skipping Redis update", msg.Id);
                return;
            }

            var searchDoc = new VehicleSearchDocument
            {
                VehicleId = msg.Id,
                Manufacturer = existingData.manufacturer ?? string.Empty,
                Model = existingData.model ?? string.Empty,
                Color = existingData.color,
                PricePerHour = existingData.price_per_hour,
                Thumbnail = existingData.thumbnail,
                Description = existingData.description,
                Rating = existingData.rating,
                AvailableCount = existingData.available_count ?? 0,
                VehicleCategoryId = existingData.vehicle_category_id,
                CategoryName = existingData.category_name,
                FuelId = existingData.fuel_id,
                FuelName = existingData.fuel_name,
                TransmissionId = existingData.transmission_id,
                TransmissionName = existingData.transmission_name,
                VehicleModelsJson = existingData.vehicle_models_json,
                ImagesJson = existingData.images_json,
                AttributesJson = msg.AttributesJson,
                Metadata = existingData.metadata,
                IsDeleted = existingData.is_deleted ?? false,
                CreatedAt = existingData.created_at ?? DateTime.UtcNow,
                UpdatedAt = msg.UpdatedAt
            };

            await vehicleSearchService.IndexVehicleAsync(searchDoc, ct);
            logger.LogInformation("[VehicleAttributesUpdatedEvent] Updated vehicle {Id} in Redis", msg.Id);
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "[VehicleAttributesUpdatedEvent] Failed to update vehicle {Id} in Redis", msg.Id);
        }
    }
}
