using NET_CarRentalSystem.Domain.Exceptions.Common;

namespace NET_CarRentalSystem.Domain.Exceptions.Twilio;

public class TwilioNotConfiguredException() 
    : ExternalServiceException("Twilio", "Twilio service is not configured properly. Please check AccountSid, AuthToken and ServiceSid settings.", 503);

