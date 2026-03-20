using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.DashboardDTOs;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.BranchStatistics;

public class GetBranchComparisonQuery : IQuery<BranchComparisonDto>;

public class GetBranchComparisonQueryHandler(IDapperRepository dapperRepository)
    : IRequestHandler<GetBranchComparisonQuery, BranchComparisonDto>
{
    public async Task<BranchComparisonDto> Handle(GetBranchComparisonQuery request, CancellationToken cancellationToken)
    {
        // Lấy danh sách tối đa 5 chi nhánh nổi bật nhất (hoặc tất cả nếu ít)
        // language=sql
        var branchesSql = """
            SELECT TOP 5
                location_id AS Id,
                name AS Name
            FROM locations
            WHERE is_deleted = 0
            """;
        var branchList = (await dapperRepository.QueryAsync<BranchInfoDto>(branchesSql, null, null, cancellationToken)).ToList();

        // Tạo short name từ Name (VD: Chi Nhánh Hà Nội -> HN)
        foreach (var branch in branchList)
        {
            var words = branch.Name.Replace("Chi Nhánh ", "").Replace("Chi nhánh ", "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            branch.ShortName = words.Length > 1 
                ? string.Join("", words.Select(w => w[0])).ToUpper() 
                : branch.Name.Substring(0, Math.Min(2, branch.Name.Length)).ToUpper();
        }

        var branchIds = branchList.Select(b => b.Id).ToList();
        if (!branchIds.Any()) return new BranchComparisonDto();

        var branchIdsStr = string.Join("','", branchIds);

        // --- Các Query tính toán dữ liệu cho biểu đồ Radar ---

        // 1. Doanh thu (chuẩn hóa về thang điểm)
        // language=sql
        var revenueSql = $"""
            SELECT 
                b.pickup_location_id AS Id,
                SUM(pt.amount) AS Value
            FROM booking_read_flat b
            JOIN payment_transactions pt ON b.booking_id_src = pt.booking_id AND pt.status = 'Success'
            WHERE b.pickup_location_id IN ('{branchIdsStr}')
            GROUP BY b.pickup_location_id
            """;
        var revenueData = await dapperRepository.QueryAsync<BranchDataValue>(revenueSql, null, null, cancellationToken);

        // 2. Số lượng xe ĐANG RẢNH (Dùng vehicle_read_flat)
        // language=sql
        var vehicleSql = $"""
            SELECT 
                TRY_CAST(JSON_VALUE(j.value, '$.LocationId') AS UNIQUEIDENTIFIER) AS Id,
                SUM(CASE WHEN JSON_VALUE(j.value, '$.Status') = 'Available' THEN 1 ELSE 0 END) AS Value
            FROM vehicle_read_flat v
            CROSS APPLY OPENJSON(v.vehicle_models_json) j
            WHERE v.is_deleted = 0 AND v.vehicle_models_json IS NOT NULL
              AND JSON_VALUE(j.value, '$.LocationId') IN ('{branchIdsStr}')
            GROUP BY TRY_CAST(JSON_VALUE(j.value, '$.LocationId') AS UNIQUEIDENTIFIER)
            """;
        var vehicleData = await dapperRepository.QueryAsync<BranchDataValue>(vehicleSql, null, null, cancellationToken);

        // 3. Khách hàng
        // language=sql
        var customerSql = $"""
            SELECT 
                b.pickup_location_id AS Id,
                COUNT(DISTINCT b.customer_id) AS Value
            FROM booking_read_flat b
            WHERE b.pickup_location_id IN ('{branchIdsStr}') AND b.is_deleted = 0
            GROUP BY b.pickup_location_id
            """;
        var customerData = await dapperRepository.QueryAsync<BranchDataValue>(customerSql, null, null, cancellationToken);

        // 4. Hiệu suất (Tỷ lệ booking hoàn thành / tổng booking)
        // language=sql
        var performanceSql = $"""
            SELECT 
                b.pickup_location_id AS Id,
                CAST(SUM(CASE WHEN b.status = 'Completed' THEN 1 ELSE 0 END) AS FLOAT) / CAST(NULLIF(COUNT(*), 0) AS FLOAT) * 100 AS Value
            FROM booking_read_flat b
            WHERE b.pickup_location_id IN ('{branchIdsStr}') AND b.is_deleted = 0
            GROUP BY b.pickup_location_id
            """;
        var performanceData = await dapperRepository.QueryAsync<BranchDataValue>(performanceSql, null, null, cancellationToken);

        // 5. Bảo dưỡng (Tỷ lệ xe KHÔNG bảo dưỡng)
        // Dùng CROSS APPLY OPENJSON để đếm tổng số xe thực tế
        // language=sql
        var maintenanceSql = $"""
            WITH BranchTotals AS (
                SELECT 
                    TRY_CAST(JSON_VALUE(j.value, '$.LocationId') AS UNIQUEIDENTIFIER) AS location_id,
                    COUNT(*) AS TotalCount,
                    SUM(CASE WHEN JSON_VALUE(j.value, '$.Status') = 'Available' THEN 1 ELSE 0 END) as AvailableCount
                FROM vehicle_read_flat v
                CROSS APPLY OPENJSON(v.vehicle_models_json) j
                WHERE v.is_deleted = 0 AND v.vehicle_models_json IS NOT NULL
                  AND JSON_VALUE(j.value, '$.LocationId') IN ('{branchIdsStr}')
                GROUP BY TRY_CAST(JSON_VALUE(j.value, '$.LocationId') AS UNIQUEIDENTIFIER)
            )
            SELECT 
                location_id AS Id,
                CAST(AvailableCount AS FLOAT) / CAST(NULLIF(TotalCount, 0) AS FLOAT) * 100 AS Value
            FROM BranchTotals
            """;
        var maintenanceData = await dapperRepository.QueryAsync<BranchDataValue>(maintenanceSql, null, null, cancellationToken);


        // Helper function để map data vào dictionary
        Dictionary<string, decimal> MapToDict(IEnumerable<BranchDataValue> data, bool normalize = false)
        {
            var dict = new Dictionary<string, decimal>();
            var dataList = data.ToList();
            var maxVal = dataList.Any() ? dataList.Max(x => x.Value) : 0;
            
            foreach (var b in branchList)
            {
                var val = dataList.FirstOrDefault(d => d.Id == b.Id)?.Value ?? 0;
                // Chuẩn hóa doanh thu (hoặc các giá trị lớn) về thang 0-100 để vẽ radar chart đẹp hơn nếu cần
                if (normalize && maxVal > 0)
                {
                    val = Math.Round((val / maxVal) * 100, 2);
                }
                dict[b.ShortName] = val;
            }
            return dict;
        }

        var result = new BranchComparisonDto
        {
            Branches = branchList,
            Criteria = [
                new BranchCriteriaDto { Name = "Doanh thu", Values = MapToDict(revenueData, normalize: true) }, // Sửa: Bỏ chữ " (%)" và viết đúng như FE yêu cầu
                new BranchCriteriaDto { Name = "Số lượng xe", Values = MapToDict(vehicleData) },               // Sửa: Bỏ chữ "Rảnh"
                new BranchCriteriaDto { Name = "Khách hàng", Values = MapToDict(customerData) },
                new BranchCriteriaDto { Name = "Hiệu suất", Values = MapToDict(performanceData) },             // Sửa: Bỏ chữ " (%)"
                new BranchCriteriaDto { Name = "Bảo dưỡng", Values = MapToDict(maintenanceData) }              // Sửa: Thành "Bảo dưỡng" theo yêu cầu FE
            ],
            MaxValue = 100 // Thang điểm max cho radar chart là 100
        };

        return result;
    }

    private class BranchDataValue
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
    }
}
