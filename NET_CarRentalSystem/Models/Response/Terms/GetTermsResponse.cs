using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.API.Models.Response.Terms;

public class GetTermsResponse
{
    public Guid Id { get; set; }
    
    public string Title { get; set; } = default!;
    
    public string Content { get; set; } = default!;
    
    public string Version { get; set; } = default!;
    
    public DateTime EffectiveDate { get; set; }
    
    public TermsType Type { get; set; }
}

