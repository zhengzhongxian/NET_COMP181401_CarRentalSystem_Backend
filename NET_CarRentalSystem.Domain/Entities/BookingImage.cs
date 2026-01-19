using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class BookingImage : BaseEntity<Guid>
{
    public Guid BookingId { get; set; }
    
    public string ImageUrl { get; set; } = default!;
    
    public string PublicId { get; set; } = default!;
    
    public string? Description { get; set; }
    
    public int DisplayOrder { get; set; }
    
    public Booking? Booking { get; set; }
}
