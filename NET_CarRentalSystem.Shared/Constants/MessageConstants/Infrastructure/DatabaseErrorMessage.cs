namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Infrastructure;

public static class DatabaseErrorMessage
{
    public const string Duplicate = "Dữ liệu đã tồn tại (Trùng lặp).";
    public const string ForeignKeyViolation = "Không thể thực hiện thao tác vì dữ liệu đang được liên kết ở nơi khác.";
    public const string NotNullViolation = "Trường bắt buộc không được để trống.";
    public const string DataTooLong = "Dữ liệu nhập vào quá dài so với quy định.";
    public const string Timeout = "Yêu cầu tới cơ sở dữ liệu bị quá thời gian.";
    public const string Deadlock = "Hệ thống đang bận (deadlock). Vui lòng thử lại.";
    public const string ConnectionFailed = "Không thể kết nối tới cơ sở dữ liệu.";
    public const string LoginFailed = "Kết nối cơ sở dữ liệu không hợp lệ.";
    public const string DataTypeConversion = "Không đúng định dạng dữ liệu.";
    public const string ConcurrencyConflict = "Dữ liệu đã bị thay đổi bởi tiến trình khác. Vui lòng tải lại.";
    public const string SnapshotConflict = "Xung đột phiên làm việc. Vui lòng tải lại và thử lại.";
    public const string InsufficientStorage = "Máy chủ cơ sở dữ liệu không đủ dung lượng lưu trữ.";
    public const string SchemaInvalidName = "Lỗi lược đồ dữ liệu (tên cột/bảng không hợp lệ).";
    public const string ObjectAlreadyExists = "Đối tượng đã tồn tại trong cơ sở dữ liệu.";
    public const string ServiceBusy = "Dịch vụ cơ sở dữ liệu đang bận. Vui lòng thử lại.";
    public const string Throttled = "Hệ thống đang giới hạn lưu lượng. Vui lòng thử lại sau.";
    public const string BusinessRuleViolation = "Yêu cầu không hợp lệ theo quy tắc nghiệp vụ.";
    public const string UpdateError = "Lỗi cập nhật dữ liệu.";
    public const string General = "Lỗi cơ sở dữ liệu.";

}

