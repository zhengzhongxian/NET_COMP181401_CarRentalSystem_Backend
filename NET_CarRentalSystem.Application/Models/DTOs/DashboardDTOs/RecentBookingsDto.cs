namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class RecentBookingsDto
{
    public int Hours { get; set; }
    
    public int CurrentCount { get; set; }
    
    public int PreviousCount { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
