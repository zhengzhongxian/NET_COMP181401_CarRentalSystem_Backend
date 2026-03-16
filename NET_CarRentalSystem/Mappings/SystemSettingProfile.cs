using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.SystemSettings;
using NET_CarRentalSystem.API.Models.Response.SystemSettings;
using NET_CarRentalSystem.Application.Features.SystemSettings.Commands.UpdateSystemSettingsCommand;
using NET_CarRentalSystem.Application.Models.DTOs.SystemSettingDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class SystemSettingProfile : Profile
{
    public SystemSettingProfile()
    {
        CreateMap<PublicSystemSettingsDto, PublicSystemSettingsResponse>();
        CreateMap<AllSystemSettingsDto, AllSystemSettingsResponse>();
        CreateMap<BookingSettingsDto, BookingSettingsResponse>();
        CreateMap<CancellationSettingsDto, CancellationSettingsResponse>();
        CreateMap<MembershipThresholdsDto, MembershipThresholdsResponse>();
        CreateMap<MembershipDiscountsDto, MembershipDiscountsResponse>();
        
        CreateMap<UpdateAllSystemSettingsRequest, UpdateAllSystemSettingsCommand>();
        CreateMap<UpdateBookingSettingsRequest, BookingSettingsDto>();
        CreateMap<UpdateCancellationSettingsRequest, CancellationSettingsDto>();
        CreateMap<UpdateMembershipThresholdsRequest, MembershipThresholdsDto>();
        CreateMap<UpdateMembershipDiscountsRequest, MembershipDiscountsDto>();
    }
}

