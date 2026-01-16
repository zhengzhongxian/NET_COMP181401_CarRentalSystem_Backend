namespace NET_CarRentalSystem.Domain.Exceptions.Minio;

/// <summary>
/// MinIO Business Exception - validation/business logic errors
/// </summary>
public class MinioBusinessException : Exception
{
    public string? ErrorCode { get; }
    public string? ErrorDetails { get; }

    public MinioBusinessException()
        : base("Lỗi nghiệp vụ từ MinIO")
    {
    }

    public MinioBusinessException(string? message)
        : base(message ?? "Lỗi nghiệp vụ từ MinIO")
    {
    }

    public MinioBusinessException(string? message, Exception? innerException)
        : base(message ?? "Lỗi nghiệp vụ từ MinIO", innerException)
    {
    }

    public MinioBusinessException(string? errorCode, string? message)
        : base(message ?? "Lỗi nghiệp vụ từ MinIO")
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }

    public MinioBusinessException(string? errorCode, string? message, Exception? innerException)
        : base(message ?? "Lỗi nghiệp vụ từ MinIO", innerException)
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }
}
