namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class DashboardStatisticsResponse
{
    public LocationStatisticResponse? TopRevenueLocation { get; set; }
    
    public LocationStatisticResponse? HighestPerformanceLocation { get; set; }
    
    public LocationStatisticResponse? LowestRevenueLocation { get; set; }
    
    public int TotalLocations { get; set; }
}

public class LocationStatisticResponse
{
    public string LocationName { get; set; } = string.Empty;
    
    public decimal Value { get; set; }
    
    public string Description { get; set; } = string.Empty;
}
