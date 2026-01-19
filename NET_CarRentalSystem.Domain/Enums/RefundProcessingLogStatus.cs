namespace NET_CarRentalSystem.Domain.Enums;

public enum RefundProcessingLogStatus
{
    RetryScheduled = 0,
    
    ManualInterventionRequired = 1,
    
    ResolvedManually = 2,
    
    Cancelled = 3
}

