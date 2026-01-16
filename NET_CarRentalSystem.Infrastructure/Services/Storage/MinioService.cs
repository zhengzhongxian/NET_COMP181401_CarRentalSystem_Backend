using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Minio;
using Minio.DataModel.Args;
using Minio.Exceptions;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Exceptions.Minio;

namespace NET_CarRentalSystem.Infrastructure.Services.Storage;

public class MinioService : IMinioService
{
    private readonly MinioSettings _settings;
    private readonly IMinioClient _minioClient;
    private readonly ILogger<MinioService> _logger;

    public MinioService(
        IOptions<MinioSettings> settings,
        ILogger<MinioService> logger)
    {
        _settings = settings.Value;
        _logger = logger;

        // Use Endpoint for internal Docker communication (minio:9000)
        // PublicUrl is used for building external URLs (localhost:9000)
        var builder = new MinioClient()
            .WithEndpoint(_settings.Endpoint)
            .WithCredentials(_settings.AccessKey, _settings.SecretKey);

        if (_settings.UseSsL)
        {
            builder = builder.WithSSL();
        }

        if (!string.IsNullOrEmpty(_settings.Region))
        {
            builder = builder.WithRegion(_settings.Region);
        }

        _minioClient = builder.Build();

        _logger.LogInformation(
            "MinIO Service initialized - Internal Endpoint: {Endpoint}, Public URL: {PublicUrl}, Default Bucket: {Bucket}",
            _settings.Endpoint, _settings.PublicUrl ?? _settings.Endpoint, _settings.DefaultBucket);
    }

