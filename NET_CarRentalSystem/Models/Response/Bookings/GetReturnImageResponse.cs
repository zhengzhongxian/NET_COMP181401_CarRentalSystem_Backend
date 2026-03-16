namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class GetReturnImageResponse
{
    public Guid Id { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public string? PublicId { get; set; }
    
    public int DisplayOrder { get; set; }
}

