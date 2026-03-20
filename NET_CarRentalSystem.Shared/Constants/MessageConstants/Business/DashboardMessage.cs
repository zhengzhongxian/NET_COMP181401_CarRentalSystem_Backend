namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class DashboardMessage
{
    public static class Revenue
    {
        public const string Success = "Lấy báo cáo doanh thu thành công";
        public const string Error = "Có lỗi xảy ra khi lấy báo cáo doanh thu";
    }
    
    public static class TopRentedVehicles
    {
        public const string Success = "Lấy danh sách xe có nhiều lượt thuê thành công";
        public const string Error = "Có lỗi xảy ra khi lấy danh sách xe có nhiều lượt thuê";
    }
    
    public static class RecentRevenue
    {
        public const string Success = "Lấy doanh thu gần đây thành công";
        public const string Error = "Có lỗi xảy ra khi lấy doanh thu gần đây";
    }
    
    public static class DailyRevenue
    {
        public const string Success = "Lấy doanh thu theo ngày thành công";
        public const string Error = "Có lỗi xảy ra khi lấy doanh thu theo ngày";
    }
    
    public static class UserStatistics
    {
        public const string Success = "Lấy thống kê người dùng thành công";
        public const string Error = "Có lỗi xảy ra khi lấy thống kê người dùng";
    }
    
    public static class RevenueByCategory
    {
        public const string Success = "Lấy phân bổ doanh thu theo loại xe thành công";
        public const string Error = "Có lỗi xảy ra khi lấy phân bổ doanh thu theo loại xe";
    }
    
    public static class Statistics
    {
        public const string Success = "Lấy số liệu thống kê thành công";
        public const string Error = "Có lỗi xảy ra khi lấy số liệu thống kê";
    }
    
    public static class PaymentMethod
    {
        public const string Success = "Lấy thống kê phương thức thanh toán thành công";
        public const string Error = "Có lỗi xảy ra khi lấy thống kê phương thức thanh toán";
    }

    public static class BranchStatistics
    {
        public const string OverviewSuccess = "Lấy thống kê tổng quan chi nhánh thành công";
        public const string OverviewError = "Có lỗi xảy ra khi lấy thống kê tổng quan chi nhánh";
        
        public const string ComparisonSuccess = "Lấy dữ liệu so sánh chi nhánh thành công";
        public const string ComparisonError = "Có lỗi xảy ra khi lấy dữ liệu so sánh chi nhánh";
        
        public const string RevenueSuccess = "Lấy dữ liệu doanh thu các chi nhánh thành công";
        public const string RevenueError = "Có lỗi xảy ra khi lấy dữ liệu doanh thu các chi nhánh";
        
        public const string DailyRevenueSuccess = "Lấy dữ liệu doanh thu hàng ngày của chi nhánh thành công";
        public const string DailyRevenueError = "Có lỗi xảy ra khi lấy dữ liệu doanh thu hàng ngày của chi nhánh";
        
        public const string VehicleStatusSuccess = "Lấy tình trạng xe của chi nhánh thành công";
        public const string VehicleStatusError = "Có lỗi xảy ra khi lấy tình trạng xe của chi nhánh";
    }
}
