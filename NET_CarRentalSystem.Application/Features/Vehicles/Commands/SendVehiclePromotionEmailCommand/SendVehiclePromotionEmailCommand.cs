using MediatR;
using Microsoft.Extensions.Configuration;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Interfaces.Services.Notifications;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.SendVehiclePromotionEmailCommand;

public class SendVehiclePromotionEmailCommand : ICommand<(bool, string)>
{
    public Guid VehicleId { get; set; }
    
    public List<string> Emails { get; set; } = [];
    
    public string? CustomMessage { get; set; }
}

public class SendVehiclePromotionEmailCommandHandler(
    IUnitOfWork unitOfWork,
    IEmailService emailService,
    IConfiguration configuration) : IRequestHandler<SendVehiclePromotionEmailCommand, (bool, string)>
{
    public async Task<(bool, string)> Handle(SendVehiclePromotionEmailCommand request, CancellationToken cancellationToken)
    {
        // Get vehicle details from read flat
        var vehicle = await unitOfWork.GetReadRepository<VehicleReadFlat>()
            .GetFirstOrDefaultAsync(v => v.Id == request.VehicleId, 
                cancellationToken: cancellationToken);

        if (vehicle == null)
        {
            return (false, VehicleEmailMessage.SendPromotion.VehicleNotFound);
        }
        
        var images = string.IsNullOrEmpty(vehicle.ImagesJson) 
            ? []
            : vehicle.ImagesJson.FromJson<List<GetVehicleImageDto>>() ?? [];
            
        var attributes = string.IsNullOrEmpty(vehicle.AttributesJson) 
            ? []
            : vehicle.AttributesJson.FromJson<List<GetVehicleAttributeDto>>() ?? [];

        var appUrl = configuration[KeyConstants.EmailRedirectUrl] ?? "http://localhost:5173";
        
        var placeholders = new Dictionary<string, string>
        {
            { "{{VehicleName}}", $"{vehicle.Manufacturer} {vehicle.Model}" },
            { "{{VehicleColor}}", vehicle.Color ?? "N/A" },
            { "{{PricePerHour}}", $"{vehicle.PricePerHour:N0}" },
            { "{{CategoryName}}", vehicle.CategoryName ?? "N/A" },
            { "{{FuelName}}", vehicle.FuelName ?? "N/A" },
            { "{{TransmissionName}}", vehicle.TransmissionName ?? "N/A" },
            { "{{Description}}", vehicle.Description ?? "" },
            { "{{CustomMessage}}", request.CustomMessage ?? "" },
            { "{{VehicleImages}}", GenerateImageGalleryFromJson(images) },
            { "{{VehicleAttributes}}", GenerateAttributesFromJson(attributes) },
            { "{{AppUrl}}", appUrl },
            { "{{VehicleId}}", vehicle.Id.ToString() }
        };
        
        var emailTasks = request.Emails.Select(async email =>
        {
            try
            {
                await emailService.SendTemplateEmailViaGmailApiAsync(
                    email,
                    $"Xe mới cho bạn: {vehicle.Manufacturer} {vehicle.Model}",
                    AppConstants.EmailTemplates.VehiclePromotion,
                    placeholders,
                    cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        });

        var results = await Task.WhenAll(emailTasks);
        
        return results.All(result => result) ? (true, VehicleEmailMessage.SendPromotion.Success) : (false, VehicleEmailMessage.SendPromotion.Error);
    }
    

    private static string GenerateImageGalleryFromJson(List<GetVehicleImageDto> images)
    {
        if (images.Count == 0)
        {
            return "<div class=\"no-images\">Chưa có hình ảnh</div>";
        }

        var imageHtml = images.Take(4).Select(img => $"""
            <div class="vehicle-image">
                <img src="{img.ImageUrl}" alt="Vehicle Image">
            </div>
            """).ToList();

        return string.Join("", imageHtml);
    }

    private static string GenerateAttributesFromJson(List<GetVehicleAttributeDto> attributes)
    {
        if (attributes.Count == 0)
        {
            return "<div class=\"no-attributes\">Chưa có thông tin chi tiết</div>";
        }

        var attributeHtml = attributes.Select(attr => $"""
            <div class="attribute-item">
                <span class="attribute-name">{attr.AttributeKey}:</span>
                <span class="attribute-value">{attr.AttributeValue}</span>
            </div>
            """).ToList();

        return string.Join("", attributeHtml);
    }
}
