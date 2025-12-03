using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.UpdateVehicleThumbnailCommand;

public class UpdateVehicleThumbnailCommand : ICommand<bool>
{
    public required Guid VehicleId { get; set; }
    public required FileModel Thumbnail { get; set; }
}

public class UpdateVehicleThumbnailCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint) : IRequestHandler<UpdateVehicleThumbnailCommand, bool>
{
    public async Task<bool> Handle(UpdateVehicleThumbnailCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var oldThumbnailUrl = vehicle.Thumbnail;
            
            var newThumbnailUrl = await cloudinaryService.UploadImageAsync(request.Thumbnail, "vehicles");
            
            vehicle.Thumbnail = newThumbnailUrl.Url;
            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            await unitOfWork.SaveChangesAsync(ct);
            
            if (!string.IsNullOrEmpty(oldThumbnailUrl))
            {
            }
            
            var evt = new VehicleThumbnailUpdatedEvent
            {
                Id = vehicle.Id,
                Thumbnail = newThumbnailUrl.SecureUrl,
                CreatedAt = vehicle.CreatedAt!.Value,
                CreatedBy = vehicle.CreatedBy,
                UpdatedAt = vehicle.UpdatedAt!.Value,
                UpdatedBy = vehicle.UpdatedBy
            };

            await publishEndpoint.Publish(evt, ct);
            
            await unitOfWork.SaveChangesAsync(ct); 

            return true;
        }, cancellationToken);
    }
}