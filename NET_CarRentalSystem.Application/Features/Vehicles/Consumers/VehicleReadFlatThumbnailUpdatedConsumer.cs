using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatThumbnailUpdatedConsumer(
    ILogger<VehicleReadFlatThumbnailUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<VehicleThumbnailUpdatedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    private const string UpdateSetClause = """
                                                 thumbnail = @Thumbnail,
                                                 updated_at = @UpdatedAt,
                                                 updated_by = @UpdatedBy
                                           """;

    public async Task Consume(ConsumeContext<VehicleThumbnailUpdatedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation(
            "[VehicleThumbnailUpdatedEvent] Starting update process in {Table} with ID: {Id}...",
            TableName, msg.Id);

        var sql = $"""
                   UPDATE {TableName}
                   SET {UpdateSetClause}
                   WHERE {IdColumn} = @Id
                   """;

        var param = new
        {
            msg.Id,
            msg.Thumbnail,
            msg.UpdatedAt,
            msg.UpdatedBy
        };

        await dapperRepository.ExecuteAsync(sql, param, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleThumbnailUpdatedEvent] Successfully updated in {Table}: {Id} at {UpdatedAt}",
            TableName, msg.Id, msg.UpdatedAt);
    }
}