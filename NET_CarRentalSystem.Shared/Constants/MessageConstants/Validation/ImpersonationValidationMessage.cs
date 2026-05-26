namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class ImpersonationValidationMessage
{
    public const string DeveloperCodeRequired = "Mã developer là bắt buộc.";
    public const string DeveloperCodeInvalidFormat = "Mã developer không hợp lệ. Yêu cầu đúng 6 ký tự hex (0-9, a-f).";
    public const string DurationRequired = "Thời lượng điều khiển là bắt buộc.";
    public const string DurationOutOfRange = "Thời lượng không hợp lệ. Tối thiểu {0} phút, tối đa {1} phút.";
    public const string TokenRequired = "Token điều khiển là bắt buộc.";
    public const string TokenInvalidFormat = "Token điều khiển không đúng định dạng.";
}
