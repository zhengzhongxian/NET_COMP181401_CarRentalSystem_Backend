using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Bookings;

public class GenerateQrReturnVehicleRequest
{
    [Required]
    public Guid LocationId { get; set; } = default!;
}

