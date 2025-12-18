using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Application.Models.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Commands.CreateLocationCommand;

public class CreateLocationCommand : ICommand<Guid>
{
    public required string Name { get; init; }
    public required string Address { get; init; }
    public required string City { get; init; }
    public string? PhoneNumber { get; init; }
    public string? OpeningHours { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public string? Description { get; init; }
    public required FileModel ThumbnailFile { get; init; }
}

public class CreateLocationCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint) : IRequestHandler<CreateLocationCommand, Guid>
{
    public async Task<Guid> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var uploadResult = await cloudinaryService.UploadImageAsync(
                request.ThumbnailFile,
                folder: "locations"
            );

            var newLocation = new Location
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Address = request.Address,
                City = request.City,
                PhoneNumber = request.PhoneNumber,
                OpeningHours = request.OpeningHours,
                Latitude = request.Latitude,
                Longitude = request.Longitude,
                Description = request.Description,
                PublicId = uploadResult.PublicId,
                Thumbnail = uploadResult.SecureUrl
            };

            await unitOfWork.GetWriteRepository<Location>().AddAsync(newLocation, ct);
            await unitOfWork.SaveChangesAsync(ct);

            var locationCreatedEvent = newLocation.ToCreatedEvent<Location, LocationCreatedEvent, Guid>(location => new LocationCreatedEvent
            {
                Id = location.Id,
                Name = location.Name,
                Address = location.Address,
                City = location.City,
                PhoneNumber = location.PhoneNumber,
                OpeningHours = location.OpeningHours,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Description = location.Description,
                PublicId = location.PublicId,
                Thumbnail = location.Thumbnail,
                CreatedAt = location.CreatedAt!.Value,
                CreatedBy = location.CreatedBy,
                UpdatedAt = location.UpdatedAt!.Value,
                UpdatedBy = location.UpdatedBy
            });

            await publishEndpoint.Publish(locationCreatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            return newLocation.Id;
        }, cancellationToken);
    }
}