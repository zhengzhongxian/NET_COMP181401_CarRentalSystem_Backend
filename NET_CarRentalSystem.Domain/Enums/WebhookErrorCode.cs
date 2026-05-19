namespace NET_CarRentalSystem.Domain.Enums;

public enum WebhookErrorCode
{
    None = 0,
    TransactionNotFound = 1,
    TransactionAlreadyProcessed = 2,
    BookingNotFound = 3,
    VehicleNotFound = 4,
    InvalidPayload = 5,
    BookingAlreadyCancelled = 6,
    CustomerLocked = 7,
    DispatchFailed = 8,
    UnknownError = 99
}
