namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class RecentBookingsResponse
{
    public int Hours { get; set; }
    
    public int CurrentCount { get; set; }
    
    public int PreviousCount { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
