using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;

public class GetBranchDailyRevenueQuery : IQuery<BranchDailyRevenueDto>
{
    public Guid BranchId { get; set; }
    public int Days { get; set; } = 30;
}

public class GetBranchDailyRevenueQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetBranchDailyRevenueQuery, BranchDailyRevenueDto>
{
    public async Task<BranchDailyRevenueDto> Handle(GetBranchDailyRevenueQuery request, CancellationToken cancellationToken)
    {
        var branchNameSql = "SELECT name FROM locations WHERE location_id = @BranchId AND is_deleted = 0";
        var branchName = await dapperRepository.QueryFirstOrDefaultAsync<string>(branchNameSql, new { request.BranchId }, null, cancellationToken) ?? "Unknown Branch";

        var sql = $"""
            WITH DateRange AS (
                SELECT CAST(GETUTCDATE() - @Days + 1 AS DATE) as Date
                UNION ALL
                SELECT DATEADD(day, 1, Date)
                FROM DateRange
                WHERE Date < CAST(GETUTCDATE() AS DATE)
            ),
            DailyPayments AS (
                SELECT 
                    CAST(pt.created_at AS DATE) AS Date,
                    SUM(pt.amount) AS TotalRevenue
                FROM payment_transactions pt
                JOIN booking_read_flat b ON pt.booking_id = b.booking_id_src
                WHERE pt.status = 'Success' 
                    AND pt.transaction_type IN ('Deposit', 'FinalPayment')
                    AND b.pickup_location_id = @BranchId
                    AND pt.created_at >= GETUTCDATE() - @Days
                GROUP BY CAST(pt.created_at AS DATE)
            ),
            DailyRefunds AS (
                SELECT 
                    CAST(rr.created_at AS DATE) AS Date,
                    SUM(rr.amount) AS TotalRefund
                FROM refund_requests rr
                JOIN booking_read_flat b ON rr.booking_id = b.booking_id_src
                WHERE rr.status = 'Processed'
                    AND b.pickup_location_id = @BranchId
                    AND rr.created_at >= GETUTCDATE() - @Days
                GROUP BY CAST(rr.created_at AS DATE)
            )
            SELECT 
                FORMAT(dr.Date, 'yyyy-MM-dd') AS Date,
                COALESCE(dp.TotalRevenue, 0) - COALESCE(dref.TotalRefund, 0) AS Revenue
            FROM DateRange dr
            LEFT JOIN DailyPayments dp ON dr.Date = dp.Date
            LEFT JOIN DailyRefunds dref ON dr.Date = dref.Date
            ORDER BY dr.Date ASC
            """;

        var dailyData = (await dapperRepository.QueryAsync<BranchDailyRevenueDataDto>(sql, new { request.BranchId, request.Days }, null, cancellationToken)).ToList();

        var totalRevenue = dailyData.Sum(x => x.Revenue);
        var maxRevenue = dailyData.Any() ? dailyData.Max(x => x.Revenue) : 0;
        var avgRevenue = request.Days > 0 ? totalRevenue / request.Days : 0;

        return new BranchDailyRevenueDto
        {
            BranchName = branchName,
            Data = dailyData,
            Summary = new BranchRevenueSummaryDto
            {
                TotalRevenue = totalRevenue,
                MaxRevenue = maxRevenue,
                AvgRevenuePerDay = avgRevenue
            }
        };
    }
}
