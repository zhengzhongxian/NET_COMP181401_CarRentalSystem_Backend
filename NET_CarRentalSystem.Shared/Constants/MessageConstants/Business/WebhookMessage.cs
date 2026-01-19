namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

public static class WebhookMessage
{
    public static class PayOsWebhook
    {
        public const string Success = "Webhook xử lý thành công";
        public const string ProcessingError = "Lỗi khi xử lý webhook";
    }

    public static class Confirmation
    {
        public const string Active = "Webhook endpoint đang hoạt động và sẵn sàng nhận thanh toán";
    }
}

