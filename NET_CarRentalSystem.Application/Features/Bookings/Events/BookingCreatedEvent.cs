using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Bookings.Events;

public record BookingCreatedEvent : EntityCreatedEvent<Guid>
{
    public Guid CustomerId { get; set; }
    
    public string? CustomerName { get; set; }
    
    public string? CustomerEmail { get; set; }
    
    public string? CustomerPhone { get; set; }
    
    public Guid VehicleId { get; set; }
    
    public decimal VehiclePricePerHour { get; set; }
    
    public Guid VehicleModelId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? VehicleStatus { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public string PickupLocationName { get; set; } = string.Empty;
    
    public Guid? ReturnLocationId { get; set; }
    
    public string? ReturnLocationName { get; set; }
    
    public BookingStatus Status { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public decimal DepositRatio { get; set; }
    
    public decimal DiscountRate { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }
    
    public int MileageStart { get; set; }
    
    public int FuelLevelStart { get; set; }
    
    public string? Description { get; set; }
    
    public string? SwapReason { get; set; }
    
    public string? BookingImagesJson { get; set; }
    
    public string? Metadata { get; set; }
}
