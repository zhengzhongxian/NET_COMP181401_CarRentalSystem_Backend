namespace NET_CarRentalSystem.Domain.Exceptions.Cloudinary;

/// <summary>
/// Ngoại lệ kinh doanh của Cloudinary - xảy ra khi dữ liệu không hợp lệ
/// </summary>
public class CloudinaryBusinessException : Exception
{
    public string? ErrorCode { get; }
    public string? ErrorDetails { get; }

    public CloudinaryBusinessException()
        : base("Lỗi kinh doanh từ Cloudinary")
    {
    }

    public CloudinaryBusinessException(string? message)
        : base(message ?? "Lỗi kinh doanh từ Cloudinary")
    {
    }

    public CloudinaryBusinessException(string? message, Exception? innerException)
        : base(message ?? "Lỗi kinh doanh từ Cloudinary", innerException)
    {
    }

    public CloudinaryBusinessException(string? errorCode, string? message)
        : base(message ?? "Lỗi kinh doanh từ Cloudinary")
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }

    public CloudinaryBusinessException(string? errorCode, string? message, Exception? innerException)
        : base(message ?? "Lỗi kinh doanh từ Cloudinary", innerException)
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }
}