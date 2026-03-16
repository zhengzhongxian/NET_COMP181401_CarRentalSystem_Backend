using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Models.Storage;

namespace NET_CarRentalSystem.Application.Common.Validations;

public class ValidateFile(IOptions<FileValidationSettings> options)
{
    private readonly long _maxFileSize = options.Value.MaxFileSizeBytes;

    public bool IsValid(FileModel? file)
    {
        if (file == null) return true;

        return file.Content.Length > 0
               && file.Content.Length <= _maxFileSize
               && !string.IsNullOrWhiteSpace(file.FileName);
    }
    
    public static bool IsValidate(FileModel? file)
    {
        const long defaultMaxFileSize = 10 * 1024 * 1024;
        
        if (file == null) return true;

        return file.Content.Length > 0
               && file.Content.Length <= defaultMaxFileSize
               && !string.IsNullOrWhiteSpace(file.FileName);
    }
}