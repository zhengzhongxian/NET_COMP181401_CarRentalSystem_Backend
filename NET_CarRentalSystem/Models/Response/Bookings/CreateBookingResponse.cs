namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class CreateBookingResponse
{
    public Guid BookingId { get; set; }
    
    public Guid TransactionId { get; set; }
    
    public string TransactionCode { get; set; } = default!;
    
    public string Status { get; set; } = default!;
    
    public decimal AmountToPay { get; set; }
    
    public string PaymentMethod { get; set; } = default!;
    
    public string? PaymentUrl { get; set; }
    
    public string? QrCode { get; set; }
    
    public DateTime ExpireDate { get; set; }
    
    public string TransactionType { get; set; } = default!;
}
