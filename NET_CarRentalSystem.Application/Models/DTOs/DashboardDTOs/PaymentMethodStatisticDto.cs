namespace NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

public class PaymentMethodStatisticDto
{
    public string PaymentMethod { get; set; } = string.Empty;
    
    public int Count { get; set; }
    
    public decimal Percentage { get; set; }
}
