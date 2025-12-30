namespace NET_CarRentalSystem.Domain.Enums;

public enum TransactionLogStatus
{
    Failed = 1,
    Retrying,
    Resolved,
    ManualInterventionRequired
}