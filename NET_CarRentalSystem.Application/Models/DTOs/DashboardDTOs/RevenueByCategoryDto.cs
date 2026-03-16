namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class RevenueByCategoryDto
{
    public int Year { get; set; }
    
    public int Month { get; set; }
    
    public string MonthLabel { get; set; } = string.Empty;
    
    public string CategoryName { get; set; } = string.Empty;
    
    public decimal Revenue { get; set; }
}
