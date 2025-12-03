using MediatR;
using MassTransit;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Features.Vehicles.Events;
using NET_CarRentalSystem.Application.Interfaces.Services.Authentication;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Vehicles.Commands.DeleteVehicleCommand;

public class DeleteVehicleCommand : ICommand<bool>
{
    public required Guid VehicleId { get; set; }
}

public class DeleteVehicleCommandHandler(
    IUnitOfWork unitOfWork,
    IPublishEndpoint publishEndpoint,
    ICurrentUserService currentUserService) : IRequestHandler<DeleteVehicleCommand, bool>
{
    public async Task<bool> Handle(DeleteVehicleCommand request, CancellationToken cancellationToken)
    {
        return await unitOfWork.ExecuteInTransactionAsync(async (ct) =>
        {
            var vehicle = await unitOfWork.GetWriteRepository<Vehicle>().GetByIdAsync(request.VehicleId, ct);

            if (vehicle == null)
                return false;
            
            unitOfWork.GetWriteRepository<Vehicle>().Remove(vehicle);
            await unitOfWork.SaveChangesAsync(ct);
            
            var currentUserId = currentUserService.GetUserId()!.Value;

            var vehicleDeletedEvent =
                vehicle.ToDeletedEvent<Vehicle, VehicleDeletedEvent, Guid>(v => new VehicleDeletedEvent{});

            await publishEndpoint.Publish(vehicleDeletedEvent, ct);
            
            await unitOfWork.SaveChangesAsync(ct); 

            return true;
        }, cancellationToken);
    }
}