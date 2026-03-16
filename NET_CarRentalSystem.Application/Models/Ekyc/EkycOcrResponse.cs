using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Ekyc;

public class EkycOcrResponse
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("server_version")]
    public string ServerVersion { get; set; } = string.Empty;

    [JsonPropertyName("object")]
    public EkycOcrObject? Object { get; set; }

    public bool IsSuccess => Message == "IDG-00000000";
}

public class EkycOcrObject
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("birth_day")]
    public string BirthDay { get; set; } = string.Empty;

    [JsonPropertyName("gender")]
    public string Gender { get; set; } = string.Empty;

    [JsonPropertyName("nationality")]
    public string Nationality { get; set; } = string.Empty;

    [JsonPropertyName("origin_location")]
    public string OriginLocation { get; set; } = string.Empty;

    [JsonPropertyName("recent_location")]
    public string RecentLocation { get; set; } = string.Empty;

    [JsonPropertyName("issue_date")]
    public string IssueDate { get; set; } = string.Empty;

    [JsonPropertyName("issue_place")]
    public string IssuePlace { get; set; } = string.Empty;

    [JsonPropertyName("valid_date")]
    public string ValidDate { get; set; } = string.Empty;

    [JsonPropertyName("card_type")]
    public string CardType { get; set; } = string.Empty;

    [JsonPropertyName("type_id")]
    public int TypeId { get; set; }

    [JsonPropertyName("expire_warning")]
    public string ExpireWarning { get; set; } = string.Empty;

    [JsonPropertyName("msg")]
    public string Msg { get; set; } = string.Empty;

    [JsonPropertyName("msg_back")]
    public string MsgBack { get; set; } = string.Empty;

    [JsonPropertyName("warning")]
    public List<string>? Warning { get; set; }

    [JsonPropertyName("warning_msg")]
    public List<string>? WarningMsg { get; set; }
}
