using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.PayOs;

public class PayOsBusinessException(string message, string code) : DomainException(message)
{
    public string PayOsResponseCode { get; } = code;
}
