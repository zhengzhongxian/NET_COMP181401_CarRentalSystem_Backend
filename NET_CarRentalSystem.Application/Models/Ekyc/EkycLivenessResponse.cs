using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Ekyc;

public class EkycLivenessResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("object")]
    public EkycLivenessObject? Object { get; set; }

    public bool IsSuccess => Message == "IDG-00000000";
}

public class EkycLivenessObject
{
    [JsonPropertyName("liveness")]
    public string Liveness { get; set; } = string.Empty;

    [JsonPropertyName("liveness_msg")]
    public string LivenessMsg { get; set; } = string.Empty;

    [JsonPropertyName("face_swapping")]
    public bool FaceSwapping { get; set; }

    [JsonPropertyName("fake_liveness")]
    public bool FakeLiveness { get; set; }

    [JsonPropertyName("is_eye_open")]
    public string IsEyeOpen { get; set; } = string.Empty;

    public bool IsReal => Liveness == "success";
}
