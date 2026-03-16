namespace NET_CarRentalSystem.Application.Models.Sms;

public class SpeedSmsStatusResponse
{
    public string Status { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string? Message { get; set; }

    public List<SpeedSmsStatusData>? Data { get; set; }

    public bool IsSuccess => Status == "success" && Code == "00";
}

public class SpeedSmsStatusData
{
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// 0: Đang chờ gửi, -1: Đang gửi, 1: Gửi thành công, 2: Gửi lỗi
    /// </summary>
    public int Status { get; set; }
}
