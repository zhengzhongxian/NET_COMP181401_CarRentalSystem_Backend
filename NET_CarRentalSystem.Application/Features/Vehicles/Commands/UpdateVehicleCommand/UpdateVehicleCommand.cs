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

    public required string Manufacturer { get; set; }

    public required string Model { get; set; }

    public string? Color { get; set; }

    public decimal PricePerHour { get; set; }

    public string? Thumbnail { get; set; }

    public string? Description { get; set; }

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
            
            vehicle.Manufacturer = request.Manufacturer;
            vehicle.Model = request.Model;
            vehicle.Color = request.Color;
            vehicle.PricePerHour = request.PricePerHour;
            if (!string.IsNullOrEmpty(request.Thumbnail)) vehicle.Thumbnail = request.Thumbnail;
            vehicle.Description = request.Description;
            vehicle.VehicleCategoryId = request.VehicleCategoryId;
            vehicle.FuelId = request.FuelId;
            vehicle.TransmissionId = request.TransmissionId;
            vehicle.Metadata = request.Metadata;

            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            await unitOfWork.SaveChangesAsync(ct);
            
            string? categoryName = null;
            string? fuelName = null;
            string? transmissionName = null;

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
                Manufacturer = v.Manufacturer,
                Model = v.Model,
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