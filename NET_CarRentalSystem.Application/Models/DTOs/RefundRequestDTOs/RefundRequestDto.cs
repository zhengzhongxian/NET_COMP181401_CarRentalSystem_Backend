using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.RefundRequestDTOs;

public class RefundRequestDto
{
    public Guid Id { get; set; }
    
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public string? CustomerPhone { get; set; }
    
    public string? VehicleName { get; set; }
    
    public decimal Amount { get; set; }
    
    public RefundStatus Status { get; set; }
    
    public string? Reason { get; set; }
    
    public string? AdminNotes { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    
    public DateTime? ApprovedAt { get; set; }
    
    public DateTime? ProcessedAt { get; set; }
}

