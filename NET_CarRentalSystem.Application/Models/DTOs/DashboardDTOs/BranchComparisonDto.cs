namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class BranchComparisonDto
{
    public List<BranchInfoDto> Branches { get; set; } = [];
    public List<BranchCriteriaDto> Criteria { get; set; } = [];
    public decimal MaxValue { get; set; }
}

public class BranchInfoDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
}

public class BranchCriteriaDto
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, decimal> Values { get; set; } = [];
}
