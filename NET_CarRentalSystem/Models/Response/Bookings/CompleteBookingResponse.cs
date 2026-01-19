namespace NET_CarRentalSystem.API.Models.Response.Bookings;

public class CompleteBookingResponse
{
    public bool Success { get; set; }
    
    public string Message { get; set; } = default!;
    
    public int LoyaltyPointsAwarded { get; set; }
    
    public int TotalLoyaltyPoints { get; set; }
}

