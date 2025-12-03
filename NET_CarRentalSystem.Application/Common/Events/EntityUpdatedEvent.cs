namespace NET_CarRentalSystem.Application.Common.Events;

public abstract record EntityUpdatedEvent<TKey> : IEntityEvent<TKey>
{
    public required TKey Id { get; init; }
    
    public required DateTime CreatedAt { get; init; }
    
    public required string? CreatedBy { get; init; }
    
    public required DateTime UpdatedAt { get; init; }
    
    public required string? UpdatedBy { get; init; }
}