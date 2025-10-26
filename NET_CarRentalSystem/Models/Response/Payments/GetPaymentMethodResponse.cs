namespace NET_CarRentalSystem.API.Models.Response.Payments;

public class GetPaymentMethodResponse
{
    public int Id { get; set; }

    public string? Method { get; set; }
}