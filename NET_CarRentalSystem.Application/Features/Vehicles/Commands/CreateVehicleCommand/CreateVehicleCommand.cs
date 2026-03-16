using MediatR;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Ai;
using NET_CarRentalSystem.Application.Interfaces.Services.Search;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;
using Microsoft.Extensions.Logging;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;

public class CreateVehicleCommand : ICommand<Guid>
{
    public required string Manufacturer { get; set; }

    public required string Model { get; set; }

    public string? Title { get; set; }

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public FileModel? Thumbnail { get; set; }

    public string? Description { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }

    public string? Metadata { get; set; }

    public int RequiredLicenseClass { get; set; }
    
    public bool EnableAiVerification { get; set; } = true;
}

public class CreateVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    ICloudinaryService cloudinaryService,
    IAiImageVerificationService aiVerificationService,
    IAiTextEmbeddingService embeddingService,
    IVehicleSearchService vehicleSearchService,
    ILogger<CreateVehicleCommandHandler> logger) : IRequestHandler<CreateVehicleCommand, Guid>
{
    public async Task<Guid> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var newVehicle = new Vehicle
            {
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Title = request.Title,
                Color = request.Color,
                PricePerHour = request.PricePerHour,
                Thumbnail = null,
                Description = request.Description,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata,
                RequiredLicenseClass = request.RequiredLicenseClass
            };

            await unitOfWork.GetWriteRepository<Vehicle>().AddAsync(newVehicle, ct);
            await unitOfWork.SaveChangesAsync(ct);

            if (request.Thumbnail != null)
            {
                if (request.EnableAiVerification)
                {
                    using var memoryStream = new MemoryStream();
                    await request.Thumbnail.Content.CopyToAsync(memoryStream, ct);
                    var imageBytes = memoryStream.ToArray();
                    request.Thumbnail.Content.Position = 0;

                    var aiResult = await aiVerificationService.VerifyVehicleImageAsync(
                        imageBytes,
                        request.Thumbnail.FileName,
                        minConfidence: 0.7f,
                        cancellationToken: ct);

                    switch (aiResult.WasSkipped)
                    {
                        case false when !aiResult.IsValidVehicle:
                            throw new InvalidOperationException(VehicleMessage.AiVerification.InvalidImage);
                        case true:
                            logger.LogWarning("AI verification skipped: {Reason}", aiResult.SkipReason);
                            break;
                    }
                }
                
                var fileInfo = await cloudinaryService.UploadImageAsync(request.Thumbnail, "vehicles");

                if (!string.IsNullOrEmpty(fileInfo.SecureUrl))
                {
                    newVehicle.Thumbnail = fileInfo.SecureUrl;
                    await unitOfWork.SaveChangesAsync(ct);
                }
            }

            string? categoryName = null;
            string? fuelName = null;
            string? transmissionName = null;

            if (request.VehicleCategoryId.HasValue)
            {
                var category = await unitOfWork.GetWriteRepository<VehicleCategory>().GetByIdAsync(request.VehicleCategoryId.Value, ct);
                categoryName = category?.CategoryCode;
            }

            if (request.FuelId.HasValue)
            {
                var fuel = await unitOfWork.GetReadRepository<Fuel>().GetByIdAsync(request.FuelId.Value, ct);
                fuelName = fuel?.Name;
            }

            if (request.TransmissionId.HasValue)
            {
                var transmission = await unitOfWork.GetReadRepository<Transmission>()
                    .GetByIdAsync(request.TransmissionId.Value, ct);
                transmissionName = transmission?.Name;
            }

            var vehicleCreatedEvent = newVehicle.ToCreatedEvent<Vehicle, VehicleCreatedEvent, Guid>(v => new VehicleCreatedEvent
            {
                Manufacturer = v.Manufacturer,
                Model = v.Model,
                Title = v.Title,
                Color = v.Color,
                PricePerHour = v.PricePerHour,
                Thumbnail = v.Thumbnail,
                Description = v.Description,
                Rating = v.Rating,
                VehicleCategoryId = v.VehicleCategoryId,
                CategoryName = categoryName,
                FuelId = v.FuelId,
                FuelName = fuelName,
                TransmissionId = v.TransmissionId,
                TransmissionName = transmissionName,
                VehicleModelsJson = "[]",
                Metadata = v.Metadata,
                RequiredLicenseClass = v.RequiredLicenseClass,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(vehicleCreatedEvent, ct);

            await unitOfWork.SaveChangesAsync(ct);
            
            _ = Task.Run(async () =>
            {
                try
                {
                    var searchText = BuildSearchText(
                        newVehicle.Manufacturer, newVehicle.Model, newVehicle.Title,
                        newVehicle.Color, categoryName, fuelName, transmissionName,
                        newVehicle.Description);

                    var embedding = await embeddingService.GetEmbeddingAsync(searchText, ct);
                    if (embedding != null)
                    {
                        await vehicleSearchService.IndexVehicleAsync(
                            newVehicle.Id, searchText, embedding,
                            newVehicle.Manufacturer, newVehicle.Model,
                            newVehicle.Title, categoryName, ct);
                        
                        logger.LogInformation("Indexed vehicle {VehicleId} for hybrid search", newVehicle.Id);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogWarning(ex, "Failed to index vehicle {VehicleId} for search (non-critical)", newVehicle.Id);
                }
            }, CancellationToken.None);

            return newVehicle.Id;
        }, cancellationToken);
    }

    private static string BuildSearchText(
        string? manufacturer, string? model, string? title,
        string? color, string? category, string? fuel,
        string? transmission, string? description)
    {
        var parts = new[] { title, manufacturer, model, color, category, fuel, transmission, description }
            .Where(p => !string.IsNullOrWhiteSpace(p));
        return string.Join(" ", parts);
    }
}

