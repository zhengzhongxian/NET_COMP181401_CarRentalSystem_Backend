using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Consumers;

public class VehicleReadFlatDeletedConsumer(
    ILogger<VehicleReadFlatDeletedConsumer> logger,
    IDapperRepository dapperRepository) : IConsumer<VehicleDeletedEvent>
{
    private const string TableName = "vehicle_read_flat";
    private const string IdColumn = "vehicle_id";

    public async Task Consume(ConsumeContext<VehicleDeletedEvent> context)
    {
        var msg = context.Message;
        var ct = context.CancellationToken;

        if (msg.Id == Guid.Empty)
        {
            logger.LogWarning("[VehicleDeletedEvent] Received event with null or empty Id, skipping");
            return;
        }

        var vehicleId = msg.Id;

        logger.LogInformation(
            "[VehicleDeletedEvent] Starting HARD DELETE from {Table} with ID: {Id}...",
            TableName, vehicleId);

        var sql = $"DELETE FROM {TableName} WHERE {IdColumn} = @Id";
        await dapperRepository.ExecuteAsync(sql, new { Id = vehicleId }, cancellationToken: ct);

        logger.LogInformation(
            "[VehicleDeletedEvent] Successfully deleted from {Table}: {Id} at {DeletedAt} by {DeletedBy}",
            TableName, vehicleId, msg.DeletedAt, msg.DeletedBy ?? "System");
    }
}