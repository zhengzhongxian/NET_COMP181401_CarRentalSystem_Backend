namespace NET_CarRentalSystem.Application.Models.Payments.PayOs.Webhooks;

public class PayOsWebhook
{
    public string? Signature { get; set; } = default!;

    public PayOsWebhookData? Data { get; set; } = default!;
}

