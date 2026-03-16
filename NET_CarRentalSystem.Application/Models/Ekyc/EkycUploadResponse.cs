using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Ekyc;

public class EkycUploadResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("object")]
    public EkycUploadObject? Object { get; set; }

    public bool IsSuccess => Message == "IDG-00000000";
}

public class EkycUploadObject
{
    [JsonPropertyName("hash")]
    public string Hash { get; set; } = string.Empty;

    [JsonPropertyName("fileName")]
    public string FileName { get; set; } = string.Empty;

    [JsonPropertyName("fileType")]
    public string FileType { get; set; } = string.Empty;

    [JsonPropertyName("uploadedDate")]
    public string UploadedDate { get; set; } = string.Empty;

    [JsonPropertyName("tokenId")]
    public string TokenId { get; set; } = string.Empty;
}
