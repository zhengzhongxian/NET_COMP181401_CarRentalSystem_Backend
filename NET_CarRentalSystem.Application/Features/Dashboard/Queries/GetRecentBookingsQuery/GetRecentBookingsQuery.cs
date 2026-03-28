using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetRecentBookingsQuery;

public class GetRecentBookingsQuery : IQuery<RecentBookingsDto>
{
    public int Hours { get; set; } = 3;
}

public class GetRecentBookingsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetRecentBookingsQuery, RecentBookingsDto>
{
    public async Task<RecentBookingsDto> Handle(GetRecentBookingsQuery request, CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;
        var currentPeriodStart = now.AddHours(-request.Hours);
        var previousPeriodStart = currentPeriodStart.AddHours(-request.Hours);
        
        var sql = """
            SELECT COUNT(*) 
            FROM booking_read_flat 
            WHERE created_at >= @FromDate 
              AND created_at <= @ToDate
              AND is_deleted = 0
            """;

        var currentCount = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            sql,
            new { FromDate = currentPeriodStart, ToDate = now },
            cancellationToken: cancellationToken);

        var previousCount = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            sql,
            new { FromDate = previousPeriodStart, ToDate = currentPeriodStart },
            cancellationToken: cancellationToken);

        decimal percentageChange = 0;
        if (previousCount != 0)
        {
            percentageChange = Math.Round((decimal)(currentCount - previousCount) / previousCount * 100, 2);
        }
        else if (currentCount > 0)
        {
            percentageChange = 100;
        }

        return new RecentBookingsDto
        {
            Hours = request.Hours,
            CurrentCount = currentCount,
            PreviousCount = previousCount,
            PercentageChange = Math.Abs(percentageChange),
            IsIncrease = percentageChange >= 0
        };
    }
}
