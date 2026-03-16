namespace NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;

public class PublicSystemSettingsDto
{
    public decimal DepositRatio { get; set; }

    public decimal LatePenaltyRatio { get; set; }

    public int MaxCancellationsPerMonth { get; set; }
    
    public int RefundableHoursLimit { get; set; }
}
