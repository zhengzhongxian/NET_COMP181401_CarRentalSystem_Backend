using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class TermsAndConditions : BaseEntity<Guid>
{
    public string Title { get; set; } = default!;
    
    public string Content { get; set; } = default!;
    
    public string Version { get; set; } = default!;
    
    public DateTime EffectiveDate { get; set; }
    
    public bool IsActive { get; set; } = true;
    
    public TermsType Type { get; set; }
}

