using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.PayOs;

public class PayOsTechnicalException(string message) : ExternalServiceException("PayOS", message);
