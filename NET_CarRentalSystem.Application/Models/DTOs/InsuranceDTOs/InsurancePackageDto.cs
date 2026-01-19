namespace NET_CarRentalSystem.Application.Models.DTOs.InsuranceDTOs;

public class InsurancePackageDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public decimal CoverageAmount { get; set; }
    public string CoverageDetails { get; set; } = default!;
}

