using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Infrastructure.Configuration;

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

    public async Task<string> UploadImageAsync(FileModel file, string? folder = null, string? publicId = null)
    {
        if (file.Content.Length <= 0) return string.Empty;

        var uploadParams = new ImageUploadParams
        {
            File = new FileDescription(file.FileName, file.Content),
            Folder = folder,
            PublicId = publicId,
            Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
        };

        var uploadResult = await _cloudinary.UploadAsync(uploadParams);

        return uploadResult.Error != null ? uploadResult.Error.Message : uploadResult.SecureUrl.ToString();
    }

    public async Task<List<string>> UploadMultipleImagesAsync(IList<FileModel> files, string? folder = null)
    {
        var uploadTasks = files.Select(file => UploadImageAsync(file, folder));
        var urls = await Task.WhenAll(uploadTasks);
        return urls.ToList();
    }

    public async Task<bool> DeleteImageAsync(string publicId)
    {
        var deleteParams = new DeletionParams(publicId);
        var result = await _cloudinary.DestroyAsync(deleteParams);
        return result.Result == "ok";
    }

    public async Task<bool> DeleteMultipleImagesAsync(List<string> publicIds)
    {
        var delParams = new DelResParams()
        {
            PublicIds = publicIds
        };
        var result = await _cloudinary.DeleteResourcesAsync(delParams);
        return result.Deleted.Count == publicIds.Count;
    }

    public async Task<CloudinaryFileInfo?> GetImageInfoAsync(string publicId)
    {
        var result = await _cloudinary.GetResourceAsync(publicId);
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

    public string GenerateTransformedUrl(string publicId, int? width = null, int? height = null, string crop = "fill")
    {
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
}
