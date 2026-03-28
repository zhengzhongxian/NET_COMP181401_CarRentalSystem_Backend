using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.API.Extensions;
using NET_CarRentalSystem.API.Models.Response.Dashboard;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetDailyRevenueQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetDashboardStatisticsQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetPaymentMethodStatisticsQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRecentRevenueQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRecentBookingsQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetPendingVehiclesCountQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRevenueByCategoryQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRevenueSummaryQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetTopRentedVehiclesQuery;
using NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetUserStatisticsQuery;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Wrapper;

namespace NET_CarRentalSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = RoleConstants.Admin)] // Tất cả API dashboard đều yêu cầu quyền Admin
public class DashboardController(ISender sender, IMapper mapper) : ControllerBase
{
    #region General Dashboard APIs

    /// <summary>
    /// Lấy báo cáo doanh thu theo khoảng ngày
    /// </summary>
    /// <param name="fromDate">Ngày bắt đầu (yyyy-MM-dd)</param>
    /// <param name="toDate">Ngày kết thúc (yyyy-MM-dd)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Doanh thu theo tháng: Deposit + FinalPayment - Refund</returns>
    [HttpGet("revenue")]
    public async Task<IActionResult> GetRevenueSummary(
        [FromQuery] DateTime fromDate,
        [FromQuery] DateTime toDate,
        CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetRevenueSummaryQuery
            {
                FromDate = fromDate,
                ToDate = toDate
            };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<List<MonthlyRevenueResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.Revenue.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.Revenue.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy danh sách xe có nhiều lượt thuê nhất
    /// </summary>
    /// <param name="top">Số lượng xe muốn lấy (mặc định là 5)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Danh sách xe có nhiều lượt thuê nhất</returns>
    [HttpGet("top-rented-vehicles")]
    public async Task<IActionResult> GetTopRentedVehicles(
        [FromQuery] int top = 5,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetTopRentedVehiclesQuery { Top = top };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<List<TopRentedVehicleResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.TopRentedVehicles.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.TopRentedVehicles.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy doanh thu trong X giờ qua với phần trăm thay đổi
    /// </summary>
    /// <param name="hours">Số giờ muốn tính doanh thu (mặc định là 2 giờ)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Doanh thu hiện tại và % thay đổi so với kỳ trước</returns>
    [HttpGet("recent-revenue")]
    public async Task<IActionResult> GetRecentRevenue(
        [FromQuery] int hours = 2,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetRecentRevenueQuery { Hours = hours };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<RecentRevenueResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.RecentRevenue.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.RecentRevenue.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy doanh thu theo ngày trong X ngày gần nhất
    /// </summary>
    /// <param name="days">Số ngày muốn lấy dữ liệu (mặc định là 30 ngày)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Danh sách doanh thu theo ngày để vẽ biểu đồ</returns>
    [HttpGet("daily-revenue")]
    public async Task<IActionResult> GetDailyRevenue(
        [FromQuery] int days = 30,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetDailyRevenueQuery { Days = days };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<List<DailyRevenueResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.DailyRevenue.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.DailyRevenue.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy thống kê người dùng đã đăng ký
    /// </summary>
    /// <param name="days">Số ngày để so sánh tăng/giảm (mặc định 30 ngày)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Tổng người dùng và % thay đổi so với kỳ trước</returns>
    [HttpGet("user-statistics")]
    public async Task<IActionResult> GetUserStatistics(
        [FromQuery] int days = 30,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetUserStatisticsQuery { Days = days };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<UserStatisticsResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.UserStatistics.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.UserStatistics.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy phân bổ doanh thu theo loại xe
    /// </summary>
    /// <param name="year">Năm muốn lấy dữ liệu</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Danh sách doanh thu theo tháng và loại xe</returns>
    [HttpGet("revenue-by-category")]
    public async Task<IActionResult> GetRevenueByCategory(
        [FromQuery] int year,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (year <= 0) year = DateTime.UtcNow.Year;
            
            var query = new GetRevenueByCategoryQuery { Year = year };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<List<RevenueByCategoryResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.RevenueByCategory.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.RevenueByCategory.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy các chỉ số thống kê tổng quan (Top 1 Doanh thu, Hiệu suất, Cần cải thiện, Tổng chi nhánh)
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Các chỉ số thống kê</returns>
    [HttpGet("statistics")]
    public async Task<IActionResult> GetDashboardStatistics(
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetDashboardStatisticsQuery();

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<DashboardStatisticsResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.Statistics.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.Statistics.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }
    
    /// <summary>
    /// Lấy thống kê tỉ lệ phương thức thanh toán
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Danh sách phương thức thanh toán và phần trăm</returns>
    [HttpGet("payment-method-statistics")]
    public async Task<IActionResult> GetPaymentMethodStatistics(
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetPaymentMethodStatisticsQuery();

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<List<PaymentMethodStatisticResponse>>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.PaymentMethod.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.PaymentMethod.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy số lượng đặt xe trong X giờ qua với phần trăm thay đổi
    /// </summary>
    /// <param name="hours">Số giờ muốn tính (mặc định là 3 giờ)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Số lượng booking hiện tại và % thay đổi so với kỳ trước</returns>
    [HttpGet("recent-bookings")]
    public async Task<IActionResult> GetRecentBookings(
        [FromQuery] int hours = 3,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetRecentBookingsQuery { Hours = hours };

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<RecentBookingsResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.RecentBookings.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.RecentBookings.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy số lượng xe chờ duyệt (Unavailable)
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Số lượng xe chờ duyệt và % thay đổi</returns>
    [HttpGet("pending-vehicles")]
    public async Task<IActionResult> GetPendingVehicles(
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetPendingVehiclesCountQuery();

            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<PendingVehiclesResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.PendingVehicles.Success);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.PendingVehicles.Error,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion

    #region Branch Statistics APIs

    /// <summary>
    /// Lấy thống kê tổng quan các chi nhánh
    /// </summary>
    [HttpGet("branch-stats-overview")]
    public async Task<IActionResult> GetBranchOverviewStats(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetBranchOverviewStatsQuery();
            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<BranchOverviewStatsResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.BranchStatistics.OverviewSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.BranchStatistics.OverviewError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy dữ liệu so sánh chi nhánh (Radar Chart)
    /// </summary>
    [HttpGet("branch-comparison")]
    public async Task<IActionResult> GetBranchComparison(CancellationToken cancellationToken)
    {
        try
        {
            var query = new GetBranchComparisonQuery();
            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<BranchComparisonResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.BranchStatistics.ComparisonSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.BranchStatistics.ComparisonError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy doanh thu tất cả chi nhánh (Bar Chart)
    /// </summary>
    /// <param name="period">Khoảng thời gian (month, week, year)</param>
    /// <param name="cancellationToken">Cancellation token</param>
    [HttpGet("branch-revenue-all")]
    public async Task<IActionResult> GetAllBranchRevenue([FromQuery] string period = "month", CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetAllBranchRevenueQuery { Period = period };
            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<BranchRevenueListResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.BranchStatistics.RevenueSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.BranchStatistics.RevenueError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy doanh thu theo ngày của một chi nhánh (Area Chart)
    /// </summary>
    /// <param name="branchId">ID của chi nhánh</param>
    /// <param name="days">Số ngày muốn lấy dữ liệu (mặc định 30)</param>
    [HttpGet("branches/{branchId:guid}/revenue-daily")]
    public async Task<IActionResult> GetBranchDailyRevenue(
        [FromRoute] Guid branchId,
        [FromQuery] int days = 30,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetBranchDailyRevenueQuery { BranchId = branchId, Days = days };
            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<BranchDailyRevenueResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.BranchStatistics.DailyRevenueSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.BranchStatistics.DailyRevenueError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    /// <summary>
    /// Lấy tình trạng xe của một chi nhánh (Radial Chart)
    /// </summary>
    /// <param name="branchId">ID của chi nhánh</param>
    [HttpGet("branches/{branchId:guid}/vehicle-status")]
    public async Task<IActionResult> GetBranchVehicleStatus(
        [FromRoute] Guid branchId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var query = new GetBranchVehicleStatusQuery { BranchId = branchId };
            var result = await sender.Send(query, cancellationToken);
            
            var response = mapper.Map<BranchVehicleStatusResponse>(result);
            var apiResponse = ApiResponse.SuccessResult(response, DashboardMessage.BranchStatistics.VehicleStatusSuccess);

            return StatusCode(apiResponse.StatusCode, apiResponse);
        }
        catch (Exception ex) when (!ex.IsInfrastructureException())
        {
            var errorResponse = ApiResponse.ErrorResult(
                DashboardMessage.BranchStatistics.VehicleStatusError,
                StatusCodes.Status500InternalServerError,
                [ex.Message]);

            return StatusCode(errorResponse.StatusCode, errorResponse);
        }
    }

    #endregion
}
