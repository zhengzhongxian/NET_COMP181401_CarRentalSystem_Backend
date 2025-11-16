using Google.Apis.Auth;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Models.Authentication;

namespace NET_CarRentalSystem.Infrastructure.Services.Authentication;

public class GoogleService(IOptions<GoogleSettings> googleSettings) : IGoogleService
{
    private readonly GoogleSettings _googleSettings = googleSettings.Value;

    public async Task<GoogleUserPayload> ValidateTokenAsync(string idToken)
    {
        var settings = new GoogleJsonWebSignature.ValidationSettings()
        {
            Audience = new List<string> { _googleSettings.ClientId }
        };
        
        var payload = await GoogleJsonWebSignature.ValidateAsync(idToken, settings);

        return new GoogleUserPayload
        {
            GoogleUserId = payload.Subject,
            Email = payload.Email,
            EmailVerified = payload.EmailVerified,
            Name = payload.Name,
            GivenName = payload.GivenName,
            FamilyName = payload.FamilyName,
            Picture = payload.Picture ?? null,
        };
    }
}