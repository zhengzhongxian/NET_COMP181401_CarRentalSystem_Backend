namespace NET_CarRentalSystem.Domain.Enums;

public enum WebhookEventType
{
    PaymentCompleted,

    PaymentCancelled,

    PaymentExpired,

    RefundCompleted,

    RefundFailed
}
