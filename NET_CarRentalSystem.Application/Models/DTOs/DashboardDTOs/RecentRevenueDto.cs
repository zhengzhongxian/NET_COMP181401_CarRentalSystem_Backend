namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

/// <summary>
/// DTO cho doanh thu trong khoảng thời gian gần đây
/// </summary>
public class RecentRevenueDto
{
    public int Hours { get; set; }
    
    public decimal CurrentRevenue { get; set; }
    
    public decimal PreviousRevenue { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
