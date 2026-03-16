using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Dashboard;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class DashboardProfile : Profile
{
    public DashboardProfile()
    {
        CreateMap<MonthlyRevenueDto, MonthlyRevenueResponse>();
        CreateMap<TopRentedVehicleDto, TopRentedVehicleResponse>();
        CreateMap<RecentRevenueDto, RecentRevenueResponse>();
        CreateMap<DailyRevenueDto, DailyRevenueResponse>();
        CreateMap<UserStatisticsDto, UserStatisticsResponse>();
        CreateMap<RevenueByCategoryDto, RevenueByCategoryResponse>();
        CreateMap<DashboardStatisticsDto, DashboardStatisticsResponse>();
        CreateMap<LocationStatisticDto, LocationStatisticResponse>();
        CreateMap<PaymentMethodStatisticDto, PaymentMethodStatisticResponse>();
    }
}







