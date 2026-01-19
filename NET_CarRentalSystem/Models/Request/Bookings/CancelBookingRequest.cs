namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class CancelBookingRequest
{
    public required string CancellationReason { get; set; }
}

