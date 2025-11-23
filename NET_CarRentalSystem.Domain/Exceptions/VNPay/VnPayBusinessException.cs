using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.VNPay;

public class VnPayBusinessException(string message, string code) : DomainException(message)
{
    public string VnPayResponseCode { get; } = code;
}