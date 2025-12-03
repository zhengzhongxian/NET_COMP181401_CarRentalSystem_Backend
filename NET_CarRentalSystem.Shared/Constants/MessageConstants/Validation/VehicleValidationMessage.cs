namespace NET_CarRentalSystem.Shared.Constants.MessageConstants.Validation;

public static class VehicleValidationMessage
{
    public const string NumberPlateRequired = "Biển số xe không được để trống";
    public const string NumberPlateMaxLength = "Biển số xe không được vượt quá 20 ký tự";
    public const string ManufacturerRequired = "Hãng sản xuất không được để trống";
    public const string ManufacturerMaxLength = "Hãng sản xuất không được vượt quá 50 ký tự";
    public const string ModelRequired = "Mẫu xe không được để trống";
    public const string ModelMaxLength = "Mẫu xe không được vượt quá 50 ký tự";
    public const string MileageNegative = "Số km đã đi không được âm";
    public const string PriceGreaterThanZero = "Giá thuê mỗi giờ phải lớn hơn 0";
    public const string RatingRange = "Đánh giá phải từ 0 đến 5 sao";
    public const string StatusInvalid = "Trạng thái xe không hợp lệ";

    public static class Create
    {
        public const string ThumbnailInvalid = "File ảnh không hợp lệ hoặc bị rỗng";
    }

    public static class Update
    {
        public const string IdRequired = "ID xe là bắt buộc";
    }

    public static class AddImages
    {
        public const string ImagesRequired = "Danh sách ảnh không được để trống";
        public const string ImagesMinCount = "Vui lòng tải lên ít nhất một ảnh";
    }

    public static class AddAttributes
    {
        public const string AttributesRequired = "Danh sách thuộc tính không được để trống";
        public const string AttributesMinCount = "Vui lòng cung cấp ít nhất một thuộc tính";
        public const string AttributeKeyRequired = "Khóa thuộc tính là bắt buộc";
        public const string AttributeValueRequired = "Giá trị thuộc tính là bắt buộc";
    }

}