namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class PendingVehiclesResponse
{
    public int Count { get; set; }
    
    public decimal PercentageChange { get; set; }
    
    public bool IsIncrease { get; set; }
}
