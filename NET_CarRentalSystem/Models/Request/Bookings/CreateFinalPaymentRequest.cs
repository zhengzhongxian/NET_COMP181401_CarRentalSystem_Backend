namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class CreateFinalPaymentRequest
{
    public int MileageStart { get; set; } = default!;

    public decimal FuelPrice { get; set; } = default!;
    
    public string ConditionNotes { get; set; } = default!;

    public int FuelLevelStart { get; set; } = default!;

    public List<IFormFile>? Images { get; set; } = default!;
}

