using NET_CarRentalSystem.Application.Models.Storage;

namespace NET_CarRentalSystem.Application.Common.Validations;

public static class ValidateFile
{
    private const long MaxFileSize = 10 * 1024 * 1024;
    
    public static bool IsValidate(FileModel? file)
    {
        if (file == null) return true;

        return file.Content.Length > 0
               && file.Content.Length <= MaxFileSize
               && !string.IsNullOrWhiteSpace(file.FileName);
    }
}