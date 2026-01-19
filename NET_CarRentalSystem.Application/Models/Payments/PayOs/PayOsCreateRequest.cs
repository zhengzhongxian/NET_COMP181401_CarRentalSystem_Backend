namespace NET_CarRentalSystem.Application.Models.Payments.PayOs;

public class PayOsCreateRequest
{
    public required long TransactionCode { get; set; }
    
    public required long TotalAmount { get; set; }
    
    public required string TransactorName { get; set; }
    
    public required string TransactorEmail { get; set; }
    
    public required string TransactorPhone { get; set; }
    
    public required string TransactorAddress { get; set; }
    
    public required string Description { get; set; }
}