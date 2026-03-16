using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Exceptions.Cloudinary;

namespace NET_CarRentalSystem.Infrastructure.Services.Storage;

public class CloudinaryService : ICloudinaryService
{
    private readonly Cloudinary _cloudinary;

    public CloudinaryService(IOptions<CloudinarySettings> config)
    {
        var account = new Account(
            config.Value.CloudName,
            config.Value.ApiKey,
            config.Value.ApiSecret
        );
        _cloudinary = new Cloudinary(account);
    }

    public async Task<CloudinaryFileInfo> UploadImageAsync(FileModel file, string? folder = null, string? publicId = null)
    {
        try
        {
            if (file.Content.Length <= 0)
                throw new CloudinaryBusinessException("FILE_EMPTY", "File không được rỗng");

            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, file.Content),
                Folder = folder,
                PublicId = publicId,
                Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new CloudinaryTechnicalException(
                    uploadResult.Error.ToString(),
                    $"Upload thất bại: {uploadResult.Error.Message}");
            }

            return new CloudinaryFileInfo
            {
                PublicId = uploadResult.PublicId,
                SecureUrl = uploadResult.SecureUrl.ToString(),
                Url = uploadResult.Url.ToString(),
                Format = uploadResult.Format,
                Width = uploadResult.Width,
                Height = uploadResult.Height,
                Bytes = uploadResult.Bytes,
                CreatedAt = DateTime.UtcNow 
            };
        }
        catch (CloudinaryBusinessException)
        {
            throw;
        }
        catch (CloudinaryTechnicalException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "UPLOAD_ERROR",
                $"Lỗi khi upload file: {ex.Message}",
                ex);
        }
    }

    public async Task<List<CloudinaryFileInfo>> UploadMultipleImagesAsync(IList<FileModel> files, string? folder = null)
    {
        try
        {
            var uploadTasks = files.Select(file => UploadImageAsync(file, folder));
            var urls = await Task.WhenAll(uploadTasks);
            return urls.ToList();
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "BATCH_UPLOAD_ERROR",
                $"Lỗi khi upload nhiều file: {ex.Message}",
                ex);
        }
    }

    public async Task<bool> DeleteImageAsync(string publicId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new CloudinaryBusinessException("INVALID_PUBLIC_ID", "PublicId không được rỗng");

            var deleteParams = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deleteParams);

            if (result.Error != null)
            {
                throw new CloudinaryTechnicalException(
                    result.StatusCode.ToString(),
                    $"Delete thất bại: {result.Error.Message}");
            }

            return result.Result == "ok";
        }
        catch (CloudinaryBusinessException)
        {
            throw;
        }
        catch (CloudinaryTechnicalException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "DELETE_ERROR",
                $"Lỗi khi xóa file: {ex.Message}",
                ex);
        }
    }

    public async Task<bool> DeleteMultipleImagesAsync(List<string> publicIds)
    {
        try
        {
            if (publicIds == null || publicIds.Count == 0)
                throw new CloudinaryBusinessException("EMPTY_IDS", "Danh sách PublicId không được rỗng");

            var delParams = new DelResParams()
            {
                PublicIds = publicIds
            };
            var result = await _cloudinary.DeleteResourcesAsync(delParams);

            if (result.Error != null)
            {
                throw new CloudinaryTechnicalException(
                    result.StatusCode.ToString(),
                    $"Batch delete thất bại: {result.Error.Message}");
            }

            return result.Deleted.Count == publicIds.Count;
        }
        catch (CloudinaryBusinessException)
        {
            throw;
        }
        catch (CloudinaryTechnicalException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "BATCH_DELETE_ERROR",
                $"Lỗi khi xóa nhiều file: {ex.Message}",
                ex);
        }
    }

    public async Task<CloudinaryFileInfo?> GetImageInfoAsync(string publicId)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new CloudinaryBusinessException("INVALID_PUBLIC_ID", "PublicId không được rỗng");

            var result = await _cloudinary.GetResourceAsync(publicId);

            if (result.Error != null)
            {
                throw new CloudinaryTechnicalException(
                    result.StatusCode.ToString(),
                    $"Get info thất bại: {result.Error.Message}");
            }

            if (result is not { StatusCode: System.Net.HttpStatusCode.OK })
            {
                return null;
            }

            return new CloudinaryFileInfo
            {
                PublicId = result.PublicId,
                Url = result.Url ?? string.Empty,
                SecureUrl = result.SecureUrl ?? string.Empty,
                Bytes = result.Bytes,
                Width = result.Width,
                Height = result.Height,
                Format = result.Format,
                CreatedAt = DateTime.TryParse(result.CreatedAt, out var createdAt) ? createdAt : DateTime.MinValue
            };
        }
        catch (CloudinaryBusinessException)
        {
            throw;
        }
        catch (CloudinaryTechnicalException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "GET_INFO_ERROR",
                $"Lỗi khi lấy thông tin file: {ex.Message}",
                ex);
        }
    }

    public string GenerateTransformedUrl(string publicId, int? width = null, int? height = null, string crop = "fill")
    {
        try
        {
            if (string.IsNullOrWhiteSpace(publicId))
                throw new CloudinaryBusinessException("INVALID_PUBLIC_ID", "PublicId không được rỗng");

            var transformation = new Transformation();
            if (width.HasValue && height.HasValue)
            {
                transformation.Width(width.Value).Height(height.Value).Crop(crop);
            }
            else if (width.HasValue)
            {
                transformation.Width(width.Value);
            }
            else if (height.HasValue)
            {
                transformation.Height(height.Value);
            }

            return _cloudinary.Api.Url.Transform(transformation).BuildUrl(publicId);
        }
        catch (Exception ex)
        {
            throw new CloudinaryTechnicalException(
                "URL_GENERATION_ERROR",
                $"Lỗi khi tạo URL transformed: {ex.Message}",
                ex);
        }
    }

    public async Task<byte[]?> DownloadImageAsync(string imageUrl)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                return null;

            using var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30);
            
            var response = await httpClient.GetAsync(imageUrl);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }
            
            return null;
        }
        catch
        {
            return null;
        }
    }
}
