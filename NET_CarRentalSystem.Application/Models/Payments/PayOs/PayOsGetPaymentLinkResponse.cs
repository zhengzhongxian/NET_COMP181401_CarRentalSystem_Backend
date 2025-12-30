using System.Text.Json.Serialization;

namespace NET_CarRentalSystem.Application.Models.Payments.PayOs;

public class PayOsGetPaymentLinkResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("orderCode")]
    public long OrderCode { get; set; }

    [JsonPropertyName("amount")]
    public long Amount { get; set; }

    [JsonPropertyName("amountPaid")]
    public long AmountPaid { get; set; }

    [JsonPropertyName("amountRemaining")]
    public long AmountRemaining { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("createdAt")]
    public string CreatedAt { get; set; } = "";

    [JsonPropertyName("cancellationReason")]
    public string? CancellationReason { get; set; }

    [JsonPropertyName("canceledAt")]
    public string? CanceledAt { get; set; }
}




