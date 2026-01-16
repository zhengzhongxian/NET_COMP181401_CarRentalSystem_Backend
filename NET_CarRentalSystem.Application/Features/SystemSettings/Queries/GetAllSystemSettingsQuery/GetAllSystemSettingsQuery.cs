using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.SystemSettings.Queries.GetAllSystemSettingsQuery;

public class GetAllSystemSettingsQuery : IQuery<AllSystemSettingsDto>;

public class GetAllSystemSettingsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllSystemSettingsQuery, AllSystemSettingsDto>
{
    public async Task<AllSystemSettingsDto> Handle(GetAllSystemSettingsQuery request, CancellationToken cancellationToken)
    {
        var settings = await unitOfWork.GetReadRepository<SystemSetting>()
            .GetAsync(cancellationToken: cancellationToken);

        var result = new AllSystemSettingsDto
        {
            BookingSettings = new BookingSettingsDto
            {
                DepositRatio = GetDecimalValue(settings, SystemSettingConstants.BookingSettings.DepositRatio, 0.3m),
                LatePenaltyRatio = GetDecimalValue(settings, SystemSettingConstants.BookingSettings.LatePenaltyRatio, 0.1m)
            },
            MembershipThresholds = new MembershipThresholdsDto
            {
                Bronze = GetIntValue(settings, SystemSettingConstants.MembershipThresholds.Bronze, 10000),
                Silver = GetIntValue(settings, SystemSettingConstants.MembershipThresholds.Silver, 20000),
                Gold = GetIntValue(settings, SystemSettingConstants.MembershipThresholds.Gold, 30000),
                Platinum = GetIntValue(settings, SystemSettingConstants.MembershipThresholds.Platinum, 50000),
                Diamond = GetIntValue(settings, SystemSettingConstants.MembershipThresholds.Diamond, 100000)
            },
            MembershipDiscounts = new MembershipDiscountsDto
            {
                Bronze = GetDecimalValue(settings, SystemSettingConstants.MembershipDiscounts.Bronze, 0),
                Silver = GetDecimalValue(settings, SystemSettingConstants.MembershipDiscounts.Silver, 0.05m),
                Gold = GetDecimalValue(settings, SystemSettingConstants.MembershipDiscounts.Gold, 0.1m),
                Platinum = GetDecimalValue(settings, SystemSettingConstants.MembershipDiscounts.Platinum, 0.15m),
                Diamond = GetDecimalValue(settings, SystemSettingConstants.MembershipDiscounts.Diamond, 0.2m)
            }
        };

        return result;
    }

    private static decimal GetDecimalValue(List<SystemSetting> settings, string key, decimal defaultValue)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting is not null && decimal.TryParse(setting.SettingValue, out var value) ? value : defaultValue;
    }

    private static int GetIntValue(List<SystemSetting> settings, string key, int defaultValue)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        return setting is not null && int.TryParse(setting.SettingValue, out var value) ? value : defaultValue;
    }
}

