using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.TermsDTOs;

public class TermsAndConditionsDto
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = default!;
    
    public string Content { get; set; } = default!;
    
    public string Version { get; set; } = default!;
    
    public DateTime EffectiveDate { get; set; }
    
    public TermsType Type { get; set; }
}

