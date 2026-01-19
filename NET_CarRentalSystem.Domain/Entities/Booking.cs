using NET_CarRentalSystem.Domain.Common;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Domain.Entities;

public class Booking : BaseEntity<Guid>, IRowVersion
{
    public Guid CustomerId { get; set; }
    
    public Guid VehicleId { get; set; }

    public Guid VehicleModelId { get; set; }
    
    public Guid PickupLocationId { get; set; }
    
    public Guid? ReturnLocationId { get; set; }
    
    public BookingStatus Status { get; set; } = BookingStatus.Pending;

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public DateTime? ActualEndDate { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal DepositRatio { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }

    public int MileageStart { get; set; }

    public int? MileageEnd { get; set; }

    public int FuelLevelStart { get; set; }

    public int? FuelLevelEnd { get; set; }

    public decimal? FuelPrice { get; set; }

    public string? ConditionNotes { get; set; }
    
    public string? Description { get; set; }
    
    public string? SwapReason { get; set; }
    
    public string? CancellationReason { get; set; }
    
    public string? AcceptedTermsVersion { get; set; }
    
    public DateTime? AcceptedTermsAt { get; set; }

    public string? FileName { get; set; }

    public byte[] RowVersion { get; set; } = [];
    
    public virtual Customer Customer { get; set; } = default!;
    
    public virtual Vehicle Vehicle { get; set; } = default!;

    public virtual VehicleModel VehicleModel { get; set; } = default!;
    
    public virtual Location PickupLocation { get; set; } = default!;
    
    public virtual Location? ReturnLocation { get; set; }
    
    public virtual ICollection<PaymentTransaction> Transactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<BookingImage> BookingImages { get; set; } = new List<BookingImage>();

    public virtual ICollection<BookingInsurance> BookingInsurances { get; set; } = new List<BookingInsurance>();

    public virtual ICollection<VehicleReturnImage> VehicleReturnImages { get; set; } = new List<VehicleReturnImage>();

    public virtual ICollection<BookingViolation> Violations { get; set; } = new List<BookingViolation>();
}