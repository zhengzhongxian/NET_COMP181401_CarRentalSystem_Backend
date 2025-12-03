using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Update;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Commands.UpdateTransmissionCommand;

public class UpdateTransmissionCommand : ICommand<UpdateTransmissionDto?>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
}

public class UpdateTransmissionCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateTransmissionCommand, UpdateTransmissionDto?>
{
    public async Task<UpdateTransmissionDto?> Handle(UpdateTransmissionCommand request, CancellationToken cancellationToken)
    {
        var repository = unitOfWork.GetWriteRepository<Transmission>();
        var transmissionToUpdate = await repository.GetByIdAsync(request.Id, cancellationToken);

        if (transmissionToUpdate == null) return null;

        if (request.Name != null) transmissionToUpdate.Name = request.Name;
        if (request.Code != null) transmissionToUpdate.Code = request.Code;
        if (request.Description != null) transmissionToUpdate.Description = request.Description;

        repository.Update(transmissionToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return new UpdateTransmissionDto
        {
            TransmissionId = transmissionToUpdate.TransmissionId,
            Name = transmissionToUpdate.Name,
            Code = transmissionToUpdate.Code,
            Description = transmissionToUpdate.Description
        };
    }
}

