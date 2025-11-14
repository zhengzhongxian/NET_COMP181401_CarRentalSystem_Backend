using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.FuelDTOs.Update;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.Application.Features.Fuels.Commands.UpdateFuelCommand;

public class UpdateFuelCommand : ICommand<(string, UpdateFuelDto?)>
{
    public required Guid FuelId { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}

public class UpdateFuelCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateFuelCommand, (string, UpdateFuelDto?)>
{
    public async Task<(string, UpdateFuelDto?)> Handle(UpdateFuelCommand request, CancellationToken cancellationToken)
    {
        var repository = unitOfWork.GetRepository<Fuel>();
        
        var fuelToUpdate = await repository.GetByIdAsync(request.FuelId, cancellationToken, useWriteConnection: true);

        if (fuelToUpdate == null) return (FuelMessage.Update.NotFound, null);
        
        fuelToUpdate.Name = request.Name;
        
        if (request.Description != null)
        {
            fuelToUpdate.Description = request.Description;
        }
        
        repository.Update(fuelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var fuelDto = new UpdateFuelDto
        {
            FuelId = fuelToUpdate.Id,
            Name = fuelToUpdate.Name,
            Description = fuelToUpdate.Description
        };
        
        return (FuelMessage.Update.Success, fuelDto);
    }
}