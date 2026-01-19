namespace NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;

public class SystemSettingDto
{
    public Guid SettingId { get; set; }
    
    public string SettingKey { get; set; } = string.Empty;
    
    public string? SettingValue { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime CreatedAt { get; set; }
}

public class BookingSettingsDto
{
    public decimal DepositRatio { get; set; }
    
    public decimal LatePenaltyRatio { get; set; }
    
    public int LoyaltyPointsPerBooking { get; set; }
}

public class CancellationSettingsDto
{
    public int MaxCancellationsPerMonth { get; set; }
    
    public int RefundableHoursLimit { get; set; }
}

public class MembershipThresholdsDto
{
    public int Bronze { get; set; }
    
    public int Silver { get; set; }
    
    public int Gold { get; set; }
    
    public int Platinum { get; set; }
    
    public int Diamond { get; set; }
}

public class MembershipDiscountsDto
{
    public decimal Bronze { get; set; }
    
    public decimal Silver { get; set; }
    
    public decimal Gold { get; set; }
    
    public decimal Platinum { get; set; }
    
    public decimal Diamond { get; set; }
}

public class AllSystemSettingsDto
{
    public BookingSettingsDto BookingSettings { get; set; } = new();
    
    public CancellationSettingsDto CancellationSettings { get; set; } = new();
    
    public MembershipThresholdsDto MembershipThresholds { get; set; } = new();
    
    public MembershipDiscountsDto MembershipDiscounts { get; set; } = new();
}

