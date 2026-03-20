using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;

public class GetBranchVehicleStatusQuery : IQuery<BranchVehicleStatusDto>
{
    public Guid BranchId { get; set; }
}

public class GetBranchVehicleStatusQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetBranchVehicleStatusQuery, BranchVehicleStatusDto>
{
    public async Task<BranchVehicleStatusDto> Handle(GetBranchVehicleStatusQuery request, CancellationToken cancellationToken)
    {
        // language=sql
        var branchNameSql = "SELECT name FROM locations WHERE location_id = @BranchId AND is_deleted = 0";
        var branchName = await dapperRepository.QueryFirstOrDefaultAsync<string>(branchNameSql, new { request.BranchId }, null, cancellationToken) ?? "Unknown Branch";

        // Mở mảng vehicle_models_json ra để đếm số lượng xe theo từng trạng thái
        // JSON_VALUE(j.value, '$.Status') sẽ lấy ra giá trị của trường Status trong mỗi object
        // language=sql
        var sql = """
            SELECT 
                CASE JSON_VALUE(j.value, '$.Status')
                    WHEN 'Available' THEN N'Sẵn Sàng'
                    WHEN 'InMaintenance' THEN N'Bảo Dưỡng'
                    ELSE N'Đang Thuê'
                END AS Name,
                COUNT(*) AS Count
            FROM vehicle_read_flat v
            CROSS APPLY OPENJSON(v.vehicle_models_json) j
            WHERE v.location_id = @BranchId AND v.is_deleted = 0 AND v.vehicle_models_json IS NOT NULL
            GROUP BY 
                CASE JSON_VALUE(j.value, '$.Status')
                    WHEN 'Available' THEN N'Sẵn Sàng'
                    WHEN 'InMaintenance' THEN N'Bảo Dưỡng'
                    ELSE N'Đang Thuê'
                END
            """;

        var statusCounts = (await dapperRepository.QueryAsync<VehicleStatusCountDto>(sql, new { request.BranchId }, null, cancellationToken)).ToList();
        
        var totalVehicles = statusCounts.Sum(s => s.Count);

        if (totalVehicles > 0)
        {
            foreach (var status in statusCounts)
            {
                status.Percentage = Math.Round((double)status.Count / totalVehicles * 100, 1);
            }
        }

        return new BranchVehicleStatusDto
        {
            BranchName = branchName,
            TotalVehicles = totalVehicles,
            Statuses = statusCounts
        };
    }
}
