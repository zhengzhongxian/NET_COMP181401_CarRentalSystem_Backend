using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class BookingReadFlat : BaseEntity<Guid>, IReadEntity
{
    public Guid BookingId { get; set; }
    
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public string? CustomerPhone { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public Guid VehicleModelId { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public string PickupLocationName { get; set; } = string.Empty;
    
    public Guid? ReturnLocationId { get; set; }
    
    public string? ReturnLocationName { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? VehicleStatus { get; set; }
    
    public decimal VehiclePricePerHour { get; set; }
    
    public BookingStatus Status { get; set; } = BookingStatus.Pending;
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public DateTime? ActualEndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public decimal DepositRatio { get; set; }
    
    public decimal DiscountRate { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }

    public int MileageStart { get; set; }
    
    public int FuelLevelStart { get; set; }
    
    public int? FuelLevelEnd { get; set; }
    
    public decimal? FuelPrice { get; set; }
    
    public string? ConditionNotes { get; set; }
    
    public string? Description { get; set; }
    
    public string? SwapReason { get; set; }
    
    public string? CancellationReason { get; set; }
    
    public string? BookingImagesJson { get; set; }
    
    public string? BookingViolationsJson { get; set; }

    public string? ReturnImagesJson { get; set; }
    
    public string? Metadata { get; set; }
    
    public string? FileName { get; set; }
}
