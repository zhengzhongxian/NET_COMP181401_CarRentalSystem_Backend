using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Models.DTOs.AuthDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.GoogLoginCommand;

public class GoogleLoginCommand : ICommand<(string, GoogleLoginDto?)>
{
    public required string IdToken { get; set; }
    public required string? IpAddress { get; set; }
    public required string? DeviceName { get; set; }
}

public class GoogLoginCommandHandler(
    IUnitOfWork  unitOfWork,
    IGoogleService googleService,
    ITokenService tokenService,
    ICacheService cacheService) : IRequestHandler<GoogleLoginCommand, (string, GoogleLoginDto?)>
{
    public async Task<(string, GoogleLoginDto?)> Handle(GoogleLoginCommand request, CancellationToken cancellationToken)
    {
        var payload = await googleService.ValidateTokenAsync(request.IdToken);

        if (!payload.EmailVerified)
        {
            return (AuthMessage.GoogleLogin.UnverifiedEmail, null);
        }

        var user = await unitOfWork.GetRepository<User>().GetFirstOrDefaultAsync(u => u.Email == payload.Email && u.IsVerified);
        
        var ggloginDto = new GoogleLoginDto();
        
        if (user == null)
        {
            ggloginDto.Email = payload.Email;
            ggloginDto.GivenName = payload.GivenName;
            ggloginDto.FamilyName = payload.FamilyName;
            
            return (AuthMessage.GoogleLogin.NotFound, ggloginDto);
        }

        if (user.Status == UserStatus.Banned) return (AuthMessage.GoogleLogin.Banned, null);
        
        var tokens = await tokenService.GenerateTokensAsync(user);
        ggloginDto.TokenResponse = tokens;
        
        var userSession = new UserSession
        {
            UserId = user.Id,
            RefreshToken = tokens.RefreshToken,
            RefreshTokenExpiryTime = tokens.RefreshTokenExpiry,
            IpAddress = request.IpAddress,
            DeviceName = request.DeviceName
        };
        
        await unitOfWork.GetRepository<UserSession>().AddAsync(userSession, cancellationToken);
        user.Status = UserStatus.LoggedIn;
        unitOfWork.GetRepository<User>().Update(user); 
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        var sessionCacheDto = new UserSessionCacheDto
        {
            UserId = user.Id,
            IsRevoked = false
        };
        var sessionCacheJson = sessionCacheDto.ToJson();
        
        await cacheService.SetStringAsync(
            tokens.RefreshToken,
            sessionCacheJson,
            tokens.RefreshTokenExpiry,
            cancellationToken);
        
        return (AuthMessage.GoogleLogin.Success, ggloginDto);
    }
}