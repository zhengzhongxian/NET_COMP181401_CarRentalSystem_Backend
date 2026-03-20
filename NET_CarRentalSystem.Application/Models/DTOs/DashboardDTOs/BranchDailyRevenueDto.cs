namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class BranchDailyRevenueDto
{
    public string BranchName { get; set; } = string.Empty;
    public List<BranchDailyRevenueDataDto> Data { get; set; } = [];
    public BranchRevenueSummaryDto Summary { get; set; } = new();
}

public class BranchDailyRevenueDataDto
{
    public string Date { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}

public class BranchRevenueSummaryDto
{
    public decimal TotalRevenue { get; set; }
    public decimal AvgRevenuePerDay { get; set; }
    public decimal MaxRevenue { get; set; }
}
