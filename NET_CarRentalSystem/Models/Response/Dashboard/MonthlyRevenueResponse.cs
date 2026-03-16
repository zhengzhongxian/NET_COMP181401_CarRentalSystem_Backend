namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class MonthlyRevenueResponse
{
    public int Year { get; set; }
    
    public int Month { get; set; }
    
    public string MonthLabel { get; set; } = string.Empty;
    
    public decimal Revenue { get; set; }
}
