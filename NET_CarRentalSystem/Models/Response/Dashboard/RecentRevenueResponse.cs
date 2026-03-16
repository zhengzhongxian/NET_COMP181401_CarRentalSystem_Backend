namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class RecentRevenueResponse
{
    public int Hours { get; set; }
    
    public decimal CurrentRevenue { get; set; }
    
    public decimal PreviousRevenue { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