    public async Task<MinioFileInfo> UploadFileAsync(
        FileModel file,
        string? objectName = null,
        Dictionary<string, string>? metadata = null,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (file.Content == null || file.Content.Length == 0)
                throw new MinioBusinessException("FILE_EMPTY", "File không được rỗng");

            if (string.IsNullOrWhiteSpace(file.FileName))
                throw new MinioBusinessException("FILENAME_EMPTY", "Tên file không được rỗng");

            var bucket = _settings.DefaultBucket;
            var objName = objectName ?? GenerateObjectName(file.FileName);

            // Ensure bucket exists
            await EnsureBucketExistsAsync(bucket, cancellationToken);

            // Reset stream position
            if (file.Content.CanSeek)
                file.Content.Position = 0;

            // Prepare metadata headers
            var metadataHeaders = new Dictionary<string, string>();
            if (metadata != null)
            {
                foreach (var kvp in metadata)
                {
                    // MinIO requires x-amz-meta- prefix for custom metadata
                    metadataHeaders[$"x-amz-meta-{kvp.Key}"] = kvp.Value;
                }
            }

            // Add default metadata
            metadataHeaders["x-amz-meta-uploaded-at"] = DateTime.UtcNow.ToString("O");
            metadataHeaders["x-amz-meta-original-filename"] = file.FileName;

            // Upload file
            var putObjectArgs = new PutObjectArgs()
                .WithBucket(bucket)
                .WithObject(objName)
                .WithStreamData(file.Content)
                .WithObjectSize(file.Content.Length)
                .WithContentType(file.ContentType)
                .WithHeaders(metadataHeaders);

            await _minioClient.PutObjectAsync(putObjectArgs, cancellationToken);

            _logger.LogInformation(
                "Successfully uploaded file to MinIO: Bucket={Bucket}, Object={Object}, Size={Size}",
                bucket, objName, file.Content.Length);

            // Get file metadata after upload
            var fileInfo = await GetFileMetadataAsync(objName, cancellationToken);
            return fileInfo;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while uploading file: {FileName}", file.FileName);
            throw new MinioTechnicalException(
                "UPLOAD_ERROR",
                $"Lỗi MinIO khi upload file: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while uploading file: {FileName}", file.FileName);
            throw new MinioTechnicalException(
                "UPLOAD_ERROR",
                $"Lỗi không xác định khi upload file: {ex.Message}",
                ex);
        }
    }

    public async Task<List<MinioFileInfo>> UploadMultipleFilesAsync(
        IList<FileModel> files,
        string? folderPrefix = null,
        Dictionary<string, string>? metadata = null,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (files == null || files.Count == 0)
                throw new MinioBusinessException("FILES_EMPTY", "Danh sách file không được rỗng");

            var bucket = _settings.DefaultBucket;
            var uploadTasks = (from file in files
                let objectName = string.IsNullOrEmpty(folderPrefix)
                    ? GenerateObjectName(file.FileName)
                    : $"{folderPrefix.TrimEnd('/')}/{GenerateObjectName(file.FileName)}"
                select UploadFileAsync(file, objectName, metadata, cancellationToken)).ToList();

            var results = await Task.WhenAll(uploadTasks);

            _logger.LogInformation(
                "Successfully uploaded {Count} files to MinIO bucket: {Bucket}",
                files.Count, bucket);

            return results.ToList();
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while uploading multiple files");
            throw new MinioTechnicalException(
                "BATCH_UPLOAD_ERROR",
                $"Lỗi khi upload nhiều file: {ex.Message}",
                ex);
        }
    }

    public async Task<Stream> DownloadFileAsync(
        string objectName,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(objectName))
                throw new MinioBusinessException("OBJECT_NAME_EMPTY", "Tên object không được rỗng");

            var bucket = _settings.DefaultBucket;
            var memoryStream = new MemoryStream();

            var getObjectArgs = new GetObjectArgs()
                .WithBucket(bucket)
                .WithObject(objectName)
                .WithCallbackStream(async (stream, ct) =>
                {
                    await stream.CopyToAsync(memoryStream, ct);
                });

            await _minioClient.GetObjectAsync(getObjectArgs, cancellationToken);

            memoryStream.Position = 0;

            _logger.LogInformation(
                "Successfully downloaded file from MinIO: Bucket={Bucket}, Object={Object}",
                bucket, objectName);

            return memoryStream;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (ObjectNotFoundException ex)
        {
            _logger.LogWarning("File not found in MinIO: {ObjectName}", objectName);
            throw new MinioBusinessException(
                "FILE_NOT_FOUND",
                $"File không tồn tại: {objectName}",
                ex);
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while downloading file: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "DOWNLOAD_ERROR",
                $"Lỗi MinIO khi download file: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while downloading file: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "DOWNLOAD_ERROR",
                $"Lỗi không xác định khi download file: {ex.Message}",
                ex);
        }
    }

    public async Task<string> GetPresignedDownloadUrlAsync(
        string objectName,
        int expiryMinutes = 60,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(objectName))
                throw new MinioBusinessException("OBJECT_NAME_EMPTY", "Tên object không được rỗng");

            var bucket = _settings.DefaultBucket;
            var expiry = expiryMinutes > 0 ? expiryMinutes : _settings.PresignedUrlExpiryMinutes;

            var args = new PresignedGetObjectArgs()
                .WithBucket(bucket)
                .WithObject(objectName)
                .WithExpiry(expiry * 60); // Convert to seconds

            var url = await _minioClient.PresignedGetObjectAsync(args);

            _logger.LogInformation(
                "Generated presigned URL for object: {Object}, Expiry: {Expiry}min",
                objectName, expiry);

            return url;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while generating presigned URL: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "PRESIGNED_URL_ERROR",
                $"Lỗi MinIO khi tạo URL download: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while generating presigned URL: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "PRESIGNED_URL_ERROR",
                $"Lỗi không xác định khi tạo URL download: {ex.Message}",
                ex);
        }
    }

    public async Task<MinioFileInfo> GetFileMetadataAsync(
        string objectName,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(objectName))
                throw new MinioBusinessException("OBJECT_NAME_EMPTY", "Tên object không được rỗng");

            var bucket = _settings.DefaultBucket;

            var statObjectArgs = new StatObjectArgs()
                .WithBucket(bucket)
                .WithObject(objectName);

            var objectStat = await _minioClient.StatObjectAsync(statObjectArgs, cancellationToken);

            // Extract custom metadata (remove x-amz-meta- prefix)
            var metadata = new Dictionary<string, string>();
            if (objectStat.MetaData != null)
            {
                foreach (var kvp in objectStat.MetaData)
                {
                    var key = kvp.Key.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase)
                        ? kvp.Key[11..]
                        : kvp.Key;
                    metadata[key] = kvp.Value;
                }
            }

            var fileInfo = new MinioFileInfo
            {
                ObjectName = objectName,
                BucketName = bucket,
                Url = BuildFileUrl(bucket, objectName),
                Size = objectStat.Size,
                ContentType = objectStat.ContentType ?? "application/octet-stream",
                ETag = objectStat.ETag,
                LastModified = objectStat.LastModified,
                Metadata = metadata
            };

            return fileInfo;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (ObjectNotFoundException ex)
        {
            _logger.LogWarning("File not found in MinIO: {ObjectName}", objectName);
            throw new MinioBusinessException(
                "FILE_NOT_FOUND",
                $"File không tồn tại: {objectName}",
                ex);
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while getting file metadata: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "METADATA_ERROR",
                $"Lỗi MinIO khi lấy metadata: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while getting file metadata: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "METADATA_ERROR",
                $"Lỗi không xác định khi lấy metadata: {ex.Message}",
                ex);
        }
    }

    public async Task<bool> DeleteFileAsync(
        string objectName,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(objectName))
                throw new MinioBusinessException("OBJECT_NAME_EMPTY", "Tên object không được rỗng");

            var bucket = _settings.DefaultBucket;

            var removeObjectArgs = new RemoveObjectArgs()
                .WithBucket(bucket)
                .WithObject(objectName);

            await _minioClient.RemoveObjectAsync(removeObjectArgs, cancellationToken);

            _logger.LogInformation(
                "Successfully deleted file from MinIO: Bucket={Bucket}, Object={Object}",
                bucket, objectName);

            return true;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while deleting file: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "DELETE_ERROR",
                $"Lỗi MinIO khi xóa file: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while deleting file: {ObjectName}", objectName);
            throw new MinioTechnicalException(
                "DELETE_ERROR",
                $"Lỗi không xác định khi xóa file: {ex.Message}",
                ex);
        }
    }

    public async Task<bool> DeleteMultipleFilesAsync(
        IEnumerable<string> objectNames,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var objectNamesList = objectNames.ToList();

            if (objectNamesList.Count == 0)
                throw new MinioBusinessException("OBJECT_NAMES_EMPTY", "Danh sách tên object không được rỗng");

            var bucket = _settings.DefaultBucket;

            var removeObjectsArgs = new RemoveObjectsArgs()
                .WithBucket(bucket)
                .WithObjects(objectNamesList);

            var deleteErrors = await _minioClient.RemoveObjectsAsync(removeObjectsArgs, cancellationToken);
            var errors = new List<string>();

            foreach (var deleteError in deleteErrors)
            {
                var errorMsg = $"{deleteError.Key}: {deleteError.Message}";
                errors.Add(errorMsg);
                _logger.LogWarning("Failed to delete object: {Key} - {Message}", deleteError.Key, deleteError.Message);
            }

            if (errors.Any())
            {
                throw new MinioTechnicalException(
                    "BATCH_DELETE_ERROR",
                    $"Một số file không thể xóa: {string.Join(", ", errors)}");
            }

            _logger.LogInformation(
                "Successfully deleted {Count} files from MinIO bucket: {Bucket}",
                objectNamesList.Count, bucket);

            return true;
        }
        catch (MinioBusinessException)
        {
            throw;
        }
        catch (MinioTechnicalException)
        {
            throw;
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while deleting multiple files");
            throw new MinioTechnicalException(
                "BATCH_DELETE_ERROR",
                $"Lỗi MinIO khi xóa nhiều file: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while deleting multiple files");
            throw new MinioTechnicalException(
                "BATCH_DELETE_ERROR",
                $"Lỗi không xác định khi xóa nhiều file: {ex.Message}",
                ex);
        }
    }

    public async Task<bool> FileExistsAsync(
        string objectName,
        CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(objectName))
                return false;

            await GetFileMetadataAsync(objectName, cancellationToken);
            return true;
        }
        catch (MinioBusinessException ex) when (ex.ErrorCode == "FILE_NOT_FOUND")
        {
            return false;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<MinioFileInfo>> ListFilesAsync(
        string? prefix = null,
        CancellationToken cancellationToken = default)
    {
        try
        {
            var bucket = _settings.DefaultBucket;
            var fileInfos = new List<MinioFileInfo>();

            var listObjectsArgs = new ListObjectsArgs()
                .WithBucket(bucket)
                .WithPrefix(prefix ?? string.Empty)
                .WithRecursive(true);

            await foreach (var item in _minioClient.ListObjectsEnumAsync(listObjectsArgs, cancellationToken))
            {
                var fileInfo = new MinioFileInfo
                {
                    ObjectName = item.Key,
                    BucketName = bucket,
                    Url = BuildFileUrl(bucket, item.Key),
                    Size = (long)item.Size,
                    ContentType = "application/octet-stream",
                    ETag = item.ETag,
                    LastModified = DateTime.TryParse(item.LastModified, out var lastModified) ? lastModified : DateTime.UtcNow,
                    Metadata = new Dictionary<string, string>()
                };

                fileInfos.Add(fileInfo);
            }

            _logger.LogInformation(
                "Listed {Count} files from MinIO bucket: {Bucket} with prefix: {Prefix}",
                fileInfos.Count, bucket, prefix ?? "none");

            return fileInfos;
        }
        catch (MinioException ex)
        {
            _logger.LogError(ex, "MinIO error while listing files");
            throw new MinioTechnicalException(
                "LIST_ERROR",
                $"Lỗi MinIO khi liệt kê file: {ex.Message}",
                ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while listing files");
            throw new MinioTechnicalException(
                "LIST_ERROR",
                $"Lỗi không xác định khi liệt kê file: {ex.Message}",
                ex);
        }
    }
    
    private async Task EnsureBucketExistsAsync(string bucketName, CancellationToken cancellationToken)
    {
        try
        {
            var bucketExistsArgs = new BucketExistsArgs().WithBucket(bucketName);
            var exists = await _minioClient.BucketExistsAsync(bucketExistsArgs, cancellationToken);

            if (!exists)
            {
                var makeBucketArgs = new MakeBucketArgs().WithBucket(bucketName);
                await _minioClient.MakeBucketAsync(makeBucketArgs, cancellationToken);

                _logger.LogInformation("Created MinIO bucket: {Bucket}", bucketName);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error ensuring bucket exists: {Bucket}", bucketName);
            throw new MinioTechnicalException(
                "BUCKET_ERROR",
                $"Lỗi khi kiểm tra/tạo bucket: {ex.Message}",
                ex);
        }
    }

    private static string GenerateObjectName(string fileName)
    {
        var extension = Path.GetExtension(fileName);
        var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
        var sanitizedName = SanitizeFileName(fileNameWithoutExtension);
        var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff");
        var guid = Guid.NewGuid().ToString("N")[..8];

        return $"{timestamp}_{guid}_{sanitizedName}{extension}";
    }

    private static string SanitizeFileName(string fileName)
    {
        var invalidChars = Path.GetInvalidFileNameChars();
        return string.Join("_", fileName.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));
    }

    private string BuildFileUrl(string bucket, string objectName)
    {
        var baseUrl = !string.IsNullOrWhiteSpace(_settings.PublicUrl) ? _settings.PublicUrl : _settings.Endpoint;
        var scheme = _settings.UseSsL ? "https" : "http";
        if (baseUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase) || baseUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            return $"{baseUrl.TrimEnd('/')}/{bucket}/{objectName}";

        return $"{scheme}://{baseUrl.TrimEnd('/')}/{bucket}/{objectName}";
    }
}
