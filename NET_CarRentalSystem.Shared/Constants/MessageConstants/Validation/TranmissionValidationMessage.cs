namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class TranmissionValidationMessage
{
    public const string NameRequired = "Tên loại hộp số không được để trống";
    public const string NameMaxLength = "Tên loại hộp số không được vượt quá 100 ký tự";
    public const string CodeRequired = "Mã loại hộp số không được để trống";
    public const string CodeMaxLength = "Mã loại hộp số không được vượt quá 50 ký tự";
    public const string IdRequired = "ID loại hộp số là bắt buộc";
}