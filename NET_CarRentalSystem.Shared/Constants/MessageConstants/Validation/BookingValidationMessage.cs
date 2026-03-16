namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class BookingValidationMessage
{
    public const string BookingIdRequired = "Mã đơn đặt xe là bắt buộc.";
    public const string MileageInvalid = "Số km phải lớn hơn hoặc bằng 0.";
    public const string FuelLevelInvalid = "Mức xăng phải từ 0% đến 100%.";
    public const string FuelPriceInvalid = "Giá nhiên liệu phải lớn hơn 0.";
    public const string ConditionNotesRequired = "Ghi chú tình trạng xe là bắt buộc.";
    public const string ConditionNotesTooLong = "Ghi chú tình trạng xe không được quá 2000 ký tự.";
    public const string ImagesRequired = "Ảnh xe là bắt buộc.";
    public const string MinimumImagesRequired = "Cần ít nhất 4 ảnh xe (4 góc, nội thất, đồng hồ km, xăng).";
    public const string ImageInvalid = "Ảnh không hợp lệ. Vui lòng kiểm tra kích thước và định dạng file.";
    public const string NewVehicleModelIdRequired = "Mã vehicle model mới là bắt buộc.";
    public const string OldVehicleModelStatusInvalid = "Trạng thái của vehicle model cũ không hợp lệ.";
    public const string CancellationReasonRequired = "Lý do hủy đơn là bắt buộc.";
    public const string CancellationReasonTooLong = "Lý do hủy đơn không được quá 1000 ký tự.";
}
