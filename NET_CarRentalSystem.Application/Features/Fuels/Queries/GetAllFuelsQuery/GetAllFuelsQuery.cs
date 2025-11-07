using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.FuelDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Fuels.Queries.GetAllFuelsQuery;

public class GetAllFuelsQuery : IQuery<List<GetFuelDto>>;

public class GetAllFuelsQueryHandler(IUnitOfWork unitOfWork) : IRequestHandler<GetAllFuelsQuery, List<GetFuelDto>>
{
    public async Task<List<GetFuelDto>> Handle(GetAllFuelsQuery request, CancellationToken cancellationToken)
    {
        var fuels = await unitOfWork.GetRepository<Fuel>().GetAllAsync(cancellationToken);
        
        return [.. fuels.Select(fuel => new GetFuelDto
        {
            FuelId = fuel.FuelId,
            Name = fuel.Name,
            Description = fuel.Description
        })];
    }
}
