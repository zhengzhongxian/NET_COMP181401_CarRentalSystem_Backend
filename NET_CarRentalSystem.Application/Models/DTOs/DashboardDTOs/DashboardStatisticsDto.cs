namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class DashboardStatisticsDto
{
    public LocationStatisticDto? TopRevenueLocation { get; set; }
    
    public LocationStatisticDto? HighestPerformanceLocation { get; set; }
    
    public LocationStatisticDto? LowestRevenueLocation { get; set; }
    
    public int TotalLocations { get; set; }
}

public class LocationStatisticDto
{
    public string LocationName { get; set; } = string.Empty;
    
    public decimal Value { get; set; }
    
    public string Description { get; set; } = string.Empty;
}
