namespace NET_CarRentalSystem.Application.Common.Events;

public abstract record EntityDeletedEvent<TKey>
{
    public TKey? Id { get; init; }
    
    public DateTime DeletedAt { get; init; }
    
    public string? DeletedBy { get; init; }
}