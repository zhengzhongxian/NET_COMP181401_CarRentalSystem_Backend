using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRevenueByCategoryQuery;

public class GetRevenueByCategoryQuery : IQuery<List<RevenueByCategoryDto>>
{
    public int Year { get; set; }
}

public class GetRevenueByCategoryQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRevenueByCategoryQuery, List<RevenueByCategoryDto>>
{
    public async Task<List<RevenueByCategoryDto>> Handle(GetRevenueByCategoryQuery request, CancellationToken cancellationToken)
    {
        var fromDate = new DateTime(request.Year, 1, 1);
        var toDate = fromDate.AddYears(1).AddTicks(-1);

        
        var sql = """
            WITH monthly_data AS (
                SELECT 
                    MONTH(pt.payment_date) AS month,
                    CASE 
                        WHEN v.fuel_name IN (N'Electric', N'Điện') THEN N'Xe điện'
                        WHEN v.category_name = 'SUV' THEN 'SUV'
                        WHEN v.category_name = 'SEDAN' THEN 'Sedan'
                        ELSE N'Khác'
                    END AS category_group,
                    COALESCE(SUM(pt.amount), 0) AS total_amount
                FROM payment_transactions pt
                JOIN booking_read_flat b ON pt.booking_id = b.booking_id_src
                JOIN vehicle_read_flat v ON b.vehicle_id = v.vehicle_id
                WHERE pt.status = 'Success'
                  AND pt.payment_date >= @FromDate 
                  AND pt.payment_date <= @ToDate
                  AND pt.transaction_type IN ('Deposit', 'FinalPayment')
                GROUP BY MONTH(pt.payment_date), 
                         CASE 
                            WHEN v.fuel_name IN (N'Electric', N'Điện') THEN N'Xe điện'
                            WHEN v.category_name = 'SUV' THEN 'SUV'
                            WHEN v.category_name = 'SEDAN' THEN 'Sedan'
                            ELSE N'Khác'
                         END
            ),
            monthly_refunds AS (
                SELECT 
                    MONTH(rr.processed_at) AS month,
                    CASE 
                        WHEN v.fuel_name IN (N'Electric', N'Điện') THEN N'Xe điện'
                        WHEN v.category_name = 'SUV' THEN 'SUV'
                        WHEN v.category_name = 'SEDAN' THEN 'Sedan'
                        ELSE N'Khác'
                    END AS category_group,
                    COALESCE(SUM(rr.amount), 0) AS total_refund
                FROM refund_requests rr
                JOIN booking_read_flat b ON rr.booking_id = b.booking_id_src
                JOIN vehicle_read_flat v ON b.vehicle_id = v.vehicle_id
                WHERE rr.status = 'Processed'
                  AND rr.processed_at >= @FromDate 
                  AND rr.processed_at <= @ToDate
                GROUP BY MONTH(rr.processed_at),
                         CASE 
                            WHEN v.fuel_name IN (N'Electric', N'Điện') THEN N'Xe điện'
                            WHEN v.category_name = 'SUV' THEN 'SUV'
                            WHEN v.category_name = 'SEDAN' THEN 'Sedan'
                            ELSE N'Khác'
                         END
            ),
            custom_categories AS (
                SELECT N'Xe điện' AS category_name UNION ALL
                SELECT 'SUV' UNION ALL
                SELECT 'Sedan' UNION ALL
                SELECT N'Khác'
            ),
            month_series AS (
                 SELECT number AS month
                 FROM master..spt_values
                 WHERE type = 'P' AND number BETWEEN 1 AND 12
            )
            SELECT 
                @Year AS Year,
                ms.month AS Month,
                CONCAT('T', ms.month) AS MonthLabel,
                c.category_name AS CategoryName,
                COALESCE(md.total_amount, 0) - COALESCE(mr.total_refund, 0) AS Revenue
            FROM month_series ms
            CROSS JOIN custom_categories c
            LEFT JOIN monthly_data md ON ms.month = md.month AND c.category_name = md.category_group
            LEFT JOIN monthly_refunds mr ON ms.month = mr.month AND c.category_name = mr.category_group
            ORDER BY ms.month, c.category_name
            """;

        var result = await dapperRepository.QueryAsync<RevenueByCategoryDto>(
            sql,
            new { FromDate = fromDate, ToDate = toDate, request.Year },
            cancellationToken: cancellationToken);

        return result.ToList();
    }
}
