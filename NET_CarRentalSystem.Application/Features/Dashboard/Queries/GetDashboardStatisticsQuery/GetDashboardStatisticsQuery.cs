using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetDashboardStatisticsQuery;

public class GetDashboardStatisticsQuery : IQuery<DashboardStatisticsDto>;

public class GetDashboardStatisticsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetDashboardStatisticsQuery, DashboardStatisticsDto>
{
    public async Task<DashboardStatisticsDto> Handle(GetDashboardStatisticsQuery request, CancellationToken cancellationToken)
    {
        var totalLocationsSql = "SELECT COUNT(*) FROM locations WHERE is_deleted = 0";
        var totalLocations = await dapperRepository.QueryFirstOrDefaultAsync<int>(totalLocationsSql, cancellationToken: cancellationToken);
        
        var revenueByLocationSql = """
            WITH BookingPayments AS (
                SELECT
                    b.pickup_location_id,
                    SUM(pt.amount) AS TotalRevenue
                FROM booking_read_flat b
                JOIN payment_transactions pt ON b.booking_id_src = pt.booking_id
                WHERE pt.status = 'Success' AND pt.transaction_type IN ('Deposit', 'FinalPayment')
                GROUP BY b.pickup_location_id
            ),
            BookingRefunds AS (
                SELECT
                    b.pickup_location_id,
                    SUM(rr.amount) AS TotalRefund
                FROM booking_read_flat b
                JOIN refund_requests rr ON b.booking_id_src = rr.booking_id
                WHERE rr.status = 'Processed'
                GROUP BY b.pickup_location_id
            )
            SELECT 
                l.name AS LocationName,
                COALESCE(bp.TotalRevenue, 0) - COALESCE(br.TotalRefund, 0) AS Value
            FROM locations l
            LEFT JOIN BookingPayments bp ON l.location_id = bp.pickup_location_id
            LEFT JOIN BookingRefunds br ON l.location_id = br.pickup_location_id
            WHERE l.is_deleted = 0 AND (COALESCE(bp.TotalRevenue, 0) - COALESCE(br.TotalRefund, 0)) > 0
            ORDER BY Value DESC
            """;
            
        var revenueStats = await dapperRepository.QueryAsync<LocationStatisticDto>(revenueByLocationSql, cancellationToken: cancellationToken);
        var revenueList = revenueStats.ToList();
        
        var topRevenue = revenueList.FirstOrDefault();
        var lowestRevenue = revenueList.LastOrDefault();
        
        var performanceSql = """
            SELECT TOP 1
                l.name AS LocationName,
                COUNT(b.booking_id) AS Value
            FROM locations l
            JOIN booking_read_flat b ON l.location_id = b.pickup_location_id
            WHERE l.is_deleted = 0
            GROUP BY l.name, l.location_id
            ORDER BY Value DESC
            """;
            
        var highestPerformance = await dapperRepository.QueryFirstOrDefaultAsync<LocationStatisticDto>(performanceSql, cancellationToken: cancellationToken);

        return new DashboardStatisticsDto
        {
            TopRevenueLocation = topRevenue,
            HighestPerformanceLocation = highestPerformance,
            LowestRevenueLocation = lowestRevenue,
            TotalLocations = totalLocations
        };
    }
}
