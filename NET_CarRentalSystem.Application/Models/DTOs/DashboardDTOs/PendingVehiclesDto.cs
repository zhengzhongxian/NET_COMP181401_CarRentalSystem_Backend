namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class PendingVehiclesDto
{
    public int Count { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
