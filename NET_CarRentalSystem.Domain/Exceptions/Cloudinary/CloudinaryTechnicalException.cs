namespace NET_CarRentalSystem.Domain.Exceptions.Cloudinary;

/// <summary>
/// Ngoại lệ kỹ thuật của Cloudinary - xảy ra khi có lỗi từ API Cloudinary
/// </summary>
public class CloudinaryTechnicalException : Exception
{
    public string? ErrorCode { get; }
    public string? ErrorMessage { get; }

    public CloudinaryTechnicalException()
        : base("Lỗi kỹ thuật từ Cloudinary")
    {
    }

    public CloudinaryTechnicalException(string? message)
        : base(message ?? "Lỗi kỹ thuật từ Cloudinary")
    {
        ErrorMessage = message;
    }

    public CloudinaryTechnicalException(string? message, Exception? innerException)
        : base(message ?? "Lỗi kỹ thuật từ Cloudinary", innerException)
    {
        ErrorMessage = message;
    }

    public CloudinaryTechnicalException(string? errorCode, string? message)
        : base(message ?? "Lỗi kỹ thuật từ Cloudinary")
    {
        ErrorCode = errorCode;
        ErrorMessage = message;
    }

    public CloudinaryTechnicalException(string? errorCode, string? message, Exception? innerException)
        : base(message ?? "Lỗi kỹ thuật từ Cloudinary", innerException)
    {
        ErrorCode = errorCode;
        ErrorMessage = message;
    }
}