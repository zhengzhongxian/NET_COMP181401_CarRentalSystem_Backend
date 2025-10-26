namespace NET_CarRentalSystem.Shared.Constants.MessageConstants;

public static class RevenueMessage
{
    public static class Get
    {
        public const string Success = "Lấy thông tin doanh thu thành công.";
        public const string NotFound = "Không tìm thấy dữ liệu doanh thu.";
        public const string Error = "Đã xảy ra lỗi khi lấy thông tin doanh thu.";
    }

    public static class Stats
    {
        public const string Success = "Lấy thống kê doanh thu thành công.";
        public const string Error = "Đã xảy ra lỗi khi lấy thống kê doanh thu.";
    }

    public static class Period
    {
        public const string Success = "Lấy doanh thu theo thời gian thành công.";
        public const string Error = "Đã xảy ra lỗi khi lấy doanh thu theo thời gian.";
    }

    public static class Vehicle
    {
        public const string Success = "Lấy doanh thu theo phương tiện thành công.";
        public const string Error = "Đã xảy ra lỗi khi lấy doanh thu theo phương tiện.";
    }
}
