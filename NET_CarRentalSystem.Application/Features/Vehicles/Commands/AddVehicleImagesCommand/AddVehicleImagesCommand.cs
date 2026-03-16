using MassTransit;
using MediatR;
using Microsoft.Extensions.Logging;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.AddVehicleImagesCommand;

public class AddVehicleImagesCommand : ICommand<(bool Success, string? Message)>
{
    public required Guid VehicleId { get; set; }
    
    public required List<FileModel> Images { get; set; }
    
    public bool EnableAiVerification { get; set; } = true;
}

public class AddVehicleImagesCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IAiImageVerificationService aiVerificationService,
    IPublishEndpoint publishEndpoint,
    ILogger<AddVehicleImagesCommandHandler> logger) : IRequestHandler<AddVehicleImagesCommand, (bool Success, string? Message)>
{
    public async Task<(bool Success, string? Message)> Handle(AddVehicleImagesCommand request, CancellationToken cancellationToken)
    {
        if (request.EnableAiVerification && request.Images.Count > 0)
        {
            var imageBatch = new List<(byte[] Data, string Filename)>();
            
            foreach (var image in request.Images)
            {
                using var memoryStream = new MemoryStream();
                await image.Content.CopyToAsync(memoryStream, cancellationToken);
                imageBatch.Add((memoryStream.ToArray(), image.FileName));
                image.Content.Position = 0;
            }

            var batchResult = await aiVerificationService.VerifyVehicleImagesBatchAsync(
                imageBatch,
                minConfidence: 0.7f,
                cancellationToken: cancellationToken);
            
            switch (batchResult.WasSkipped)
            {
                case false when !batchResult.AllValid:
                    return (false, VehicleMessage.AiVerification.InvalidImage);
                case true:
                    logger.LogWarning("AI batch verification skipped: {Reason}", batchResult.SkipReason);
                    break;
            }
        }

        var success = await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;
            
            var existingImages = await unitOfWork.GetWriteRepository<VehicleImage>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);
            
            var uploadedResults = await cloudinaryService.UploadMultipleImagesAsync(request.Images, "vehicle_gallery");

            var newImages = uploadedResults.Select((info, index) => new VehicleImage
            {
                VehicleId = vehicle.Id,
                ImageUrl = info.SecureUrl,
                PublicId = info.PublicId,
                Order = 0, 
                AltText = request.Images.ElementAtOrDefault(index)?.FileName ?? "Vehicle Image"
            }).ToList();

            if (newImages.Count > 0)
            {
                await unitOfWork.GetWriteRepository<VehicleImage>().AddRangeAsync(newImages, ct);
                unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
                await unitOfWork.SaveChangesAsync(ct);
            }
            
            var allImages = existingImages.Concat(newImages).Select(i => new 
            {
                i.ImageUrl,
                i.Order,
                i.AltText,
                i.PublicId
            }).ToList();

            var imagesJson = allImages.ToJson();
            
            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleImagesUpdatedEvent, Guid>(_ => new VehicleImagesUpdatedEvent
            {
                ImagesJson = imagesJson,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(evt, ct);
            
            await unitOfWork.SaveChangesAsync(ct); 
            
            return true;
        }, cancellationToken);

        return success 
            ? (true, VehicleMessage.AddImages.Success) 
            : (false, VehicleMessage.AddImages.NotFound);
    }
}