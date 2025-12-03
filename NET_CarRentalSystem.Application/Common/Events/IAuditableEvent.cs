namespace NET_CarRentalSystem.Application.Common.Events;

public interface IAuditableEvent
{
    DateTime CreatedAt { get; init; }
    
    string? CreatedBy { get; init; }
    
    DateTime UpdatedAt { get; init; }
    
    string? UpdatedBy { get; init; }
}