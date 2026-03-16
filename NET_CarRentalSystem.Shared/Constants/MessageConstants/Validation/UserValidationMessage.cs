namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class UserValidationMessage
{
    public static class Phone
    {
        public const string Required = "Số điện thoại không được để trống.";
        public const string Invalid = "Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại Việt Nam.";
    }

    public static class Avatar
    {
        public const string Required = "File ảnh không được để trống.";
        public const string Invalid = "File ảnh không hợp lệ.";
    }
}

