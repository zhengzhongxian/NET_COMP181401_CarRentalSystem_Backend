namespace NET_CarRentalSystem.Application.Features.Dashboard.Queries.Common;

public class TransactionAggregateResult
{
    public decimal TotalDeposit { get; set; }
    public decimal TotalFinalPayment { get; set; }
    public int TransactionCount { get; set; }
}

public class RefundAggregateResult
{
    public decimal TotalRefund { get; set; }
    public int RefundCount { get; set; }
}
