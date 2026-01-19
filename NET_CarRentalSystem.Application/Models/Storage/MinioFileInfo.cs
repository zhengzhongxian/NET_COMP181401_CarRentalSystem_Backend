namespace NET_CarRentalSystem.Application.Models.Storage;

public class MinioFileInfo
{
    public required string ObjectName { get; set; }
    
    public required string Url { get; set; }
    
    public long Size { get; set; }
    
    public string ContentType { get; set; } = string.Empty;
    
    public string ETag { get; set; } = string.Empty;
    
    public DateTime LastModified { get; set; }
    
    public string BucketName { get; set; } = string.Empty;
    
    public Dictionary<string, string> Metadata { get; set; } = new();
}
