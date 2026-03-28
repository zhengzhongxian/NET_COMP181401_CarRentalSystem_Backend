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
        CreateMap<RecentBookingsDto, RecentBookingsResponse>();
        CreateMap<PendingVehiclesDto, PendingVehiclesResponse>();

        // Branch Statistics
        CreateMap<BranchOverviewStatsDto, BranchOverviewStatsResponse>();
        
        CreateMap<BranchComparisonDto, BranchComparisonResponse>();
        CreateMap<BranchInfoDto, BranchInfoResponse>();
        CreateMap<BranchCriteriaDto, BranchCriteriaResponse>();
        
        CreateMap<BranchRevenueListDto, BranchRevenueListResponse>();
        CreateMap<BranchRevenueDto, BranchRevenueResponse>();
        
        CreateMap<BranchDailyRevenueDto, BranchDailyRevenueResponse>();
        CreateMap<BranchDailyRevenueDataDto, BranchDailyRevenueDataResponse>();
        CreateMap<BranchRevenueSummaryDto, BranchRevenueSummaryResponse>();
        
        CreateMap<BranchVehicleStatusDto, BranchVehicleStatusResponse>();
        CreateMap<VehicleStatusCountDto, VehicleStatusCountResponse>();
    }
}
