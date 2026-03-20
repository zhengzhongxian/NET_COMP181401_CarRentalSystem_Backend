namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class BranchDailyRevenueResponse
{
    public string BranchName { get; set; } = string.Empty;
    public List<BranchDailyRevenueDataResponse> Data { get; set; } = [];
    public BranchRevenueSummaryResponse Summary { get; set; } = new();
}

public class BranchDailyRevenueDataResponse
{
    public string Date { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}

public class BranchRevenueSummaryResponse
{
    public decimal TotalRevenue { get; set; }
    public decimal AvgRevenuePerDay { get; set; }
    public decimal MaxRevenue { get; set; }
}
