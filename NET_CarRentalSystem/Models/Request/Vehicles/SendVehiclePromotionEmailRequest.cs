using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.API.Models.Request.Vehicles;

public class SendVehiclePromotionEmailRequest
{
    [Required]
    public Guid VehicleId { get; set; }
    
    [Required]
    [MinLength(1, ErrorMessage = "Danh sách email không được để trống")]
    public List<string> Emails { get; set; } = [];
    
    public string? CustomMessage { get; set; }
}
