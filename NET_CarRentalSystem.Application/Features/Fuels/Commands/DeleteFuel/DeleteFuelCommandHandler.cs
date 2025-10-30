using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.Application.Features.Fuels.Commands.DeleteFuel;

public class DeleteFuelCommand(Guid id) : ICommand<(string, bool)>
{
    public Guid Id { get; } = id;
}

public class DeleteFuelCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteFuelCommand, (string, bool)>
{
    public async Task<(string, bool)> Handle(DeleteFuelCommand request, CancellationToken cancellationToken)
    {
        var fuelToDelete = await unitOfWork.GetRepository<Fuel>().GetByIdAsync(
            request.Id,
            cancellationToken, 
            useWriteConnection: true);

        if (fuelToDelete == null) return (FuelMessage.Delete.NotFound, false);
        unitOfWork.GetRepository<Fuel>().Remove(fuelToDelete);
        
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
        return (FuelMessage.Delete.Success ,true);
    }
}