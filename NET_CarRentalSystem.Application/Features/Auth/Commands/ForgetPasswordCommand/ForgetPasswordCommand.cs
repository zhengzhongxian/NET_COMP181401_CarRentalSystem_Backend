using MediatR;
using Microsoft.Extensions.Options;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Configurations;
using NET_CarRentalSystem.Application.Features.Auth.Common;
using NET_CarRentalSystem.Application.Interfaces.Services;
using NET_CarRentalSystem.Domain.Constants;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using NET_CarRentalSystem.Shared.CoreHelpers;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Auth.Commands.ForgetPasswordCommand;

public class ForgetPasswordCommand : ICommand<(string, bool)>
{
    public required string Email { get; set; }
}

public class ForgetPasswordCommandHandler(
    IUnitOfWork unitOfWork,
    ICacheService cacheService,
    IOptions<ResetPasswordSettings> resetPasswordSettings,
    IEmailService emailService,
    ISecurityService securityService) : IRequestHandler<ForgetPasswordCommand, (string, bool)>
{
    private readonly ResetPasswordSettings _resetPasswordSettings = resetPasswordSettings.Value;
    
    public async Task<(string, bool)> Handle(ForgetPasswordCommand request, CancellationToken cancellationToken)
    {
        var userRepo = unitOfWork.GetRepository<User>();
        var user = await userRepo.GetFirstOrDefaultAsync(u => 
                u.Email == request.Email &&
                !u.UserLogins.Any(l => l.LoginProvider == AppConstants.LoginProvider.Google) &&
                !u.UserRoles.Any(r => r.Role.Name == RoleConstants.Staff || 
                                      r.Role.Name == RoleConstants.Manager || 
                                      r.Role.Name == RoleConstants.Admin),
            cancellationToken: cancellationToken);

        if (user == null)
        {
            return (AuthMessage.ForgetPassword.EmailNotFound, false);
        }
        
        var key= CacheKeyHelper.GetResetPasswordKey(request.Email);
        var cachedResetPasswordDetailsJson = await cacheService.GetStringAsync(key, cancellationToken);
        
        var customer = await unitOfWork.GetRepository<Customer>().GetFirstAsync(c => 
            c.UserId == user.Id, 
            cancellationToken: cancellationToken);
        
        var fullName = $"{customer.FirstName} {customer.LastName}";
        
        if (cachedResetPasswordDetailsJson == null) 
            return await CreateAndSendResetPasswordEmail(request, key, fullName, cancellationToken);
        
        var cachedResetPasswordDetails = cachedResetPasswordDetailsJson.FromJson<ResetPasswordDetailsDto>()!;
        if (cachedResetPasswordDetails.AttemptCount < _resetPasswordSettings.MaxTokenAttempts)
            return await UpdateAndSendResetPasswordEmail(request, key, cachedResetPasswordDetails, fullName, cancellationToken);

        var remainingTime = cachedResetPasswordDetails.KeyExpiresAt - DateTime.UtcNow;
        var hoursRemaining = Math.Ceiling(remainingTime.TotalHours);
        if (hoursRemaining < 0) hoursRemaining = 0;

        var message = string.Format(AuthMessage.ForgetPassword.MaxAttempts, hoursRemaining.ToString("F0"));

        return (message, false);
    }

    private async Task<(string, bool)> UpdateAndSendResetPasswordEmail(ForgetPasswordCommand request, string key, ResetPasswordDetailsDto cachedResetPasswordDetails, string fullName, CancellationToken cancellationToken)
    {
        var encryptedEmail = securityService.EncryptAes(request.Email);
        var token = encryptedEmail + "." + TokenHelper.GenerateSecureToken();
        
        var resetPasswordDetails = new ResetPasswordDetailsDto
        {
            Token = token,
            AttemptCount = cachedResetPasswordDetails.AttemptCount + 1,
            ExpiryTime = DateTime.UtcNow.AddMinutes(_resetPasswordSettings.TokenExpiryMinutes),
            KeyExpiresAt = cachedResetPasswordDetails.KeyExpiresAt
        };
        await cacheService.SetStringAsync(key, resetPasswordDetails.ToJson(), resetPasswordDetails.KeyExpiresAt, cancellationToken);
        await SendResetPasswordEmail(request.Email, token, fullName, cancellationToken);

        return (AuthMessage.ForgetPassword.Success, true);
    }

    private async Task<(string, bool)> CreateAndSendResetPasswordEmail(ForgetPasswordCommand request, string key, string fullName, CancellationToken cancellationToken)
    {
        var encryptedEmail = securityService.EncryptAes(request.Email);
        var token = encryptedEmail + "." + TokenHelper.GenerateSecureToken();
        
        var resetPasswordDetails = new ResetPasswordDetailsDto
        {
            Token = token,
            AttemptCount = 1,
            ExpiryTime = DateTime.UtcNow.AddMinutes(_resetPasswordSettings.TokenExpiryMinutes),
            KeyExpiresAt = DateTime.UtcNow.AddHours(_resetPasswordSettings.KeyExpiryHours)
        };
        
        await cacheService.SetStringAsync(key, resetPasswordDetails.ToJson(), resetPasswordDetails.KeyExpiresAt, cancellationToken);
        await SendResetPasswordEmail(request.Email, token, fullName, cancellationToken);

        return (AuthMessage.ForgetPassword.Success, true);
    }

    private async Task SendResetPasswordEmail(string requestEmail, string token, string fullName, CancellationToken cancellationToken)
    {
        const string templateName = AppConstants.EmailTemplates.ResetPassword;
        
        var placeholders = new Dictionary<string, string>
        {
            { "{Name}", fullName },
            { "{ClientUrl}", _resetPasswordSettings.ClientUrl!},
            { "{Token}", token },
            { "{ExpiryTime}", _resetPasswordSettings.TokenExpiryMinutes.ToString() }
        };

        await emailService.SendTemplateEmailAsync(requestEmail, "Đặt lại mật khẩu Renticar", templateName, placeholders, cancellationToken);
    }
}