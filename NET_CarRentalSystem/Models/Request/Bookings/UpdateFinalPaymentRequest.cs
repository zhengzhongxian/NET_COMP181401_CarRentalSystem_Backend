namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class UpdateFinalPaymentRequest
{
    public int MileageStart { get; set; }
    
    public decimal FuelPrice { get; set; }
    
    public string ConditionNotes { get; set; } = default!;
    
    public List<IFormFile>? Images { get; set; }
    
    public int FuelLevelStart { get; set; }
}