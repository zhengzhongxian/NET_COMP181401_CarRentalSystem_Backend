using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class SystemSettingSeeder
{
    public static List<SystemSetting> Seed()
    {
        return
        [
            new SystemSetting
            {
                Id = Guid.Parse("019b5088-3895-7376-9e27-14a43c0df1d3"),
                SettingKey = SystemSettingConstants.MembershipThresholds.Bronze,
                SettingValue = "10000",
                Description = "Points required for Bronze tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-5aa1-70c5-954e-307f367c0ff2"),
                SettingKey = SystemSettingConstants.MembershipThresholds.Silver,
                SettingValue = "20000",
                Description = "Points required for Silver tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-6c4e-728e-b019-30b10d351c72"),
                SettingKey = SystemSettingConstants.MembershipThresholds.Gold,
                SettingValue = "30000",
                Description = "Points required for Gold tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-870d-72a6-9ab1-eadf6bf04999"),
                SettingKey = SystemSettingConstants.MembershipThresholds.Platinum,
                SettingValue = "50000",
                Description = "Points required for Platinum tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-9d8d-7041-83e3-ebc01f9d0a47"),
                SettingKey = SystemSettingConstants.MembershipThresholds.Diamond,
                SettingValue = "100000",
                Description = "Points required for Diamond tier"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b5088-c214-77e3-8e6d-7b68b0ee7f90"),
                SettingKey = SystemSettingConstants.MembershipDiscounts.Bronze,
                SettingValue = "0",
                Description = "Discount ratio for Bronze tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-e037-780b-98f8-b1dd868ca193"),
                SettingKey = SystemSettingConstants.MembershipDiscounts.Silver,
                SettingValue = "0.05",
                Description = "Discount ratio for Silver tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5088-f455-70e7-818f-341025ede937"),
                SettingKey = SystemSettingConstants.MembershipDiscounts.Gold,
                SettingValue = "0.1",
                Description = "Discount ratio for Gold tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5089-05bb-739e-a4d3-bae8cff04983"),
                SettingKey = SystemSettingConstants.MembershipDiscounts.Platinum,
                SettingValue = "0.15",
                Description = "Discount ratio for Platinum tier"
            },

            new SystemSetting
            {
                Id = Guid.Parse("019b5089-20ac-7253-85c6-3a4367442414"),
                SettingKey = SystemSettingConstants.MembershipDiscounts.Diamond,
                SettingValue = "0.2",
                Description = "Discount ratio for Diamond tier"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b50de-de75-72d8-88b9-a28c3da7fc00"),
                SettingKey = SystemSettingConstants.BookingSettings.DepositRatio,
                SettingValue = "0.3",
                Description = "Default deposit ratio for all bookings (0.3 = 30%)"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b50de-f123-7a4b-9c12-d3e4f5a6b789"),
                SettingKey = SystemSettingConstants.BookingSettings.LatePenaltyRatio,
                SettingValue = "0.1",
                Description = "Late penalty ratio per day (0.1 = 10% of booking price per day late)"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b50df-1234-7abc-8def-123456789001"),
                SettingKey = SystemSettingConstants.CancellationSettings.MaxCancellationsPerMonth,
                SettingValue = "3",
                Description = "Maximum number of booking cancellations allowed per month"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b50df-2345-7bcd-9ef0-234567890012"),
                SettingKey = SystemSettingConstants.CancellationSettings.RefundableHoursLimit,
                SettingValue = "24",
                Description = "Number of hours after booking creation within which refund is allowed"
            },
            new SystemSetting
            {
                Id = Guid.Parse("019b50df-4567-7def-1234-456789001234"),
                SettingKey = SystemSettingConstants.BookingSettings.LoyaltyPointsPerBooking,
                SettingValue = "100",
                Description = "Loyalty points awarded per completed booking (default: 100 points)"
            }
        ];
    }
}