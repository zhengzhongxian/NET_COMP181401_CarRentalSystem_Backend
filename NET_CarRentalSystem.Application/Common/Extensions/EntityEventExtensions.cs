using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Application.Common.Extensions;

public static class EntityEventExtensions
{
    public static T ToEvent<T>(this IAuditable entity, Func<T> eventFactory) where T : IAuditableEvent
    {
        var evt = eventFactory();
        
        var type = typeof(T);
        
        type.GetProperty(nameof(IAuditableEvent.CreatedAt))
            ?.SetValue(evt, entity.CreatedAt!.Value);
        type.GetProperty(nameof(IAuditableEvent.CreatedBy))
            ?.SetValue(evt, entity.CreatedBy);
        type.GetProperty(nameof(IAuditableEvent.UpdatedAt))
            ?.SetValue(evt, entity.UpdatedAt!.Value);
        type.GetProperty(nameof(IAuditableEvent.UpdatedBy))
            ?.SetValue(evt, entity.UpdatedBy);
        
        return evt;
    }
    
    public static TEvent ToCreatedEvent<TEntity, TEvent, TKey>(
        this TEntity entity, 
        Func<TEntity, TEvent> eventFactory) 
        where TEntity : BaseEntity<TKey>
        where TEvent : EntityCreatedEvent<TKey>
    {
        var evt = eventFactory(entity);
        return evt with
        {
            Id = entity.Id,
            CreatedAt = entity.CreatedAt!.Value,
            CreatedBy = entity.CreatedBy,
            UpdatedAt = entity.UpdatedAt!.Value,
            UpdatedBy = entity.UpdatedBy
        };
    }

    public static TEvent ToUpdatedEvent<TEntity, TEvent, TKey>(
        this TEntity entity,
        Func<TEntity, TEvent> eventFactory)
        where TEntity : BaseEntity<TKey> 
        where TEvent : EntityUpdatedEvent<TKey>
    {
        var evt = eventFactory(entity);
        return evt with
        {
            Id = entity.Id,
            CreatedAt = entity.CreatedAt!.Value,
            CreatedBy = entity.CreatedBy,
            UpdatedAt = entity.UpdatedAt!.Value,
            UpdatedBy = entity.UpdatedBy
        };
    }
    
    public static TEvent ToDeletedEvent<TEntity, TEvent, TKey>(
        this TEntity entity,
        Func<TEntity, TEvent> eventFactory)
        where TEntity : BaseEntity<TKey>
        where TEvent : EntityDeletedEvent<TKey>
    {
        var evt = eventFactory(entity);
        return evt with
        {
            Id = entity.Id,
            DeletedAt = entity.DeletedAt!.Value,
            DeletedBy = entity.DeletedBy
        };
    }
}