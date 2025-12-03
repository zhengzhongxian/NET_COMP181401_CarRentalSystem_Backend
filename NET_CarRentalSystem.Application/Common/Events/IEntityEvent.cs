namespace NET_CarRentalSystem.Application.Common.Events;

public interface IEntityEvent<TKey> : IAuditableEvent
{
    TKey Id { get; init; }
}