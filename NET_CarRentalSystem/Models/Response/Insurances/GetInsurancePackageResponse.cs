namespace NET_CarRentalSystem.API.Models.Response.Insurances;

public class GetInsurancePackageResponse
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = default!;
    
    public string Description { get; set; } = default!;
    
    public decimal Price { get; set; }
    
    public decimal CoverageAmount { get; set; }
    
    public string CoverageDetails { get; set; } = default!;
}

