using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatImagesUpdatedConsumer(
    ILogger<VehicleReadFlatImagesUpdatedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<VehicleImagesUpdatedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    private const string UpdateSetClause = """
                                                 images_json = @ImagesJson,
                                                 updated_at = @UpdatedAt,
                                                 updated_by = @UpdatedBy
                                           """;

    public async Task Consume(ConsumeContext<VehicleImagesUpdatedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        logger.LogInformation(
            "[VehicleImagesUpdatedEvent] Starting update process in {Table} with ID: {Id}...",
            TableName, msg.Id);

        var sql = $"""
                   UPDATE {TableName}
                   SET {UpdateSetClause}
                   WHERE {IdColumn} = @Id
                   """;

        var param = new
        {
            msg.Id,
            msg.ImagesJson,
            msg.UpdatedAt,
            msg.UpdatedBy
        };

        await dapperRepository.ExecuteAsync(sql, param, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleImagesUpdatedEvent] Successfully updated in {Table}: {Id} at {UpdatedAt}",
            TableName, msg.Id, msg.UpdatedAt);
    }
}