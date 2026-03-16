namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class RevenueSummaryDto
{
    public DateTime FromDate { get; set; }
    
    public DateTime ToDate { get; set; }
    
    public decimal TotalDeposit { get; set; }
    
    public decimal TotalFinalPayment { get; set; }
    
    public decimal TotalRefund { get; set; }
    
    public decimal NetRevenue { get; set; }
    
    public int TotalTransactionCount { get; set; }
    
    public int TotalRefundCount { get; set; }
}
