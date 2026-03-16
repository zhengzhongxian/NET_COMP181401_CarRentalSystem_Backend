using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.SystemSettings.Queries.GetPublicSystemSettingsQuery;

public class GetPublicSystemSettingsQuery : IQuery<PublicSystemSettingsDto>;

public class GetPublicSystemSettingsQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetPublicSystemSettingsQuery, PublicSystemSettingsDto>
{
    public async Task<PublicSystemSettingsDto> Handle(GetPublicSystemSettingsQuery request, CancellationToken ct)
    {
        var settings = await unitOfWork.GetReadRepository<SystemSetting>().GetAsync(cancellationToken: ct);
        var settingsList = settings.ToList();

        return new PublicSystemSettingsDto
        {
            DepositRatio = settingsList.GetDecimal(SystemSettingConstants.BookingSettings.DepositRatio, 0.3m),
            LatePenaltyRatio = settingsList.GetDecimal(SystemSettingConstants.BookingSettings.LatePenaltyRatio, 0.1m),
            MaxCancellationsPerMonth = settingsList.GetInt(SystemSettingConstants.CancellationSettings.MaxCancellationsPerMonth, 3),
            RefundableHoursLimit = settingsList.GetInt(SystemSettingConstants.CancellationSettings.RefundableHoursLimit, 24)
        };
    }
}
