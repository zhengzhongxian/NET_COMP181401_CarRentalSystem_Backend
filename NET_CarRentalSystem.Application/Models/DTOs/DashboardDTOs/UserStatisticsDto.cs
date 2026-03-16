namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class UserStatisticsDto
{
    public int TotalUsers { get; set; }
    
    public int CurrentPeriodUsers { get; set; }
    
    public int PreviousPeriodUsers { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
