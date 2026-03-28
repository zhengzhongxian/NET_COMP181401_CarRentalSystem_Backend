using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.GetPendingVehiclesCountQuery;

public class GetPendingVehiclesCountQuery : IQuery<PendingVehiclesDto>
{
}

public class GetPendingVehiclesCountQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetPendingVehiclesCountQuery, PendingVehiclesDto>
{
    public async Task<PendingVehiclesDto> Handle(GetPendingVehiclesCountQuery request, CancellationToken cancellationToken)
    {
        // Count vehicle models with status = 'Unavailable' from vehicle_read_flat JSON column
        // Using same OPENJSON pattern as GetBranchVehicleStatusQuery
        // language=sql
        var currentCountSql = """
            SELECT COUNT(*) 
            FROM vehicle_read_flat v
            CROSS APPLY OPENJSON(v.vehicle_models_json) j
            WHERE v.is_deleted = 0 
              AND v.vehicle_models_json IS NOT NULL
              AND JSON_VALUE(j.value, '$.Status') = 'Unavailable'
            """;

        var currentCount = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            currentCountSql,
            cancellationToken: cancellationToken);

        // Compare: count vehicles that had updates recently (7 days)
        var now = DateTime.UtcNow;
        var weekAgo = now.AddDays(-7);
        
        // language=sql
        var recentCountSql = """
            SELECT COUNT(*) 
            FROM vehicle_read_flat v
            CROSS APPLY OPENJSON(v.vehicle_models_json) j
            WHERE v.is_deleted = 0 
              AND v.vehicle_models_json IS NOT NULL
              AND JSON_VALUE(j.value, '$.Status') = 'Unavailable'
              AND v.updated_at >= @WeekAgo
            """;

        var recentCount = await dapperRepository.QueryFirstOrDefaultAsync<int>(
            recentCountSql,
            new { WeekAgo = weekAgo },
            cancellationToken: cancellationToken);

        var previousCount = currentCount - recentCount;
        
        decimal percentageChange = 0;
        if (previousCount != 0)
        {
            percentageChange = Math.Round((decimal)(currentCount - previousCount) / Math.Abs(previousCount) * 100, 2);
        }
        else if (currentCount > 0)
        {
            percentageChange = 100;
        }

        return new PendingVehiclesDto
        {
            Count = currentCount,
            PercentageChange = Math.Abs(percentageChange),
            IsIncrease = percentageChange >= 0
        };
    }
}
