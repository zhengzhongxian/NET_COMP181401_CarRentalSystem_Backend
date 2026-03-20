namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class BranchOverviewStatsDto
{
    public decimal TotalRevenueToday { get; set; }
    public string TopRevenueBranch { get; set; } = string.Empty;
    public int ActiveVehicles { get; set; }
    public int TotalVehicles { get; set; }
    public string TopVehicleBranch { get; set; } = string.Empty;
    public int NewCustomersToday { get; set; }
    public string TopCustomerBranch { get; set; } = string.Empty;
    public int CompletedTrips { get; set; }
    public int TotalTrips { get; set; }
    public string TopCompletionBranch { get; set; } = string.Empty;
    public decimal TotalProfit { get; set; }
    public decimal ProfitMargin { get; set; }
    public string TopProfitBranch { get; set; } = string.Empty;
}
