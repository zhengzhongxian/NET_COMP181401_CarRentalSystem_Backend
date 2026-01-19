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

    [JsonPropertyName("transactions")]
    public List<PaymentTransactionInfo>? Transactions { get; set; }
}

/// <summary>
/// Thông tin transaction từ PayOS
/// </summary>
public class PaymentTransactionInfo
{
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("amount")]
    public long Amount { get; set; }

    [JsonPropertyName("accountNumber")]
    public string? AccountNumber { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("transactionDateTime")]
    public string? TransactionDateTime { get; set; }

    [JsonPropertyName("counterAccountBankId")]
    public string? CounterAccountBankId { get; set; }

    [JsonPropertyName("counterAccountBankName")]
    public string? CounterAccountBankName { get; set; }

    [JsonPropertyName("counterAccountName")]
    public string? CounterAccountName { get; set; }

    [JsonPropertyName("counterAccountNumber")]
    public string? CounterAccountNumber { get; set; }

    [JsonPropertyName("virtualAccountName")]
    public string? VirtualAccountName { get; set; }

    [JsonPropertyName("virtualAccountNumber")]
    public string? VirtualAccountNumber { get; set; }
}




