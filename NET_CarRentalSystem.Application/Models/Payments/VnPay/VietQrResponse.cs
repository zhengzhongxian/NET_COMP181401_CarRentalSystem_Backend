namespace NET_CarRentalSystem.Application.Models.Payments.VnPay;

public class VietQrResponse
{
    public string Code { get; set; } = string.Empty;
    public string Desc { get; set; } = string.Empty;
    public VietQrData? Data { get; set; }
}
