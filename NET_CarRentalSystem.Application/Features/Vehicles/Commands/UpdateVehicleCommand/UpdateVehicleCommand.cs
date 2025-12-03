using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Enums;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleCommand;

public class UpdateVehicleCommand : ICommand<bool>
{
    public required Guid VehicleId { get; set; }
    public required string NumberPlate { get; set; }
    public required string Manufacturer { get; set; }
    public required string Model { get; set; }
    public string? Color { get; set; }
    public int Mileage { get; set; }
    public decimal PricePerHour { get; set; }
    public string? Thumbnail { get; set; }
    public string? Description { get; set; }
    public float Rating { get; set; }
    public required string Status { get; set; }
    public string? ConditionNotes { get; set; }
    public string? RealTimeLocation { get; set; }
    public Guid? LocationId { get; set; }
    public Guid? VehicleCategoryId { get; set; }
    public Guid? FuelId { get; set; }
    public Guid? TransmissionId { get; set; }
    public string? Metadata { get; set; }
}

public class UpdateVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateVehicleCommand, bool>
{
    public async Task<bool> Handle(UpdateVehicleCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>().GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;
            
            vehicle.NumberPlate = request.NumberPlate;
            vehicle.Manufacturer = request.Manufacturer;
            vehicle.Model = request.Model;
            vehicle.Color = request.Color;
            vehicle.Mileage = request.Mileage;
            vehicle.PricePerHour = request.PricePerHour;
            if (!string.IsNullOrEmpty(request.Thumbnail)) vehicle.Thumbnail = request.Thumbnail;
            vehicle.Description = request.Description;
            vehicle.Rating = request.Rating;

            if (Enum.TryParse<VehicleStatus>(request.Status, out var status))
            {
                vehicle.Status = status;
            }

            vehicle.ConditionNotes = request.ConditionNotes;
            vehicle.RealTimeLocation = request.RealTimeLocation;
            vehicle.LocationId = request.LocationId;
            vehicle.VehicleCategoryId = request.VehicleCategoryId;
            vehicle.FuelId = request.FuelId;
            vehicle.TransmissionId = request.TransmissionId;
            vehicle.Metadata = request.Metadata;

            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            await unitOfWork.SaveChangesAsync(ct);
            
            string? locationName = null;
            string? categoryName = null;
            string? fuelName = null;
            string? transmissionName = null;

            if (vehicle.LocationId.HasValue)
            {
                var loc = await unitOfWork.GetReadRepository<Location>().GetByIdAsync(vehicle.LocationId.Value, ct);
                locationName = loc?.Name;
            }
            if (vehicle.VehicleCategoryId.HasValue)
            {
                var cat = await unitOfWork.GetReadRepository<VehicleCategory>().GetByIdAsync(vehicle.VehicleCategoryId.Value, ct);
                categoryName = cat?.CategoryCode;
            }
            if (vehicle.FuelId.HasValue)
            {
                var fuel = await unitOfWork.GetReadRepository<Fuel>().GetByIdAsync(vehicle.FuelId.Value, ct);
                fuelName = fuel?.Name;
            }
            if (vehicle.TransmissionId.HasValue)
            {
                var trans = await unitOfWork.GetReadRepository<Transmission>().GetByIdAsync(vehicle.TransmissionId.Value, ct);
                transmissionName = trans?.Name;
            }
            
            var vehicleUpdatedEvent = vehicle.ToUpdatedEvent<Vehicle, VehicleUpdatedEvent, Guid>(v => new VehicleUpdatedEvent
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
                Metadata = v.Metadata,
                Id = default,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(vehicleUpdatedEvent, ct);
            
            await unitOfWork.SaveChangesAsync(ct); 
            
            return true;
        }, cancellationToken);
    }
}