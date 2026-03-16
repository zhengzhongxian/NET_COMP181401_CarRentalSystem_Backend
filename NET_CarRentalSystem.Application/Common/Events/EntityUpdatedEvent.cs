namespace NET_CarRentalSystem.Application.Common.Events;

public abstract record EntityUpdatedEvent<TKey> : IEntityEvent<TKey>
{
    public required TKey Id { get; init; }
    
    public DateTime? CreatedAt { get; set; }
    
    public string? CreatedBy { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
    
    public string? UpdatedBy { get; set; }
}