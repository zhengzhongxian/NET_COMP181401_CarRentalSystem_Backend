using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleImagesCommand;

public class DeleteVehicleImagesCommand : ICommand<bool>
{
    public required Guid VehicleId { get; init; }
    public required List<string> PublicIds { get; init; }
}

public class DeleteVehicleImagesCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint) : IRequestHandler<DeleteVehicleImagesCommand, bool>
{
    public async Task<bool> Handle(DeleteVehicleImagesCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>()
                .GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null) return false;

            var imagesToDelete = await unitOfWork.GetWriteRepository<VehicleImage>()
                .GetListAsync(x => x.VehicleId == request.VehicleId && x.PublicId != null && request.PublicIds.Contains(x.PublicId), ct);

            if (imagesToDelete.Count == 0) return false;

            await cloudinaryService.DeleteMultipleImagesAsync(request.PublicIds);

            foreach (var image in imagesToDelete)
            {
                unitOfWork.GetWriteRepository<VehicleImage>().Remove(image, hardDelete: true);
            }

            unitOfWork.GetWriteRepository<Vehicle>().Update(vehicle);
            await unitOfWork.SaveChangesAsync(ct);

            var remainingImages = await unitOfWork.GetWriteRepository<VehicleImage>()
                .GetListAsync(x => x.VehicleId == request.VehicleId, ct);

            var imagesJson = remainingImages.Select(i => new
            {
                i.ImageUrl,
                i.Order,
                i.AltText,
                i.PublicId
            }).ToList().ToJson();

            var evt = vehicle.ToUpdatedEvent<Vehicle, VehicleImagesUpdatedEvent, Guid>(_ => new VehicleImagesUpdatedEvent
            {
                ImagesJson = imagesJson,
                Id = vehicle.Id,
                CreatedAt = default,
                CreatedBy = null,
                UpdatedAt = default,
                UpdatedBy = null
            });

            await publishEndpoint.Publish(evt, ct);
            await unitOfWork.SaveChangesAsync(ct);
            return true;
        }, cancellationToken);
    }
}