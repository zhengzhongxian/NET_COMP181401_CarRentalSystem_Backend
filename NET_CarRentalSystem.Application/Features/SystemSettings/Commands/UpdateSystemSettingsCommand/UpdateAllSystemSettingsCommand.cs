using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.SystemSettings.Commands.UpdateSystemSettingsCommand;

public class UpdateAllSystemSettingsCommand : ICommand<bool>
{
    public required BookingSettingsDto BookingSettings { get; set; }
    
    public required MembershipThresholdsDto MembershipThresholds { get; set; }
    
    public required MembershipDiscountsDto MembershipDiscounts { get; set; }
}

public class UpdateAllSystemSettingsCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateAllSystemSettingsCommand, bool>
{
    public async Task<bool> Handle(UpdateAllSystemSettingsCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var settings = await unitOfWork.GetReadRepository<SystemSetting>()
                .GetAsync(cancellationToken: ct);

            // Update Booking Settings
            var depositSetting = settings.FirstOrDefault(s => s.SettingKey == SystemSettingConstants.BookingSettings.DepositRatio);
            if (depositSetting is not null)
            {
                depositSetting.SettingValue = request.BookingSettings.DepositRatio.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
                unitOfWork.GetWriteRepository<SystemSetting>().Update(depositSetting);
            }

            var latePenaltySetting = settings.FirstOrDefault(s => s.SettingKey == SystemSettingConstants.BookingSettings.LatePenaltyRatio);
            if (latePenaltySetting is not null)
            {
                latePenaltySetting.SettingValue = request.BookingSettings.LatePenaltyRatio.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
                unitOfWork.GetWriteRepository<SystemSetting>().Update(latePenaltySetting);
            }

            // Update Membership Thresholds
            UpdateSetting(settings, SystemSettingConstants.MembershipThresholds.Bronze, request.MembershipThresholds.Bronze.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipThresholds.Silver, request.MembershipThresholds.Silver.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipThresholds.Gold, request.MembershipThresholds.Gold.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipThresholds.Platinum, request.MembershipThresholds.Platinum.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipThresholds.Diamond, request.MembershipThresholds.Diamond.ToString());

            // Update Membership Discounts
            UpdateSetting(settings, SystemSettingConstants.MembershipDiscounts.Bronze, request.MembershipDiscounts.Bronze.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipDiscounts.Silver, request.MembershipDiscounts.Silver.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipDiscounts.Gold, request.MembershipDiscounts.Gold.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipDiscounts.Platinum, request.MembershipDiscounts.Platinum.ToString());
            UpdateSetting(settings, SystemSettingConstants.MembershipDiscounts.Diamond, request.MembershipDiscounts.Diamond.ToString());

            await unitOfWork.SaveChangesAsync(ct);
            return true;
        }, cancellationToken);
    }

    private void UpdateSetting(List<SystemSetting> settings, string key, string value)
    {
        var setting = settings.FirstOrDefault(s => s.SettingKey == key);
        if (setting is not null)
        {
            setting.SettingValue = value;
            unitOfWork.GetWriteRepository<SystemSetting>().Update(setting);
        }
    }
}

