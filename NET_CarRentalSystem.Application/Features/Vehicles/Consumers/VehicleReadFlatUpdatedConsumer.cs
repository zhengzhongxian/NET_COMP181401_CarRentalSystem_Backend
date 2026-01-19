using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Models.Search;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatUpdatedConsumer(
    ILogger<VehicleReadFlatUpdatedConsumer> logger,
    IDapperRepository dapperRepository,
    IVehicleSearchService vehicleSearchService) : IConsumer<VehicleUpdatedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    private const string UpdateSetClause = """
                                                 manufacturer = @Manufacturer,
                                                 model = @Model,
                                                 color = @Color,
                                                 price_per_hour = @PricePerHour,
                                                 thumbnail = @Thumbnail,
                                                 description = @Description,
                                                 rating = @Rating,
                                                 vehicle_category_id = @VehicleCategoryId,
                                                 category_name = @CategoryName,
                                                 fuel_id = @FuelId,
                                                 fuel_name = @FuelName,
                                                 transmission_id = @TransmissionId,
                                                 transmission_name = @TransmissionName,
                                                 metadata = @Metadata,
                                                 updated_at = @UpdatedAt,
                                                 updated_by = @UpdatedBy
                                           """;

    public async Task Consume(ConsumeContext<VehicleUpdatedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation(
            "[VehicleUpdatedEvent] Starting update process in {Table} with ID: {Id}...",
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
            msg.Metadata,
            msg.UpdatedAt,
            msg.UpdatedBy
        };

        await dapperRepository.ExecuteAsync(sql, param, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleUpdatedEvent] Successfully updated in {Table}: {Id} at {UpdatedAt} by {UpdatedBy}",
            TableName,
            msg.Id,
            msg.UpdatedAt,
            msg.UpdatedBy ?? "System"
        );

        // 2. Update in Redis for FTS
        try
        {
            // Fetch current available_count, images_json, vehicle_models_json, attributes_json from DB
            // since VehicleUpdatedEvent may not have all fields
            var selectSql = """
                            SELECT available_count, images_json, vehicle_models_json, attributes_json, is_deleted, created_at
                            FROM vehicle_read_flat
                            WHERE vehicle_id = @Id
                            """;
            
            var existingData = await dapperRepository.QueryFirstOrDefaultAsync<dynamic>(selectSql, new { msg.Id }, cancellationToken: ct);

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
                AvailableCount = existingData?.available_count ?? 0,
                VehicleCategoryId = msg.VehicleCategoryId,
                CategoryName = msg.CategoryName,
                FuelId = msg.FuelId,
                FuelName = msg.FuelName,
                TransmissionId = msg.TransmissionId,
                TransmissionName = msg.TransmissionName,
                VehicleModelsJson = existingData?.vehicle_models_json,
                ImagesJson = existingData?.images_json,
                AttributesJson = existingData?.attributes_json,
                Metadata = msg.Metadata,
                IsDeleted = existingData?.is_deleted ?? false,
                CreatedAt = existingData?.created_at ?? DateTime.UtcNow,
                UpdatedAt = msg.UpdatedAt
            };

            await vehicleSearchService.IndexVehicleAsync(searchDoc, ct);
            logger.LogInformation("[VehicleUpdatedEvent] Updated vehicle {Id} in Redis", msg.Id);
        }
        catch (Exception ex)
        {
            // Log error but don't fail the message - Redis is secondary storage
            logger.LogWarning(ex, "[VehicleUpdatedEvent] Failed to update vehicle {Id} in Redis", msg.Id);
        }
    }
}