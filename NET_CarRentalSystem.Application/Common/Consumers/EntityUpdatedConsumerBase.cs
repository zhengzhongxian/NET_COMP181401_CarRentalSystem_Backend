using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Common.Consumers;

public abstract class EntityUpdatedConsumerBase<TEvent, TKey>(
    ILogger logger,
    IDapperRepository dapperRepository) : IConsumer<TEvent>
    where TEvent : class, IEntityEvent<TKey>
{
    protected abstract string TableName { get; }
    protected abstract string IdColumn { get; }
    protected abstract string UpdateSetClause { get; }
    protected abstract object CreateParameters(TEvent message);

    public async Task Consume(ConsumeContext<TEvent> context)
    {
        var msg = context.Message;
        var eventType = typeof(TEvent).Name;
        
        logger.LogInformation(
            "[{EventType}] Starting update process for {Table} with ID: {Id}...",
            eventType,
            TableName,
            msg.Id
        );
        
        var sql = $"""

                               UPDATE {TableName}
                               SET {UpdateSetClause}
                               WHERE {IdColumn} = @Id
                   """;

        var param = CreateParameters(msg);

        await dapperRepository.ExecuteAsync(
            sql,
            param,
            cancellationToken: context.CancellationToken
        );

        logger.LogInformation(
            "[{EventType}] Successfully updated entity in {Table}: {Id} at {UpdatedAt} by {UpdatedBy}",
            eventType,
            TableName,
            msg.Id,
            msg.UpdatedAt,
            msg.UpdatedBy ?? "System"
        );
    }
}