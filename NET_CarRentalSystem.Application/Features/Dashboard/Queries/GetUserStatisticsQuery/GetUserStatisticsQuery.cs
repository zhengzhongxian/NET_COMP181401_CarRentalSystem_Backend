using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetUserStatisticsQuery;

public class GetUserStatisticsQuery : IQuery<UserStatisticsDto>
{
    public int Days { get; set; } = 30;
}

public class GetUserStatisticsQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetUserStatisticsQuery, UserStatisticsDto>
{
    public async Task<UserStatisticsDto> Handle(GetUserStatisticsQuery request, CancellationToken cancellationToken)
    {
        var now = DateTime.UtcNow;
        var currentPeriodStart = now.AddDays(-request.Days);
        var previousPeriodStart = currentPeriodStart.AddDays(-request.Days);

        // Query tổng số người dùng đã đăng ký
        const string totalUsersSql = """
                                     SELECT COUNT(*) FROM users WHERE is_deleted = 0
                                     """;

        var totalUsers = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            totalUsersSql,
            cancellationToken: cancellationToken);
        
        const string currentPeriodSql = """
                                        SELECT COUNT(*) 
                                        FROM users 
                                        WHERE is_deleted = 0
                                          AND created_at >= @FromDate 
                                          AND created_at <= @ToDate
                                        """;

        var currentPeriodUsers = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            currentPeriodSql,
            new { FromDate = currentPeriodStart, ToDate = now },
            cancellationToken: cancellationToken);
        
        var previousPeriodUsers = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            currentPeriodSql,
            new { FromDate = previousPeriodStart, ToDate = currentPeriodStart },
            cancellationToken: cancellationToken);
        
        decimal percentageChange = 0;
        if (previousPeriodUsers != 0)
        {
            percentageChange = Math.Round((decimal)(currentPeriodUsers - previousPeriodUsers) / previousPeriodUsers * 100, 2);
        }
        else if (currentPeriodUsers > 0)
        {
            percentageChange = 100;
        }

        return new UserStatisticsDto
        {
            TotalUsers = totalUsers,
            CurrentPeriodUsers = currentPeriodUsers,
            PreviousPeriodUsers = previousPeriodUsers,
            PercentageChange = Math.Abs(percentageChange),
            IsIncrease = percentageChange >= 0
        };
    }
}
