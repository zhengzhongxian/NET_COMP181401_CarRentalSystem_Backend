namespace NET_CarRentalSystem.Application.Common.Events;

public abstract record EntityDeletedEvent<TKey>
{
    public required TKey? Id { get; init; }
    
    public required DateTime DeletedAt { get; init; }
    
    public required string? DeletedBy { get; init; }
}