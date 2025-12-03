using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Queries.GetTransmissionByIdQuery;

public class GetTransmissionByIdQuery : IQuery<GetTransmissionDto?>
{
    public required Guid Id { get; set; }
}

public class GetTransmissionByIdQueryHandler(IUnitOfWork unitOfWork)
    : IRequestHandler<GetTransmissionByIdQuery, GetTransmissionDto?>
{
    public async Task<GetTransmissionDto?> Handle(GetTransmissionByIdQuery request, CancellationToken cancellationToken)
    {
        var repo = unitOfWork.GetReadRepository<Transmission>();
        var entity = await repo.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null) return null;

        return new GetTransmissionDto
        {
            TransmissionId = entity.TransmissionId,
            Name = entity.Name,
            Code = entity.Code,
            Description = entity.Description
        };
    }
}

