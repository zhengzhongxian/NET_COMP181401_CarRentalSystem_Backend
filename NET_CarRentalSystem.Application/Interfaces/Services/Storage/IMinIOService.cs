using NET_CarRentalSystem.Application.Models.Storage;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Storage;

public interface IMinioService
{
    /// <summary>
    /// Upload a single file to MinIO with metadata (uses default bucket)
    /// </summary>
    Task<MinioFileInfo> UploadFileAsync(
        FileModel file,
        string? objectName = null,
        Dictionary<string, string>? metadata = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Upload multiple files to MinIO (uses default bucket)
    /// </summary>
    Task<List<MinioFileInfo>> UploadMultipleFilesAsync(
        IList<FileModel> files,
        string? folderPrefix = null,
        Dictionary<string, string>? metadata = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Download a file from MinIO as Stream (uses default bucket)
    /// </summary>
    Task<Stream> DownloadFileAsync(
        string objectName,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get presigned URL for direct download (uses default bucket, expires after configured time)
    /// </summary>
    Task<string> GetPresignedDownloadUrlAsync(
        string objectName,
        int expiryMinutes = 60,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Get file metadata without downloading content (uses default bucket)
    /// </summary>
    Task<MinioFileInfo> GetFileMetadataAsync(
        string objectName,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a single file from MinIO (uses default bucket)
    /// </summary>
    Task<bool> DeleteFileAsync(
        string objectName,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete multiple files from MinIO (uses default bucket)
    /// </summary>
    Task<bool> DeleteMultipleFilesAsync(
        IEnumerable<string> objectNames,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Check if file exists in MinIO (uses default bucket)
    /// </summary>
    Task<bool> FileExistsAsync(
        string objectName,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// List all files in default bucket with optional prefix filter
    /// </summary>
    Task<List<MinioFileInfo>> ListFilesAsync(
        string? prefix = null,
        CancellationToken cancellationToken = default);
}
