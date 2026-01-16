using NET_CarRentalSystem.Domain.Entities;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class InsurancePackageSeeder
{
    private static readonly Guid BasicInsuranceId = new("10000000-0000-0000-0000-000000000001");
    private static readonly Guid StandardInsuranceId = new("10000000-0000-0000-0000-000000000002");
    private static readonly Guid PremiumInsuranceId = new("10000000-0000-0000-0000-000000000003");

    public static List<InsurancePackage> Seed()
    {
        return
        [
            new InsurancePackage
            {
                Id = BasicInsuranceId,
                Name = "Bảo hiểm cơ bản",
                Description = "Bảo hiểm trách nhiệm dân sự bắt buộc, bảo vệ bạn trước các chi phí pháp lý cơ bản.",
                Price = 50000,
                CoverageAmount = 50000000,
                CoverageDetails = "- Bảo hiểm trách nhiệm dân sự bên thứ 3\n- Thiệt hại tài sản tối đa 50 triệu\n- Chi phí y tế cơ bản\n- Hỗ trợ pháp lý 24/7",
                IsActive = true,
                DisplayOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new InsurancePackage
            {
                Id = StandardInsuranceId,
                Name = "Bảo hiểm tiêu chuẩn",
                Description = "Bảo vệ toàn diện cho xe và hành khách với mức bồi thường cao hơn.",
                Price = 100000,
                CoverageAmount = 100000000,
                CoverageDetails = "- Tất cả quyền lợi gói Cơ bản\n- Bảo hiểm vật chất xe\n- Bảo hiểm tai nạn lái xe và hành khách\n- Hỗ trợ cứu hộ 24/7\n- Không khấu trừ khi xảy ra sự cố",
                IsActive = true,
                DisplayOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new InsurancePackage
            {
                Id = PremiumInsuranceId,
                Name = "Bảo hiểm cao cấp",
                Description = "Gói bảo hiểm toàn diện nhất với mức bồi thường tối đa và nhiều quyền lợi đặc biệt.",
                Price = 200000,
                CoverageAmount = 200000000,
                CoverageDetails = "- Tất cả quyền lợi gói Tiêu chuẩn\n- Bảo hiểm mất trộm xe\n- Bảo hiểm thiên tai, hỏa hoạn\n- Xe thay thế khi sửa chữa\n- Bồi thường không giới hạn cho bên thứ 3\n- Hỗ trợ VIP 24/7",
                IsActive = true,
                DisplayOrder = 3,
                CreatedAt = DateTime.UtcNow
            }
        ];
    }
}

