namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class RefundRequestMessage
{
    public static class Get
    {
        public const string Success = "Lấy danh sách yêu cầu hoàn tiền thành công.";
        public const string Error = "Lỗi khi lấy danh sách yêu cầu hoàn tiền.";
    }
    
    public static class Approve
    {
        public const string Success = "Phê duyệt yêu cầu hoàn tiền thành công. Hệ thống sẽ tự động xử lý hoàn tiền.";
        public const string NotFound = "Không tìm thấy yêu cầu hoàn tiền.";
        public const string InvalidStatus = "Yêu cầu hoàn tiền không ở trạng thái chờ duyệt.";
        public const string Error = "Lỗi khi phê duyệt yêu cầu hoàn tiền.";
    }
    
    public static class Reject
    {
        public const string Success = "Từ chối yêu cầu hoàn tiền thành công.";
        public const string NotFound = "Không tìm thấy yêu cầu hoàn tiền.";
        public const string InvalidStatus = "Yêu cầu hoàn tiền không ở trạng thái chờ duyệt.";
        public const string Error = "Lỗi khi từ chối yêu cầu hoàn tiền.";
    }
}

