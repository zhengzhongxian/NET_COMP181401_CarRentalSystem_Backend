using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using System.Linq;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;

public class GetBranchOverviewStatsQuery : IQuery<BranchOverviewStatsDto>;

public class GetBranchOverviewStatsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetBranchOverviewStatsQuery, BranchOverviewStatsDto>
{
    public async Task<BranchOverviewStatsDto> Handle(GetBranchOverviewStatsQuery request, CancellationToken cancellationToken)
    {
        // --- Tính toán các chỉ số tổng thể không theo chi nhánh ---
        
        // language=sql
        var totalRevenueTodaySql = """
            SELECT COALESCE(SUM(amount), 0)
            FROM payment_transactions
            WHERE status = 'Success' AND CAST(created_at AS DATE) = CAST(GETUTCDATE() AS DATE)
            """;
        var totalRevenueToday = await dapperRepository.QueryFirstOrDefaultAsync<decimal>(totalRevenueTodaySql, null, null, cancellationToken);

        // Active Vehicles = Tổng số xe ĐANG RẢNH (Dựa vào cột available_count có sẵn trong Read DB)
        // language=sql
        var activeVehiclesSql = "SELECT COALESCE(SUM(available_count), 0) FROM vehicle_read_flat WHERE is_deleted = 0";
        var activeVehicles = await dapperRepository.QueryFirstOrDefaultAsync<int>(activeVehiclesSql, null, null, cancellationToken);
        
        // Total Vehicles = Mở mảng JSON ra và đếm tổng số lượng xe con bên trong.
        // language=sql
        var totalVehiclesSql = """
            SELECT COUNT(*) 
            FROM vehicle_read_flat v
            CROSS APPLY OPENJSON(v.vehicle_models_json)
            WHERE v.is_deleted = 0 AND v.vehicle_models_json IS NOT NULL
            """;
        var totalVehicles = await dapperRepository.QueryFirstOrDefaultAsync<int>(totalVehiclesSql, null, null, cancellationToken);

        // language=sql
        var newCustomersTodaySql = "SELECT COUNT(*) FROM customers WHERE CAST(created_at AS DATE) = CAST(GETUTCDATE() AS DATE)";
        var newCustomersToday = await dapperRepository.QueryFirstOrDefaultAsync<int>(newCustomersTodaySql, null, null, cancellationToken);

        // language=sql
        var completedTripsSql = "SELECT COUNT(*) FROM booking_read_flat WHERE status = 'Completed'";
        var completedTrips = await dapperRepository.QueryFirstOrDefaultAsync<int>(completedTripsSql, null, null, cancellationToken);
        
        // language=sql
        var totalTripsSql = "SELECT COUNT(*) FROM booking_read_flat";
        var totalTrips = await dapperRepository.QueryFirstOrDefaultAsync<int>(totalTripsSql, null, null, cancellationToken);

        // --- Tính toán các chỉ số theo từng chi nhánh để tìm TOP ---

        // language=sql
        var revenueByBranchSql = """
            SELECT l.name AS BranchName, COALESCE(SUM(pt.amount), 0) AS Value
            FROM locations l
            LEFT JOIN booking_read_flat b ON l.location_id = b.pickup_location_id
            LEFT JOIN payment_transactions pt ON b.booking_id_src = pt.booking_id AND pt.status = 'Success'
            WHERE l.is_deleted = 0
            GROUP BY l.name
            """;
        var revenueByBranch = (await dapperRepository.QueryAsync<BranchStatItem>(revenueByBranchSql, null, null, cancellationToken)).ToList();

        // Top Branch có TỔNG SỐ XE nhiều nhất (Dựa vào json array length)
        // language=sql
        var vehiclesByBranchSql = """
            SELECT l.name AS BranchName, COUNT(j.[key]) AS Value
            FROM locations l
            LEFT JOIN vehicle_read_flat v ON v.is_deleted = 0 AND v.vehicle_models_json IS NOT NULL
            OUTER APPLY OPENJSON(v.vehicle_models_json) j
            WHERE l.is_deleted = 0 
              AND (l.location_id = TRY_CAST(JSON_VALUE(j.value, '$.LocationId') AS UNIQUEIDENTIFIER) OR j.value IS NULL)
            GROUP BY l.name
            """;
        var vehiclesByBranch = (await dapperRepository.QueryAsync<BranchStatItem>(vehiclesByBranchSql, null, null, cancellationToken)).ToList();

        // language=sql
        var customersByBranchSql = """
            SELECT l.name AS BranchName, COUNT(DISTINCT b.customer_id) AS Value
            FROM locations l
            LEFT JOIN booking_read_flat b ON l.location_id = b.pickup_location_id
            WHERE l.is_deleted = 0
            GROUP BY l.name
            """;
        var customersByBranch = (await dapperRepository.QueryAsync<BranchStatItem>(customersByBranchSql, null, null, cancellationToken)).ToList();

        // language=sql
        var completionsByBranchSql = """
            SELECT l.name AS BranchName, COUNT(b.booking_id) AS Value
            FROM locations l
            LEFT JOIN booking_read_flat b ON l.location_id = b.pickup_location_id AND b.status = 'Completed'
            WHERE l.is_deleted = 0
            GROUP BY l.name
            """;
        var completionsByBranch = (await dapperRepository.QueryAsync<BranchStatItem>(completionsByBranchSql, null, null, cancellationToken)).ToList();

        // --- Tìm TOP từ dữ liệu đã lấy ---
        var topRevenueBranch = revenueByBranch.OrderByDescending(x => x.Value).FirstOrDefault()?.BranchName ?? "N/A";
        
        // Cứ lấy thằng đầu tiên dù số lượng có = 0, để giao diện nhìn đồng bộ, không bị lòi chữ N/A
        var topVehicleBranch = vehiclesByBranch.OrderByDescending(x => x.Value).FirstOrDefault()?.BranchName ?? "N/A";
        var topCustomerBranch = customersByBranch.OrderByDescending(x => x.Value).FirstOrDefault()?.BranchName ?? "N/A";
        var topCompletionBranch = completionsByBranch.OrderByDescending(x => x.Value).FirstOrDefault()?.BranchName ?? "N/A";
        
        // Giả lập Profit
        var totalProfit = revenueByBranch.Sum(x => x.Value) * 0.25m;
        var profitMargin = 25.0m;
        var topProfitBranch = topRevenueBranch; // Tạm dùng top revenue

        return new BranchOverviewStatsDto
        {
            TotalRevenueToday = totalRevenueToday,
            TopRevenueBranch = topRevenueBranch,
            
            ActiveVehicles = activeVehicles,
            TotalVehicles = totalVehicles,
            TopVehicleBranch = topVehicleBranch,
            
            NewCustomersToday = newCustomersToday,
            TopCustomerBranch = topCustomerBranch,
            
            CompletedTrips = completedTrips,
            TotalTrips = totalTrips,
            TopCompletionBranch = topCompletionBranch,
            
            TotalProfit = totalProfit,
            ProfitMargin = profitMargin,
            TopProfitBranch = topProfitBranch
        };
    }

    private class BranchStatItem
    {
        public string BranchName { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}
