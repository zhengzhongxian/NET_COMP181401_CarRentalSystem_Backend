namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class GetBookingResponse
{
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public string? CustomerPhone { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public decimal VehiclePricePerHour { get; set; }
    
    public string? VehicleName { get; set; }

    public Guid VehicleModelId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? PickupLocationName { get; set; }

    public string? ReturnLocationName { get; set; }

    public string? FileName { get; set; }
    
    public string? Status { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public decimal DepositRatio { get; set; }
    
    public decimal DiscountRate { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}
