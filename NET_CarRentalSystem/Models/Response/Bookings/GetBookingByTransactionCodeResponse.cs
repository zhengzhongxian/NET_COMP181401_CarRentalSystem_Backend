namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class GetBookingByTransactionCodeResponse
{
    public Guid BookingId { get; set; }
    
    public long TransactionCode { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public Guid VehicleModelId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? PickupLocationName { get; set; }
    
    public string? ReturnLocationName { get; set; }
    
    public string? Status { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public decimal Amount { get; set; }
    
    public string? PaymentMethod { get; set; }
    
    public string? TransactionStatus { get; set; }
    
    public DateTime PaymentDate { get; set; }
}

