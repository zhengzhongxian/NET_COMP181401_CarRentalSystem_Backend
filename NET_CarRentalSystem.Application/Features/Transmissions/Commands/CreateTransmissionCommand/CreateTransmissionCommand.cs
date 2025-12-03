using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Commands.CreateTransmissionCommand;

public class CreateTransmissionCommand : ICommand<Guid>
{
    public required string Name { get; set; }
    public required string Code { get; set; }
    public string? Description { get; set; }
}

public class CreateTransmissionCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreateTransmissionCommand, Guid>
{
    public async Task<Guid> Handle(
        CreateTransmissionCommand request, 
        CancellationToken cancellationToken)
    {
        var newTransmission = new Transmission
        {
            Name = request.Name,
            Code = request.Code,
            Description = request.Description
        };

        await unitOfWork.GetWriteRepository<Transmission>().AddAsync(newTransmission, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return newTransmission.TransmissionId;
    }
}

