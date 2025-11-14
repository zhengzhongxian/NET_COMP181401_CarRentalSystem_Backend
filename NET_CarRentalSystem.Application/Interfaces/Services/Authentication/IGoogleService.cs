using NET_CarRentalSystem.Application.Models.Authentication;

namespace NET_CarRentalSystem.Application.Interfaces.Services.Authentication;

public interface IGoogleService
{
    Task<GoogleUserPayload> ValidateTokenAsync(string idToken);
}