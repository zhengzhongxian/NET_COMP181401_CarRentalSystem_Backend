namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class VehicleEmailValidationMessage
{
    public static class SendPromotion
    {
        public const string VehicleIdRequired = "Mã xe là bắt buộc";
        public const string EmailsRequired = "Danh sách email không được để trống";
        public const string InvalidEmails = "Danh sách email chứa email không hợp lệ";
        public const string CustomMessageTooLong = "Lời nhắn tùy chỉnh không được vượt quá 500 ký tự";
    }
}
