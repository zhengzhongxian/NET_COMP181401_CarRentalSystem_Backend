namespace NET_CarRentalSystem.Application.Models.Sms;

public class SpeedSmsSendResponse
{
    public string Status { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string? Message { get; set; }

    public SpeedSmsSendData? Data { get; set; }

    public bool IsSuccess => Status == "success" && Code == "00";
}

public class SpeedSmsSendData
{
    public string TranId { get; set; } = string.Empty;

    public int TotalSMS { get; set; }

    public decimal TotalPrice { get; set; }

    public string[]? InvalidPhone { get; set; }
}
