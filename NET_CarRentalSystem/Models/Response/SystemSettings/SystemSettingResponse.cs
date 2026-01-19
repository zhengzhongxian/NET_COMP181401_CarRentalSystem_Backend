namespace NET_CarRentalSystem.API.Models.Response.SystemSettings;

public class SystemSettingResponse
{
    public Guid SettingId { get; set; }
    
    public string SettingKey { get; set; } = string.Empty;
    
    public string? SettingValue { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime CreatedAt { get; set; }
}

public class BookingSettingsResponse
{
    public decimal DepositRatio { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }
    
    public int LoyaltyPointsPerBooking { get; set; }
}

public class CancellationSettingsResponse
{
    public int MaxCancellationsPerMonth { get; set; }
    
    public int RefundableHoursLimit { get; set; }
}

public class MembershipThresholdsResponse
{
    public int Bronze { get; set; }
    
    public int Silver { get; set; }
    
    public int Gold { get; set; }
    
    public int Platinum { get; set; }
    
    public int Diamond { get; set; }
}

public class MembershipDiscountsResponse
{
    public decimal Bronze { get; set; }
    
    public decimal Silver { get; set; }
    
    public decimal Gold { get; set; }
    
    public decimal Platinum { get; set; }
    
    public decimal Diamond { get; set; }
}

public class AllSystemSettingsResponse
{
    public BookingSettingsResponse BookingSettings { get; set; } = new();
    
    public CancellationSettingsResponse CancellationSettings { get; set; } = new();
    
    public MembershipThresholdsResponse MembershipThresholds { get; set; } = new();
    
    public MembershipDiscountsResponse MembershipDiscounts { get; set; } = new();
}

