using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.VNPay;

public class VnPayTechnicalException : ExternalServiceException
{
    public VnPayTechnicalException(string message) : base("VNPay", message) { }
}