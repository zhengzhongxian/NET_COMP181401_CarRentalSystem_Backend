namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class RefundRequestValidationMessage
{
    public const string RefundRequestIdRequired = "ID yêu cầu hoàn tiền là bắt buộc.";
    public const string AdminNotesRequired = "Ghi chú từ chối là bắt buộc.";
    public const string AdminNotesMaxLength = "Ghi chú không được vượt quá 500 ký tự.";
}

