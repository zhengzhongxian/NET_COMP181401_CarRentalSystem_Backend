using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.DTOs.FuelDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Fuels.Queries.GetFuelById;

public class GetFuelByIdQuery(Guid id) : IQuery<GetFuelDto?>
{
    public Guid Id { get; } = id;
}

public class GetFuelByIdQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetFuelByIdQuery, GetFuelDto?>
{
    public async Task<GetFuelDto?> Handle(GetFuelByIdQuery request, CancellationToken cancellationToken)
    {
        var fuel = await unitOfWork.GetRepository<Fuel>().GetByIdAsync(request.Id, cancellationToken);

        if (fuel == null) return null;

        return new GetFuelDto { FuelId = fuel.FuelId, Name = fuel.Name, Description = fuel.Description };
    }
}