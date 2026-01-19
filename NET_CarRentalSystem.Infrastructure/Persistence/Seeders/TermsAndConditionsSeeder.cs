using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;

namespace NET_CarRentalSystem.Infrastructure.Persistence.Seeders;

public static class TermsAndConditionsSeeder
{
    private static readonly Guid BookingTermsId = new("20000000-0000-0000-0000-000000000001");
    private static readonly Guid InsuranceTermsId = new("20000000-0000-0000-0000-000000000002");
    private static readonly Guid GeneralTermsId = new("20000000-0000-0000-0000-000000000003");

    public static List<TermsAndConditions> Seed()
    {
        return
        [
            new TermsAndConditions
            {
                Id = BookingTermsId,
                Title = "Điều Khoản và Điều Kiện Thuê Xe",
                Content = GetBookingTermsContent(),
                Version = "v1.0.0",
                EffectiveDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsActive = true,
                Type = TermsType.Booking,
                CreatedAt = DateTime.UtcNow
            },
            new TermsAndConditions
            {
                Id = InsuranceTermsId,
                Title = "Điều Khoản Bảo Hiểm Xe",
                Content = GetInsuranceTermsContent(),
                Version = "v1.0.0",
                EffectiveDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsActive = true,
                Type = TermsType.Insurance,
                CreatedAt = DateTime.UtcNow
            },
            new TermsAndConditions
            {
                Id = GeneralTermsId,
                Title = "Điều Khoản Sử Dụng Chung",
                Content = GetGeneralTermsContent(),
                Version = "v1.0.0",
                EffectiveDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsActive = true,
                Type = TermsType.General,
                CreatedAt = DateTime.UtcNow
            }
        ];
    }

    private static string GetBookingTermsContent()
    {
        return """
            <h2>1. ĐIỀU KIỆN THUÊ XE</h2>
            <p>Khách hàng phải đáp ứng các điều kiện sau:</p>
            <ul>
                <li>Tuổi từ 21 trở lên</li>
                <li>Có giấy phép lái xe hợp lệ còn hiệu lực ít nhất 1 năm</li>
                <li>Có CCCD/CMND còn hiệu lực</li>
                <li>Đặt cọc theo quy định</li>
            </ul>

            <h2>2. QUY ĐỊNH VỀ ĐẶT CỌC</h2>
            <p>Khách hàng phải đặt cọc 30% giá trị hợp đồng khi đặt xe. Tiền cọc sẽ được hoàn trả sau khi trả xe và kiểm tra tình trạng xe.</p>

            <h2>3. TRÁCH NHIỆM CỦA KHÁCH HÀNG</h2>
            <ul>
                <li>Sử dụng xe đúng mục đích đã đăng ký</li>
                <li>Không cho người khác mượn xe</li>
                <li>Không sử dụng xe vào mục đích vi phạm pháp luật</li>
                <li>Bảo quản xe cẩn thận, không hút thuốc trong xe</li>
                <li>Đổ đúng loại nhiên liệu theo quy định</li>
                <li>Trả xe đúng hạn và đúng địa điểm</li>
            </ul>

            <h2>4. PHÍ PHẠT</h2>
            <ul>
                <li>Trả xe trễ: 50.000đ/giờ (tối đa 500.000đ/ngày)</li>
                <li>Thiếu xăng: Theo giá thị trường + 20% phí dịch vụ</li>
                <li>Hư hỏng xe: Theo đánh giá thực tế</li>
                <li>Mất xe: Đền bù 100% giá trị xe</li>
            </ul>

            <h2>5. CHÍNH SÁCH HỦY ĐẶT XE</h2>
            <ul>
                <li>Hủy trước 24h: Hoàn 100% tiền cọc</li>
                <li>Hủy trong vòng 24h: Hoàn 50% tiền cọc</li>
                <li>Không đến nhận xe: Mất 100% tiền cọc</li>
            </ul>

            <h2>6. ĐIỀU KHOẢN KHÁC</h2>
            <p>Renticar có quyền từ chối cho thuê xe nếu khách hàng không đáp ứng các điều kiện trên hoặc có hành vi không phù hợp.</p>
            """;
    }

    private static string GetInsuranceTermsContent()
    {
        return """
            <h2>1. PHẠM VI BẢO HIỂM</h2>
            <p>Bảo hiểm chỉ có hiệu lực trong thời gian thuê xe và trong phạm vi lãnh thổ Việt Nam.</p>

            <h2>2. CÁC TRƯỜNG HỢP ĐƯỢC BẢO HIỂM</h2>
            <ul>
                <li>Tai nạn giao thông</li>
                <li>Va chạm với phương tiện khác</li>
                <li>Thiệt hại do thiên tai (gói Premium)</li>
                <li>Mất trộm xe (gói Premium)</li>
            </ul>

            <h2>3. CÁC TRƯỜNG HỢP KHÔNG ĐƯỢC BẢO HIỂM</h2>
            <ul>
                <li>Lái xe khi say rượu bia hoặc sử dụng chất kích thích</li>
                <li>Cố ý gây thiệt hại</li>
                <li>Sử dụng xe vào mục đích bất hợp pháp</li>
                <li>Cho người không có giấy phép lái xe</li>
            </ul>

            <h2>4. THỦ TỤC YÊU CẦU BỒI THƯỜNG</h2>
            <p>Khi xảy ra sự cố, khách hàng cần:</p>
            <ul>
                <li>Liên hệ hotline ngay lập tức</li>
                <li>Không di chuyển xe khỏi hiện trường (nếu có thể)</li>
                <li>Chụp ảnh hiện trường</li>
                <li>Lập biên bản với cơ quan chức năng (nếu cần)</li>
            </ul>
            """;
    }

    private static string GetGeneralTermsContent()
    {
        return """
            <h2>1. GIỚI THIỆU</h2>
            <p>Chào mừng bạn đến với Renticar - dịch vụ cho thuê xe hàng đầu Việt Nam.</p>

            <h2>2. QUYỀN RIÊNG TƯ</h2>
            <p>Chúng tôi cam kết bảo vệ thông tin cá nhân của khách hàng theo quy định của pháp luật.</p>

            <h2>3. QUYỀN SỞ HỮU TRÍ TUỆ</h2>
            <p>Tất cả nội dung trên website thuộc quyền sở hữu của Renticar.</p>

            <h2>4. LIÊN HỆ</h2>
            <p>Mọi thắc mắc xin liên hệ:</p>
            <ul>
                <li>Hotline: 1900 xxxx</li>
                <li>Email: support@renticar.vn</li>
            </ul>
            """;
    }
}

