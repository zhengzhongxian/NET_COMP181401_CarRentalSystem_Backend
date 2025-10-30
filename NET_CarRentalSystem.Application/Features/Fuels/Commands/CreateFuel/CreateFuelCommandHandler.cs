using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Fuels.Commands.CreateFuel;

public class CreateFuelCommand(string name, string? description) : ICommand<Guid>
{
    public string Name { get; } = name;
    public string? Description { get; } = description;
}

public class CreateFuelCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateFuelCommand, Guid>
{
    public async Task<Guid> Handle(CreateFuelCommand request, CancellationToken cancellationToken)
    {
        var newFuel = new Fuel 
        { 
            FuelId = Guid.NewGuid(), 
            Name = request.Name, 
            Description = request.Description 
        };

        await unitOfWork.GetRepository<Fuel>().AddAsync(newFuel, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return newFuel.FuelId;
    }
}