using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Payments.PayOs;

public class PayOsCreateResponse
{
    [JsonPropertyName("bin")]
    public string Bin { get; set; } = "";

    [JsonPropertyName("accountNumber")]
    public string AccountNumber { get; set; } = "";

    [JsonPropertyName("accountName")]
    public string AccountName { get; set; } = "";

    [JsonPropertyName("amount")]
    public long Amount { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = "";

    [JsonPropertyName("orderCode")]
    public long OrderCode { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = "";

    [JsonPropertyName("paymentLinkId")]
    public string PaymentLinkId { get; set; } = "";

    [JsonPropertyName("expiredAt")]
    public long? ExpiredAt { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("checkoutUrl")]
    public string CheckoutUrl { get; set; } = "";

    [JsonPropertyName("qrCode")]
    public string QrCode { get; set; } = "";
}

