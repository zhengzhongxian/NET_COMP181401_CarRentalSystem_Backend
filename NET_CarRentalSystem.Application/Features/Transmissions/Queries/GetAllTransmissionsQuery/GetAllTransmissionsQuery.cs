using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Transmissions.Queries.GetAllTransmissionsQuery;

public class GetAllTransmissionsQuery : IQuery<List<GetTransmissionDto>>;

public class GetAllTransmissionsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllTransmissionsQuery, List<GetTransmissionDto>>
{
    public async Task<List<GetTransmissionDto>> Handle(GetAllTransmissionsQuery request, CancellationToken cancellationToken)
    {
        var list = await unitOfWork.GetReadRepository<Transmission>().GetAsync(cancellationToken: cancellationToken);

        return list.Select(x => new GetTransmissionDto
        {
            TransmissionId = x.TransmissionId,
            Name = x.Name,
            Code = x.Code,
            Description = x.Description
        }).ToList();
    }
}
