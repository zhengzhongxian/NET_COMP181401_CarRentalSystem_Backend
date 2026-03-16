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
            SELECT 
                l.name AS LocationName,
                COALESCE(SUM(pt.amount), 0) - COALESCE(SUM(rr.amount), 0) AS Value
            FROM locations l
            LEFT JOIN booking_read_flat b ON l.location_id = b.pickup_location_id
            LEFT JOIN payment_transactions pt ON b.booking_id_src = pt.booking_id 
                AND pt.status = 'Success' 
                AND pt.transaction_type IN ('Deposit', 'FinalPayment')
            LEFT JOIN refund_requests rr ON b.booking_id_src = rr.booking_id 
                AND rr.status = 'Processed'
            WHERE l.is_deleted = 0
            GROUP BY l.name, l.location_id
            HAVING (COALESCE(SUM(pt.amount), 0) - COALESCE(SUM(rr.amount), 0)) > 0
            ORDER BY Value DESC
            """;
            
        var revenueStats = await dapperRepository.QueryAsync<LocationStatisticDto>(revenueByLocationSql, cancellationToken: cancellationToken);
        var revenueList = revenueStats.ToList();
        
        var topRevenue = revenueList.FirstOrDefault();
        var lowestRevenue = revenueList.OrderBy(x => x.Value).FirstOrDefault();
        
        var performanceSql = """
            SELECT TOP 1
                l.name AS LocationName,
                COUNT(b.booking_id) AS Value
            FROM locations l
            LEFT JOIN booking_read_flat b ON l.location_id = b.pickup_location_id
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
