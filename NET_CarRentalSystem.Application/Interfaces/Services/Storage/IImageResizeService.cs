using NET_CarRentalSystem.Application.Models.Storage;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Storage;

public interface IImageResizeService
{
    Task<FileModel> ResizeImageAsync(FileModel file, int maxWidth, int maxHeight, int quality = 85);
    
    Task<List<FileModel>> ResizeMultipleImagesAsync(IList<FileModel> files, int maxWidth, int maxHeight, int quality = 85);
    
    Task<FileModel> CompressImageAsync(FileModel file, int quality = 75);
    
    Task<FileModel> ResizeAndCompressAsync(FileModel file, int maxWidth, int maxHeight, int quality = 75);
}

