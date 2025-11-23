namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Infrastructure;

public static class SystemErrorMessage
{
    public static class Request
    {
        public const string Cancelled = "Người dùng đã hủy yêu cầu.";
    }
    
    public static class External
    {
        public const string ServiceUnavailable = "Dịch vụ đối tác [{0}] tạm thời không phản hồi. Vui lòng thử lại sau.";
    }
}