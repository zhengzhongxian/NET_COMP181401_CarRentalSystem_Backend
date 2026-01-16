namespace NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;

public class PayOsWebhookData
{
    public long OrderCode { get; set; }

    public long Amount { get; set; }

    public string Description { get; set; } = string.Empty;

    public string AccountNumber { get; set; } = string.Empty;

    public string Reference { get; set; } = string.Empty;

    public string TransactionDateTime { get; set; } = string.Empty;

    public string Currency { get; set; } = "VND";

    public string PaymentLinkId { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public string? CounterAccountBankId { get; set; }

    public string? CounterAccountBankName { get; set; }

    public string? CounterAccountName { get; set; }

    public string? CounterAccountNumber { get; set; }

    public string? VirtualAccountName { get; set; }

    public string? VirtualAccountNumber { get; set; }
}

