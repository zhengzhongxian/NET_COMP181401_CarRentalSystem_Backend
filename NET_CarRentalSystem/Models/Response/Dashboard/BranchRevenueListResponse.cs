namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class BranchRevenueListResponse
{
    public List<BranchRevenueResponse> Data { get; set; } = [];
    public int TotalBranches { get; set; }
}

public class BranchRevenueResponse
{
    public Guid BranchId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
    public decimal Revenue { get; set; }
}
