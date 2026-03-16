namespace NET_CarRentalSystem.API.Models.Response.Dashboard;

public class PaymentMethodStatisticResponse
{
    public string PaymentMethod { get; set; } = string.Empty;
    
    public int Count { get; set; }
    
    public decimal Percentage { get; set; }
}
