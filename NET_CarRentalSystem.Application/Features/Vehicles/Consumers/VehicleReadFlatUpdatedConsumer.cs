using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatUpdatedConsumer(
    ILogger<VehicleReadFlatUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<VehicleUpdatedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    private const string UpdateSetClause = """
                                                 manufacturer = @Manufacturer,
                                                 model = @Model,
                                                 title = @Title,
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
                                                 required_license_class = @RequiredLicenseClass,
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
            msg.Metadata,
            msg.RequiredLicenseClass,
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
    }
}