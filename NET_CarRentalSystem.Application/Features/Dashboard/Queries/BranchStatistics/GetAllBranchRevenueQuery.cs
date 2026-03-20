using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;

public class GetAllBranchRevenueQuery : IQuery<BranchRevenueListDto>
{
    public string Period { get; set; } = "month";
}

public class GetAllBranchRevenueQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetAllBranchRevenueQuery, BranchRevenueListDto>
{
    public async Task<BranchRevenueListDto> Handle(GetAllBranchRevenueQuery request, CancellationToken cancellationToken)
    {
        var dateFilter = request.Period.ToLower() switch
        {
            "year" => "AND YEAR(pt.created_at) = YEAR(GETUTCDATE())",
            "week" => "AND DATEPART(wk, pt.created_at) = DATEPART(wk, GETUTCDATE()) AND YEAR(pt.created_at) = YEAR(GETUTCDATE())",
            _ => "AND MONTH(pt.created_at) = MONTH(GETUTCDATE()) AND YEAR(pt.created_at) = YEAR(GETUTCDATE())" // month
        };

        var revenueSql = $"""
            WITH BookingPayments AS (
                SELECT
                    b.pickup_location_id,
                    SUM(pt.amount) AS TotalRevenue
                FROM booking_read_flat b
                JOIN payment_transactions pt ON b.booking_id_src = pt.booking_id
                WHERE pt.status = 'Success' AND pt.transaction_type IN ('Deposit', 'FinalPayment') {dateFilter}
                GROUP BY b.pickup_location_id
            ),
            BookingRefunds AS (
                SELECT
                    b.pickup_location_id,
                    SUM(rr.amount) AS TotalRefund
                FROM booking_read_flat b
                JOIN refund_requests rr ON b.booking_id_src = rr.booking_id
                WHERE rr.status = 'Processed' {dateFilter.Replace("pt.created_at", "rr.created_at")}
                GROUP BY b.pickup_location_id
            )
            SELECT 
                l.location_id AS BranchId,
                l.name AS Name,
                COALESCE(bp.TotalRevenue, 0) - COALESCE(br.TotalRefund, 0) AS Revenue
            FROM locations l
            LEFT JOIN BookingPayments bp ON l.location_id = bp.pickup_location_id
            LEFT JOIN BookingRefunds br ON l.location_id = br.pickup_location_id
            WHERE l.is_deleted = 0
            ORDER BY Revenue DESC
            """;

        var revenueData = (await dapperRepository.QueryAsync<BranchRevenueDto>(revenueSql, null, null, cancellationToken)).ToList();

        // Tạo short name
        foreach (var branch in revenueData)
        {
            var words = branch.Name.Replace("Chi Nhánh ", "").Replace("Chi nhánh ", "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            branch.ShortName = words.Length > 1 
                ? string.Join("", words.Select(w => w[0])).ToUpper() 
                : branch.Name.Substring(0, Math.Min(2, branch.Name.Length)).ToUpper();
        }

        return new BranchRevenueListDto
        {
            Data = revenueData,
            TotalBranches = revenueData.Count
        };
    }
}
