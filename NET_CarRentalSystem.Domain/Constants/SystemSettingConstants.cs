namespace NET_CarRentalSystem.Domain.Constants;

public static class SystemSettingConstants
{
    public static class BookingSettings
    {
        public const string DepositRatio = "BookingSettings.DepositRatio";
        public const string LatePenaltyRatio = "BookingSettings.LatePenaltyRatio";
        public const string LoyaltyPointsPerBooking = "BookingSettings.LoyaltyPointsPerBooking";
    }
    
    public static class CancellationSettings
    {
        public const string MaxCancellationsPerMonth = "CancellationSettings.MaxCancellationsPerMonth";
        public const string RefundableHoursLimit = "CancellationSettings.RefundableHoursLimit";
    }
    
    public static class MembershipThresholds
    {
        public const string Bronze = "MembershipThresholds.Bronze";
        public const string Silver = "MembershipThresholds.Silver";
        public const string Gold = "MembershipThresholds.Gold";
        public const string Platinum = "MembershipThresholds.Platinum";
        public const string Diamond = "MembershipThresholds.Diamond";
    }
    
    public static class MembershipDiscounts
    {
        public const string Bronze = "MembershipDiscounts.Bronze";
        public const string Silver = "MembershipDiscounts.Silver";
        public const string Gold = "MembershipDiscounts.Gold";
        public const string Platinum = "MembershipDiscounts.Platinum";
        public const string Diamond = "MembershipDiscounts.Diamond";
    }
}