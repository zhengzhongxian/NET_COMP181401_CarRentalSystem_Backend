using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;

namespace NET_CarRentalSystem.Infrastructure.Services.Storage;

public class ImageResizeService : IImageResizeService
{
    public async Task<FileModel> ResizeImageAsync(FileModel file, int maxWidth, int maxHeight, int quality = 85)
    {
        file.Content.Position = 0;
        
        using var image = await Image.LoadAsync(file.Content);
        
        var ratioX = (double)maxWidth / image.Width;
        var ratioY = (double)maxHeight / image.Height;
        var ratio = Math.Min(ratioX, ratioY);
        
        if (ratio < 1)
        {
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            
            image.Mutate(x => x.Resize(newWidth, newHeight));
        }
        
        var outputStream = new MemoryStream();
        await image.SaveAsJpegAsync(outputStream, new JpegEncoder { Quality = quality });
        outputStream.Position = 0;
        
        return new FileModel
        {
            FileName = Path.ChangeExtension(file.FileName, ".jpg"),
            Content = outputStream,
            ContentType = "image/jpeg"
        };
    }

    public async Task<List<FileModel>> ResizeMultipleImagesAsync(IList<FileModel> files, int maxWidth, int maxHeight, int quality = 85)
    {
        var resizedFiles = new List<FileModel>();
        
        foreach (var file in files)
        {
            var resizedFile = await ResizeImageAsync(file, maxWidth, maxHeight, quality);
            resizedFiles.Add(resizedFile);
        }
        
        return resizedFiles;
    }

    public async Task<FileModel> CompressImageAsync(FileModel file, int quality = 75)
    {
        file.Content.Position = 0;
        
        using var image = await Image.LoadAsync(file.Content);
        
        var outputStream = new MemoryStream();
        await image.SaveAsJpegAsync(outputStream, new JpegEncoder { Quality = quality });
        outputStream.Position = 0;
        
        return new FileModel
        {
            FileName = Path.ChangeExtension(file.FileName, ".jpg"),
            Content = outputStream,
            ContentType = "image/jpeg"
        };
    }

    public async Task<FileModel> ResizeAndCompressAsync(FileModel file, int maxWidth, int maxHeight, int quality = 75)
    {
        file.Content.Position = 0;
        
        using var image = await Image.LoadAsync(file.Content);
        
        var ratioX = (double)maxWidth / image.Width;
        var ratioY = (double)maxHeight / image.Height;
        var ratio = Math.Min(ratioX, ratioY);
        
        if (ratio < 1)
        {
            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);
            
            image.Mutate(x => x.Resize(newWidth, newHeight));
        }
        
        var outputStream = new MemoryStream();
        await image.SaveAsJpegAsync(outputStream, new JpegEncoder { Quality = quality });
        outputStream.Position = 0;
        
        return new FileModel
        {
            FileName = Path.ChangeExtension(file.FileName, ".jpg"),
            Content = outputStream,
            ContentType = "image/jpeg"
        };
    }
}

