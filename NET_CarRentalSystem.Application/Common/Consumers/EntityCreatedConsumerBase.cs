using MassTransit;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Common.Consumers;

public abstract class EntityCreatedConsumerBase<TEvent, TKey>(
    ILogger logger,
    IDapperRepository dapperRepository) : IConsumer<TEvent>
    where TEvent : class, IEntityEvent<TKey>
{
    protected abstract string TableName { get; }
    protected abstract string InsertColumns { get; }
    protected abstract string InsertValues { get; }
    protected abstract object CreateParameters(TEvent message);

    public async Task Consume(ConsumeContext<TEvent> context)
    {
        var msg = context.Message;
        var eventType = typeof(TEvent).Name;

        logger.LogInformation(
            "[{EventType}] Starting creation process in {Table} with ID: {Id}...",
            eventType,
            TableName,
            msg.Id
        );
        var sql = $"""

                               INSERT INTO {TableName} ({InsertColumns})
                               VALUES ({InsertValues})
                   """;

        var param = CreateParameters(msg);

        await dapperRepository.ExecuteAsync(
            sql,
            param,
            cancellationToken: context.CancellationToken
        );

        logger.LogInformation(
            "[{EventType}] Successfully created in {Table}: {Id} at {CreatedAt} by {CreatedBy}",
            eventType,
            TableName,
            msg.Id,
            msg.CreatedAt,
            msg.CreatedBy ?? "System"
        );
    }
}