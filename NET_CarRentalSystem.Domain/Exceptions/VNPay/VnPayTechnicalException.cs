using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.VNPay;

public class VnPayTechnicalException(string message) : ExternalServiceException("VNPay", message);