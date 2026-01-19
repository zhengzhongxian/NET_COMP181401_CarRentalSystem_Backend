using MassTransit;
using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Locations.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Application.Interfaces.Services.Storage;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants.Business;

namespace NET_CarRentalSystem.Application.Features.Locations.Commands.DeleteLocationCommand;

public class DeleteLocationCommand : ICommand<(string, bool)>
{
    public required Guid LocationId { get; init; }
}

public class DeleteLocationCommandHandler(
    IUnitOfWork unitOfWork,
    ICloudinaryService cloudinaryService,
    IPublishEndpoint publishEndpoint,
    ICurrentUserService currentUserService) 
    : IRequestHandler<DeleteLocationCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var repository = unitOfWork.GetWriteRepository<Location>();
            var location = await repository.GetByIdAsync(request.LocationId, ct);
            
            if (location == null)
                return (LocationMessage.Delete.NotFound, false);

            var vehiclesCount = await unitOfWork.GetReadRepository<VehicleModel>()
                .CountAsync(v => v.LocationId == request.LocationId, ct);
                
            if (vehiclesCount > 0)
                return (LocationMessage.Delete.HasVehicles, false);

            if (!string.IsNullOrEmpty(location.PublicId))
            {
                await cloudinaryService.DeleteImageAsync(location.PublicId);
            }

            location.IsDeleted = true;
            location.DeletedBy = currentUserService.GetUserId().ToString();
            location.DeletedAt = DateTime.UtcNow;
            
            repository.Update(location);
            await unitOfWork.SaveChangesAsync(ct);

            var locationDeletedEvent = location.ToDeletedEvent<Location, LocationDeletedEvent, Guid>(loc => new LocationDeletedEvent
            {
                Id = loc.Id,
                DeletedAt = loc.DeletedAt!.Value,
                DeletedBy = loc.DeletedBy
            });

            await publishEndpoint.Publish(locationDeletedEvent, ct);
            await unitOfWork.SaveChangesAsync(ct);
            
            return (LocationMessage.Delete.Success, true);
        }, cancellationToken);
    }
}