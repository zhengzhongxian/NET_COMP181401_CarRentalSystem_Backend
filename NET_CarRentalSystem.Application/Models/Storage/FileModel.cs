namespace NET_CarRentalSystem.Application.Models.Storage;

public class FileModel
{
    public required Stream Content { get; set; } = null!;
    
    public required string FileName { get; set; } = null!;
    
    public required string ContentType { get; set; }
}
