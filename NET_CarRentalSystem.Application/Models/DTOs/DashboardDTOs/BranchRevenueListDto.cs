namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class BranchRevenueListDto
{
    public List<BranchRevenueDto> Data { get; set; } = [];
    public int TotalBranches { get; set; }
}

public class BranchRevenueDto
{
    public Guid BranchId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}
