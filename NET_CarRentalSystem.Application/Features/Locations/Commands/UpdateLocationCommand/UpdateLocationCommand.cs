using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Update;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Locations.Commands.UpdateLocationCommand;

public class UpdateLocationCommand : ICommand<(string, UpdateLocationDto?)>
{
    public required Guid LocationId { get; init; }
    public required string Name { get; init; }
    public required string Address { get; init; }
    public required string City { get; init; }
    public string? PhoneNumber { get; init; }
    public string? OpeningHours { get; init; }
    public double? Latitude { get; init; }
    public double? Longitude { get; init; }
    public string? Description { get; init; }
}

public class UpdateLocationCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint) 
    : IRequestHandler<UpdateLocationCommand, (string, UpdateLocationDto?)>
{
    public async Task<(string, UpdateLocationDto?)> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var repository = unitOfWork.GetWriteRepository<Location>();
            var location = await repository.GetByIdAsync(request.LocationId, ct);

            if (location == null)
                return (LocationMessage.Update.NotFound, null);

            location.Name = request.Name;
            location.Address = request.Address;
            location.City = request.City;
            location.PhoneNumber = request.PhoneNumber;
            location.OpeningHours = request.OpeningHours;
            location.Latitude = request.Latitude;
            location.Longitude = request.Longitude;
            location.Description = request.Description;

            repository.Update(location);
            await unitOfWork.SaveChangesAsync(ct);

            var locationUpdatedEvent = location.ToUpdatedEvent<Location, LocationUpdatedEvent, Guid>(loc => new LocationUpdatedEvent
            {
                Id = loc.Id,
                Name = loc.Name,
                Address = loc.Address,
                City = loc.City,
                PhoneNumber = loc.PhoneNumber,
                OpeningHours = loc.OpeningHours,
                Latitude = loc.Latitude,
                Longitude = loc.Longitude,
                Description = loc.Description,
                CreatedAt = loc.CreatedAt!.Value,
                CreatedBy = loc.CreatedBy,
                UpdatedAt = loc.UpdatedAt!.Value,
                UpdatedBy = loc.UpdatedBy
            });

            await publishEndpoint.Publish(locationUpdatedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            var dto = new UpdateLocationDto
            {
                LocationId = location.Id,
                Name = location.Name,
                Address = location.Address,
                City = location.City,
                PhoneNumber = location.PhoneNumber,
                OpeningHours = location.OpeningHours,
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Description = location.Description
            };

            return (LocationMessage.Update.Success, dto);
        }, cancellationToken);
    }
}