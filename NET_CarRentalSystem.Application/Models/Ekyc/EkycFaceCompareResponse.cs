using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Ekyc;

public class EkycFaceCompareResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("server_version")]
    public string ServerVersion { get; set; } = string.Empty;

    [JsonPropertyName("object")]
    public EkycFaceCompareObject? Object { get; set; }

    public bool IsSuccess => Message == "IDG-00000000";
}

public class EkycFaceCompareObject
{
    [JsonPropertyName("result")]
    public string Result { get; set; } = string.Empty;

    [JsonPropertyName("msg")]
    public string Msg { get; set; } = string.Empty;

    [JsonPropertyName("prob")]
    public double Prob { get; set; }

    public bool IsMatch => Msg == "MATCH";
}
