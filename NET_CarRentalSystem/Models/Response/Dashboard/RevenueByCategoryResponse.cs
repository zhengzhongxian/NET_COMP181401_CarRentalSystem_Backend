namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class RevenueByCategoryResponse
{
    public int Year { get; set; }
    
    public int Month { get; set; }
    
    public string MonthLabel { get; set; } = string.Empty;
    
    public string CategoryName { get; set; } = string.Empty;
    
    public decimal Revenue { get; set; }
}
