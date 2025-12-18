using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Locations.Commands.UpdateLocationThumbnailCommand;

public class UpdateLocationThumbnailCommand : ICommand<(string, string?)>
{
    public required Guid LocationId { get; init; }
    public required FileModel ThumbnailFile { get; init; }
}

public class UpdateLocationThumbnailCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint) 
    : IRequestHandler<UpdateLocationThumbnailCommand, (string, string?)>
{
    public async Task<(string, string?)> Handle(UpdateLocationThumbnailCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var repository = unitOfWork.GetWriteRepository<Location>();
            var location = await repository.GetByIdAsync(request.LocationId, ct);

            if (location == null)
                return (LocationMessage.Update.NotFound, null);

            if (!string.IsNullOrEmpty(location.PublicId))
            {
                await cloudinaryService.DeleteImageAsync(location.PublicId);
            }

            var uploadResult = await cloudinaryService.UploadImageAsync(
                request.ThumbnailFile,
                folder: "locations"
            );

            location.PublicId = uploadResult.PublicId;
            location.Thumbnail = uploadResult.SecureUrl;

            repository.Update(location);
            await unitOfWork.SaveChangesAsync(ct);

            var locationThumbnailUpdatedEvent = location.ToUpdatedEvent<Location, LocationThumbnailUpdatedEvent, Guid>(loc => new LocationThumbnailUpdatedEvent
            {
                Id = loc.Id,
                PublicId = loc.PublicId!,
                Thumbnail = loc.Thumbnail!,
                CreatedAt = loc.CreatedAt!.Value,
                CreatedBy = loc.CreatedBy,
                UpdatedAt = loc.UpdatedAt!.Value,
                UpdatedBy = loc.UpdatedBy
            });

            await publishEndpoint.Publish(locationThumbnailUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            return (LocationMessage.Update.Success, uploadResult.SecureUrl);
        }, cancellationToken);
    }
}