namespace NET_CarRentalSystem.API.Models.Request.SystemSettings;

public class UpdateSystemSettingRequest
{
    public Guid SettingId { get; set; }
    
    public string SettingValue { get; set; } = string.Empty;
}

public class UpdateBookingSettingsRequest
{
    public decimal DepositRatio { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }
    
    public int LoyaltyPointsPerBooking { get; set; }
}

public class UpdateCancellationSettingsRequest
{
    public int MaxCancellationsPerMonth { get; set; }
    
    public int RefundableHoursLimit { get; set; }
}

public class UpdateMembershipThresholdsRequest
{
    public int Bronze { get; set; }
    
    public int Silver { get; set; }
    
    public int Gold { get; set; }
    
    public int Platinum { get; set; }
    
    public int Diamond { get; set; }
}

public class UpdateMembershipDiscountsRequest
{
    public decimal Bronze { get; set; }
    
    public decimal Silver { get; set; }
    
    public decimal Gold { get; set; }
    
    public decimal Platinum { get; set; }
    
    public decimal Diamond { get; set; }
}

public class UpdateAllSystemSettingsRequest
{
    public UpdateBookingSettingsRequest BookingSettings { get; set; } = new();
    
    public UpdateCancellationSettingsRequest CancellationSettings { get; set; } = new();
    
    public UpdateMembershipThresholdsRequest MembershipThresholds { get; set; } = new();
    
    public UpdateMembershipDiscountsRequest MembershipDiscounts { get; set; } = new();
}

