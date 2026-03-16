using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRevenueSummaryQuery;

public class GetRevenueSummaryQuery : IQuery<List<MonthlyRevenueDto>>
{
    public DateTime FromDate { get; set; }
    
    public DateTime ToDate { get; set; }
}

public class GetRevenueSummaryQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRevenueSummaryQuery, List<MonthlyRevenueDto>>
{
    public async Task<List<MonthlyRevenueDto>> Handle(GetRevenueSummaryQuery request, CancellationToken cancellationToken)
    {
        var fromDate = request.FromDate.Date;
        var toDate = request.ToDate.Date.AddDays(1).AddTicks(-1);

        // Query tính doanh thu theo tháng = (Deposit + FinalPayment) - Refund
        var sql = """
            WITH monthly_transactions AS (
                SELECT 
                    YEAR(payment_date) AS year,
                    MONTH(payment_date) AS month,
                    COALESCE(SUM(amount), 0) AS total_amount
                FROM payment_transactions  
                WHERE status = 'Success'
                  AND payment_date >= @FromDate 
                  AND payment_date <= @ToDate
                  AND transaction_type IN ('Deposit', 'FinalPayment')
                GROUP BY YEAR(payment_date), MONTH(payment_date)
            ),
            monthly_refunds AS (
                SELECT 
                    YEAR(processed_at) AS year,
                    MONTH(processed_at) AS month,
                    COALESCE(SUM(amount), 0) AS total_refund
                FROM refund_requests  
                WHERE status = 'Processed'
                  AND processed_at >= @FromDate 
                  AND processed_at <= @ToDate
                GROUP BY YEAR(processed_at), MONTH(processed_at)
            ),
            month_series AS (
                SELECT 
                    YEAR(DATEADD(MONTH, number, @FromDate)) AS year,
                    MONTH(DATEADD(MONTH, number, @FromDate)) AS month
                FROM master..spt_values
                WHERE type = 'P' 
                  AND number <= DATEDIFF(MONTH, @FromDate, @ToDate)
            )
            SELECT 
                ms.year AS Year,
                ms.month AS Month,
                CONCAT('T', ms.month) AS MonthLabel,
                COALESCE(mt.total_amount, 0) - COALESCE(mr.total_refund, 0) AS Revenue
            FROM month_series ms
            LEFT JOIN monthly_transactions mt ON ms.year = mt.year AND ms.month = mt.month
            LEFT JOIN monthly_refunds mr ON ms.year = mr.year AND ms.month = mr.month
            ORDER BY ms.year ASC, ms.month ASC
            """;

        var result = await dapperRepository.QueryAsync<MonthlyRevenueDto>(
            sql,
            new { FromDate = fromDate, ToDate = toDate },
            cancellationToken: cancellationToken);

        return result.ToList();
    }
}
