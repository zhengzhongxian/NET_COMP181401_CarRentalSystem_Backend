using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.Twilio;

public class TwilioBusinessException(string message, string? errorCode = null) 
    : DomainException(message)
{
    public string? TwilioErrorCode { get; } = errorCode;
}

