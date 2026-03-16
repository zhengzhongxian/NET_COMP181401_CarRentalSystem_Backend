using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class BookingInsurance : BaseEntity<Guid>
{
    public Guid BookingId { get; set; }
    
    public Guid InsurancePackageId { get; set; }
    
    public decimal Price { get; set; }
    
    public virtual Booking Booking { get; set; } = default!;
    
    public virtual InsurancePackage? InsurancePackage { get; set; }
}

