using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRecentRevenueQuery;

public class GetRecentRevenueQuery : IQuery<RecentRevenueDto>
{
    public int Hours { get; set; } = 2;
}

public class GetRecentRevenueQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRecentRevenueQuery, RecentRevenueDto>
{
    public async Task<RecentRevenueDto> Handle(GetRecentRevenueQuery request, CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;
        var currentPeriodStart = now.AddHours(-request.Hours);
        var previousPeriodStart = currentPeriodStart.AddHours(-request.Hours);
        
        var currentRevenue = await CalculateRevenueAsync(currentPeriodStart, now, cancellationToken);
        
        var previousRevenue = await CalculateRevenueAsync(previousPeriodStart, currentPeriodStart, cancellationToken);
        
        decimal percentageChange = 0;
        if (previousRevenue != 0)
        {
            percentageChange = Math.Round((currentRevenue - previousRevenue) / previousRevenue * 100, 2);
        }
        else if (currentRevenue > 0)
        {
            percentageChange = 100; 
        }

        return new RecentRevenueDto
        {
            Hours = request.Hours,
            CurrentRevenue = currentRevenue,
            PreviousRevenue = previousRevenue,
            PercentageChange = Math.Abs(percentageChange),
            IsIncrease = percentageChange >= 0
        };
    }

    private async Task<decimal> CalculateRevenueAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken)
    {
        var transactionSql = """
            SELECT 
                COALESCE(SUM(amount), 0) AS TotalRevenue
            FROM payment_transactions  
            WHERE status = 'Success'
              AND payment_date >= @FromDate 
              AND payment_date <= @ToDate
              AND transaction_type IN ('Deposit', 'FinalPayment')
            """;

        var transactionResult = await dapperRepository.QueryFirstOrDefaultAsync<decimal>(
            transactionSql,
            new { FromDate = fromDate, ToDate = toDate },
            cancellationToken: cancellationToken);
        
        var refundSql = """
            SELECT 
                COALESCE(SUM(amount), 0) AS TotalRefund
            FROM refund_requests  
            WHERE status = 'Processed'
              AND processed_at >= @FromDate 
              AND processed_at <= @ToDate
            """;

        var refundResult = await dapperRepository.QueryFirstOrDefaultAsync<decimal>(
            refundSql,
            new { FromDate = fromDate, ToDate = toDate },
            cancellationToken: cancellationToken);

        return transactionResult - refundResult;
    }
}
