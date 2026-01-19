using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Models.DTOs.BookingDTOs.Get;

public class GetBookingReadFlatDto
{
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public string? CustomerPhone { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public decimal VehiclePricePerHour { get; set; }
    
    public Guid VehicleModelId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? VehicleStatus { get; set; }
    
    public string? PickupLocationName { get; set; }
    
    public string? ReturnLocationName { get; set; }
    
    public BookingStatus Status { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public DateTime? ActualEndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public decimal DepositRatio { get; set; }
    
    public decimal DiscountRate { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }
    
    public int MileageStart { get; set; }
    
    public int? FuelLevelEnd { get; set; }
    
    public decimal? FuelPrice { get; set; }
    
    public string? ConditionNotes { get; set; }
    
    public string? Description { get; set; }
    
    public string? SwapReason { get; set; }
    
    public string? CancellationReason { get; set; }
    
    public string? BookingImagesJson { get; set; }
    
    public string? BookingViolationsJson { get; set; }

    public string? ReturnImagesJson { get; set; }
    
    public string? FileName { get; set; }

    public string? Metadata { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    
    public string? CreatedBy { get; set; }
    
    public DateTime? UpdatedAt { get; set; }
    
    public string? UpdatedBy { get; set; }
}