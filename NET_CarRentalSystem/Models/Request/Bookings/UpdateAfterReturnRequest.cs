using Microsoft.AspNetCore.Http;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class UpdateAfterReturnRequest
{
    public Guid BookingId { get; set; }

    public int MileageEnd { get; set; }

    public int FuelLevelEnd { get; set; }

    public decimal FuelPrice { get; set; }

    public string? VehicleDamageNotes { get; set; }
    
    public List<IFormFile>? ReturnImages { get; set; }
}
