using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.Twilio;

public class TwilioTechnicalException(string message, Exception? innerException = null) 
    : ExternalServiceException("Twilio", message)
{
    public Exception? InnerError { get; } = innerException;
}

