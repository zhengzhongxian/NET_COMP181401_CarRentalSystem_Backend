namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class TopRentedVehicleResponse
{
    public Guid VehicleId { get; set; }
    
    public string Manufacturer { get; set; } = string.Empty;
    
    public string Model { get; set; } = string.Empty;
    
    public string? Thumbnail { get; set; }
    
    public string? CategoryName { get; set; }
    
    public decimal PricePerHour { get; set; }
    
    public float Rating { get; set; }
    
    public int BookingCount { get; set; }
}
