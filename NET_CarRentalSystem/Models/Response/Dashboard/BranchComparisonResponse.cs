namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class BranchComparisonResponse
{
    public List<BranchInfoResponse> Branches { get; set; } = [];
    public List<BranchCriteriaResponse> Criteria { get; set; } = [];
    public decimal MaxValue { get; set; }
}

public class BranchInfoResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ShortName { get; set; } = string.Empty;
}

public class BranchCriteriaResponse
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, decimal> Values { get; set; } = [];
}
