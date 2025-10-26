namespace NET_CarRentalSystem.Application.Models.Storage;

/// <summary>
/// Thông tin file từ Cloudinary
/// </summary>
public class CloudinaryFileInfo
{
    public string PublicId { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string SecureUrl { get; set; } = string.Empty;
    public long Bytes { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Format { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
