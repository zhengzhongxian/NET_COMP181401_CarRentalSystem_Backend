using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class VehicleReturnImage : BaseEntity<Guid>
{
    public Guid BookingId { get; set; }
    
    public string ImageUrl { get; set; } = default!;
    
    public string? PublicId { get; set; }
    
    public int DisplayOrder { get; set; }
    
    public string? Description { get; set; }
    
    public virtual Booking Booking { get; set; } = default!;
}

