using NET_CarRentalSystem.Application.Common.Events;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Application.Features.Bookings.Events;

public record BookingUpdatedEvent : EntityUpdatedEvent<Guid>
{
    public Guid? VehicleModelId { get; set; }
    
    public string? NumberPlate { get; set; }
    
    public string? VehicleStatus { get; set; }
    
    public BookingStatus? Status { get; set; }
    
    public DateTime? ActualEndDate { get; set; }
    
    public int? FuelLevelEnd { get; set; }
    
    public int? FuelLevelStart { get; set; }
    
    public int? MileageStart { get; set; }
    
    public int? MileageEnd { get; set; }
    
    public decimal? FuelPrice { get; set; }
    
    public string? ConditionNotes { get; set; }
    
    public string? Description { get; set; }
    
    public string? SwapReason { get; set; }
    
    public string? CancellationReason { get; set; }

    public string? BookingImagesJson { get; set; }

    public string? BookingViolationsJson { get; set; }

    public string? ReturnImagesJson { get; set; }

    public string? FileName { get; set; }

    public DateTime? DepositRefundScheduledAt { get; set; }
}
