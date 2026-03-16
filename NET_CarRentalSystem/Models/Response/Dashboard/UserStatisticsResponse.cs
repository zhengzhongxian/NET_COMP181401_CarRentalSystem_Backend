namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class UserStatisticsResponse
{
    public int TotalUsers { get; set; }
    
    public int CurrentPeriodUsers { get; set; }
    
    public int PreviousPeriodUsers { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
