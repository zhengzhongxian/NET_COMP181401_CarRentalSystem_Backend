using MediatR;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.CreateVehicleCommand;

public class CreateVehicleCommand : ICommand<Guid>
{
    public required string NumberPlate { get; set; }

    public required string Manufacturer { get; set; }

    public required string Model { get; set; }

    public string? Color { get; set; }

    public int Mileage { get; set; }

    public decimal PricePerHour { get; set; }

    public FileModel? Thumbnail { get; set; }

    public string? Description { get; set; }

    public string? ConditionNotes { get; set; }

    public Guid? LocationId { get; set; }

    public Guid? VehicleCategoryId { get; set; }

    public Guid? FuelId { get; set; }

    public Guid? TransmissionId { get; set; }

    public string? Metadata { get; set; }
}

public class CreateVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    ICloudinaryService cloudinaryService) : IRequestHandler<CreateVehicleCommand, Guid>
{
    public async Task<Guid> Handle(CreateVehicleCommand request, CancellationToken cancellationToken)
    {
    return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var newVehicle = new Vehicle
            {
                NumberPlate = request.NumberPlate,
                Manufacturer = request.Manufacturer,
                Model = request.Model,
                Color = request.Color,
                Mileage = request.Mileage,
                PricePerHour = request.PricePerHour,
                Thumbnail = null,
                Description = request.Description,
                Status = VehicleStatus.Available,
                ConditionNotes = request.ConditionNotes,
                LocationId = request.LocationId,
                VehicleCategoryId = request.VehicleCategoryId,
                FuelId = request.FuelId,
                TransmissionId = request.TransmissionId,
                Metadata = request.Metadata
            };
            
            await unitOfWork.GetWriteRepository<Vehicle>().AddAsync(newVehicle, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            if (request.Thumbnail != null)
            {
                var fileInfo = await cloudinaryService.UploadImageAsync(request.Thumbnail, "vehicles");
                
                if (!string.IsNullOrEmpty(fileInfo.SecureUrl))
                {
                    newVehicle.Thumbnail = fileInfo.SecureUrl;
                    await unitOfWork.SaveChangesAsync(ct);
                }
            }

            string? locationName = null;
            string? categoryName = null;
            string? fuelName = null;
            string? transmissionName = null;

            if (request.LocationId.HasValue)
            {
                var location = await unitOfWork.GetReadRepository<Location>().GetByIdAsync(request.LocationId.Value, ct);
                locationName = location?.Name;
            }

            if (request.VehicleCategoryId.HasValue)
            {
                var category = await unitOfWork.GetReadRepository<VehicleCategory>().GetByIdAsync(request.VehicleCategoryId.Value, ct);
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
                NumberPlate = v.NumberPlate,
                Manufacturer = v.Manufacturer,
                Model = v.Model,
                Color = v.Color,
                Mileage = v.Mileage,
                PricePerHour = v.PricePerHour,
                Thumbnail = v.Thumbnail,
                Description = v.Description,
                LastCheckoutAt = v.LastCheckoutAt,
                Rating = v.Rating,
                Status = v.Status.ToString(),
                ConditionNotes = v.ConditionNotes,
                RealTimeLocation = v.RealTimeLocation,
                LocationId = v.LocationId,
                LocationName = locationName,
                VehicleCategoryId = v.VehicleCategoryId,
                CategoryName = categoryName,
                FuelId = v.FuelId,
                FuelName = fuelName,
                TransmissionId = v.TransmissionId,
                TransmissionName = transmissionName,
                ImagesJson = null,
                AttributesJson = null,
                Metadata = v.Metadata,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(vehicleCreatedEvent, ct);
            
            await unitOfWork.SaveChangesAsync(ct); 
            
            return newVehicle.Id;
        }, cancellationToken);
    }
}
