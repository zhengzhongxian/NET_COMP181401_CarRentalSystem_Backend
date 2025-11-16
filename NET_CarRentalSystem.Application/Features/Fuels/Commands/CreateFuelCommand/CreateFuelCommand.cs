using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Fuels.Commands.CreateFuelCommand;

public class CreateFuelCommand : ICommand<Guid>
{
    public required string Name { get; init; }
    public string? Description { get; init; }
}

public class CreateFuelCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateFuelCommand, Guid>
{
    public async Task<Guid> Handle(CreateFuelCommand request, CancellationToken cancellationToken)
    {
        var newFuel = new Fuel 
        { 
            Id = Guid.NewGuid(), 
            Name = request.Name, 
            Description = request.Description 
        };

        await unitOfWork.GetRepository<Fuel>().AddAsync(newFuel, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return newFuel.Id;
    }
}