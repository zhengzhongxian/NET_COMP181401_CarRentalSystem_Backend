namespace NET_CarRentalSystem.Application.Models.Payments.VnPay;

public class VietQrRequest
{
    public string AccountNo { get; set; } = string.Empty;
    public string AccountName { get; set; } = string.Empty;
    public string AcqId { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string AddInfo { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;
    public string Template { get; set; } = string.Empty;
}
