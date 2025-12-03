using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Commands.DeleteTransmissionCommand;

public class DeleteTransmissionCommand : ICommand<bool>
{
    public Guid Id { get; set; }
}

public class DeleteTransmissionCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<DeleteTransmissionCommand, bool>
{
    public async Task<bool> Handle(DeleteTransmissionCommand request, CancellationToken cancellationToken)
    {
        var repository = unitOfWork.GetWriteRepository<Transmission>();
        var transmissionToDelete = await repository.GetByIdAsync(request.Id, cancellationToken);

        if (transmissionToDelete == null) return false;

        repository.Remove(transmissionToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return true;
    }
}

