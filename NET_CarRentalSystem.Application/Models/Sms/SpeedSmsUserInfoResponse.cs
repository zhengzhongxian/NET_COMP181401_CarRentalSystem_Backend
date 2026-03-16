namespace NET_CarRentalSystem.Application.Models.Sms;

public class SpeedSmsUserInfoResponse
{
    public string Status { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string? Message { get; set; }

    public SpeedSmsUserInfoData? Data { get; set; }

    public bool IsSuccess => Status == "success" && Code == "00";
}

public class SpeedSmsUserInfoData
{
    public string Email { get; set; } = string.Empty;

    public decimal Balance { get; set; }

    public string Currency { get; set; } = "VND";
}
