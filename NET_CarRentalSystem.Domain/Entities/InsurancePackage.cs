using NET_CarRentalSystem.Domain.Common;

namespace NET_CarRentalSystem.Domain.Entities;

public class InsurancePackage : BaseEntity<Guid>
{
    public string Name { get; set; } = default!;
    
    public string Description { get; set; } = default!;
    
    public decimal Price { get; set; }
    
    public decimal CoverageAmount { get; set; }
    
    public string CoverageDetails { get; set; } = default!;
    
    public bool IsActive { get; set; } = true;
    
    public int DisplayOrder { get; set; }
    
    public virtual ICollection<BookingInsurance> BookingInsurances { get; set; } = new List<BookingInsurance>();
}

