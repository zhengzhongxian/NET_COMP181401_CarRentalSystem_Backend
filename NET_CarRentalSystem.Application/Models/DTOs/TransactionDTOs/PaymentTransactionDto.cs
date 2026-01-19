using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.TransactionDTOs;

public class PaymentTransactionDto
{
    public Guid BookingId { get; set; }
    
    public long TransactionCode { get; set; }
    
    public Guid TransactionId { get; set; }
    
    public TransactionType TransactionType { get; set; }
    
    public TransactionStatus Status { get; set; }
    
    public decimal AmountToPay { get; set; }

    public PaymentMethod PaymentMethod { get; set; }
    
    public string? PaymentUrl { get; set; } 
    
    public string? QrCode { get; set; }
    
    public DateTime? ExpireDate { get; set; }
}