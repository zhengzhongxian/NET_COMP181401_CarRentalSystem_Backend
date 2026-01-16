namespace NET_CarRentalSystem.Application.Models.DTOs.BookingViolationDTOs.Create;

public class CreateJsonBookingViolationDto
{
    public Guid Id { get; set; }
    
    public string? ViolationType { get; set; }
    
    public decimal Amount { get; set; }
    
    public string? Description { get; set; }
    
    public string? Details { get; set; }
    
    public string? Status { get; set; }
}
