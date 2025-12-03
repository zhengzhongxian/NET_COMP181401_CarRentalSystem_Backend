using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Common.Consumers;

public abstract class EntityDeletedConsumerBase<TEvent, TKey>(
    ILogger logger,
    IDapperRepository dapperRepository) : IConsumer<TEvent>
    where TEvent : EntityDeletedEvent<TKey>
{
    protected abstract string TableName { get; }
    protected abstract string IdColumn { get; }

    public async Task Consume(ConsumeContext<TEvent> context)
    {
        var msg = context.Message;
        var eventType = typeof(TEvent).Name;
        
        logger.LogInformation(
            "[{EventType}] Starting HARD DELETE process from {Table} with ID: {Id}...",
            eventType,
            TableName,
            msg.Id
        );
        
        var sql = $"DELETE FROM {TableName} WHERE {IdColumn} = @Id";

        var param = new { msg.Id };

        await dapperRepository.ExecuteAsync(
            sql,
            param,
            cancellationToken: context.CancellationToken
        );

        logger.LogInformation(
            "[{EventType}] Successfully HARD DELETED from {Table}: {Id} at {DeletedAt}",
            eventType,
            TableName,
            msg.Id,
            DateTime.UtcNow
        );
    }
}