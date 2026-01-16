namespace NET_CarRentalSystem.Application.Models.DTOs.BookingImageDTOs.Get;

public class GetBookingImageDto
{
    public Guid Id { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public string? PublicId { get; set; }
    
    public DateTime CreatedAt { get; set; }
}

