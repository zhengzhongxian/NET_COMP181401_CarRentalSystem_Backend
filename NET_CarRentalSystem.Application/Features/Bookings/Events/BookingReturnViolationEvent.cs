using System;

namespace NET_CarRentalSystem.Application.Features.Bookings.Events;

public record BookingReturnViolationEvent
{
    public Guid BookingId { get; init; }
    
    public Guid CustomerId { get; init; }
    
    public string CustomerName { get; init; } = string.Empty;
    
    public string? CustomerEmail { get; init; }
    
    public string ViolationDetailsHtml { get; init; } = string.Empty;
    
    public int ViolationCount { get; init; }
    
    public decimal TotalAmount { get; init; }
    
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}

