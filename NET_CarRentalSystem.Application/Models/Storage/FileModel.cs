namespace NET_CarRentalSystem.Application.Models.Storage;

public class FileModel
{
    public required Stream Content { get; set; }
    
    public required string FileName { get; set; }
    
    public required string ContentType { get; set; }
}
