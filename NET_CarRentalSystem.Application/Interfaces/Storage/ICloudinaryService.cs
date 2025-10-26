using NET_CarRentalSystem.Application.Models.Storage;

namespace NET_CarRentalSystem.Application.Interfaces.Storage;

public interface ICloudinaryService
{
    /// <summary>
    /// Upload một file lên Cloudinary
    /// </summary>
    /// <param name="file">File cần upload</param>
    /// <param name="folder">Thư mục lưu trữ (optional)</param>
    /// <param name="publicId">Public ID tùy chỉnh (optional)</param>
    /// <returns>URL của file đã upload</returns>
    Task<string> UploadImageAsync(FileModel file, string? folder = null, string? publicId = null);

    /// <summary>
    /// Upload nhiều file cùng lúc
    /// </summary>
    /// <param name="files">Danh sách file cần upload</param>
    /// <param name="folder">Thư mục lưu trữ (optional)</param>
    /// <returns>Danh sách URL của các file đã upload</returns>
    Task<List<string>> UploadMultipleImagesAsync(IList<FileModel> files, string? folder = null);

    /// <summary>
    /// Xóa một file từ Cloudinary
    /// </summary>
    /// <param name="publicId">Public ID của file cần xóa</param>
    /// <returns>True nếu xóa thành công</returns>
    Task<bool> DeleteImageAsync(string publicId);

    /// <summary>
    /// Xóa nhiều file cùng lúc
    /// </summary>
    /// <param name="publicIds">Danh sách Public ID của các file cần xóa</param>
    /// <returns>True nếu tất cả file đều xóa thành công</returns>
    Task<bool> DeleteMultipleImagesAsync(List<string> publicIds);

    /// <summary>
    /// Lấy thông tin chi tiết của một file
    /// </summary>
    /// <param name="publicId">Public ID của file</param>
    /// <returns>Thông tin file hoặc null nếu không tìm thấy</returns>
    Task<CloudinaryFileInfo?> GetImageInfoAsync(string publicId);

    /// <summary>
    /// Tạo URL với transformation (resize, crop, etc.)
    /// </summary>
    /// <param name="publicId">Public ID của file</param>
    /// <param name="width">Chiều rộng</param>
    /// <param name="height">Chiều cao</param>
    /// <param name="crop">Kiểu crop (fill, fit, scale, etc.)</param>
    /// <returns>URL đã được transform</returns>
    string GenerateTransformedUrl(string publicId, int? width = null, int? height = null, string crop = "fill");
}


