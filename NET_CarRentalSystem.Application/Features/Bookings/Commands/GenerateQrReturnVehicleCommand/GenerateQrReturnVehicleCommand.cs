using MediatR;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Caching;
using NET_CarRentalSystem.Application.Interfaces.Services.Security;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.CoreHelpers;

namespace NET_CarRentalSystem.Application.Features.Bookings.Commands.GenerateQrReturnVehicleCommand;

public class GenerateQrReturnVehicleCommand : ICommand<(string, string)>
{
    public Guid LocationId { get; init; }
}

public class GenerateQrReturnVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    IConfiguration configuration,
    ICacheService cacheService,
    ICryptographyService cryptographyService) : IRequestHandler<GenerateQrReturnVehicleCommand, (string, string)>
{
    private readonly int _expireInSecond = int.Parse(configuration[KeyConstants.QrReturnVehicleUrl.ExpireInSecond] ?? "30");
    private readonly string _baseUrl = configuration[KeyConstants.QrReturnVehicleUrl.BaseUrl] ?? "http://localhost:5173/qrCode=";

    public async Task<(string, string)> Handle(GenerateQrReturnVehicleCommand request, CancellationToken ct)
    {
        var locatioRepo = unitOfWork.GetReadRepository<Location>();
        var exist = await locatioRepo.ExistsAsync(l => l.Id == request.LocationId, ct);

        if (!exist)
            return (string.Empty, LocationMessage.Get.NotFound);
        
        var rawToken = TokenHelper.GenerateSecureToken();
        
        var payload = $"{request.LocationId}:{rawToken}";
        
        var encrypted = cryptographyService.EncryptAes(payload);
        
        var urlSafe = TokenHelper.ToUrlSafeBase64(encrypted);
        
        var cacheKey = CacheKeyHelper.GetQrReturnVehicleKey(rawToken);
        var expiry = DateTime.UtcNow.AddSeconds(_expireInSecond);
        await cacheService.SetStringAsync(cacheKey, encrypted, expiry, ct);
        
        var fullUrl = _baseUrl + urlSafe;

        return (fullUrl, LocationMessage.Get.Success);
    }
}