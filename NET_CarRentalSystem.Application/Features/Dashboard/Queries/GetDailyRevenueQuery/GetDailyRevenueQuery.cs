using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetDailyRevenueQuery;

public class GetDailyRevenueQuery : IQuery<List<DailyRevenueDto>>
{
    public int Days { get; set; } = 30;
}

public class GetDailyRevenueQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetDailyRevenueQuery, List<DailyRevenueDto>>
{
    public async Task<List<DailyRevenueDto>> Handle(GetDailyRevenueQuery request, CancellationToken cancellationToken)
    {
        var toDate = DateTime.UtcNow.Date.AddDays(1).AddTicks(-1);
        var fromDate = DateTime.UtcNow.Date.AddDays(-request.Days + 1);
        
        var sql = """
            WITH daily_transactions AS (
                SELECT 
                    CAST(payment_date AS date) AS date,
                    COALESCE(SUM(amount), 0) AS total_amount
                FROM payment_transactions  
                WHERE status = 'Success'
                  AND payment_date >= @FromDate 
                  AND payment_date <= @ToDate
                  AND transaction_type IN ('Deposit', 'FinalPayment')
                GROUP BY CAST(payment_date AS date)
            ),
            daily_refunds AS (
                SELECT 
                    CAST(processed_at AS date) AS date,
                    COALESCE(SUM(amount), 0) AS total_refund
                FROM refund_requests  
                WHERE status = 'Processed'
                  AND processed_at >= @FromDate 
                  AND processed_at <= @ToDate
                GROUP BY CAST(processed_at AS date)
            ),
            date_series AS (
                SELECT CAST(DATEADD(day, number, @FromDate) AS date) AS date
                FROM master..spt_values
                WHERE type = 'P' 
                  AND number <= DATEDIFF(day, @FromDate, @ToDate)
            )
            SELECT 
                ds.date AS Date,
                COALESCE(dt.total_amount, 0) - COALESCE(dr.total_refund, 0) AS Revenue
            FROM date_series ds
            LEFT JOIN daily_transactions dt ON ds.date = dt.date
            LEFT JOIN daily_refunds dr ON ds.date = dr.date
            ORDER BY ds.date ASC
            """;

        var result = await dapperRepository.QueryAsync<DailyRevenueDto>(
            sql,
            new { FromDate = fromDate, ToDate = toDate },
            cancellationToken: cancellationToken);

        return result.ToList();
    }
}
