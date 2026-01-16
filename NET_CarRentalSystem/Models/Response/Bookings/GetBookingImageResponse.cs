namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class GetBookingImageResponse
{
    public Guid Id { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public string? PublicId { get; set; }
    
    public DateTime CreatedAt { get; set; }
}

