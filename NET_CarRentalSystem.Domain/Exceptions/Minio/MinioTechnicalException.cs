namespace NET_CarRentalSystem.Domain.Exceptions.Minio;

/// <summary>
/// MinIO Technical Exception - system/infrastructure errors
/// </summary>
public class MinioTechnicalException : Exception
{
    public string? ErrorCode { get; }
    public string? ErrorDetails { get; }

    public MinioTechnicalException()
        : base("Lỗi kỹ thuật từ MinIO")
    {
    }

    public MinioTechnicalException(string? message)
        : base(message ?? "Lỗi kỹ thuật từ MinIO")
    {
    }

    public MinioTechnicalException(string? message, Exception? innerException)
        : base(message ?? "Lỗi kỹ thuật từ MinIO", innerException)
    {
    }

    public MinioTechnicalException(string? errorCode, string? message)
        : base(message ?? "Lỗi kỹ thuật từ MinIO")
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }

    public MinioTechnicalException(string? errorCode, string? message, Exception? innerException)
        : base(message ?? "Lỗi kỹ thuật từ MinIO", innerException)
    {
        ErrorCode = errorCode;
        ErrorDetails = message;
    }
}
