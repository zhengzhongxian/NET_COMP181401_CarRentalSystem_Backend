using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;

namespace NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationByIdQuery;

public class GetLocationByIdQuery : IQuery<GetLocationDto?>
{
    public required Guid LocationId { get; init; }
}

public class GetLocationByIdQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetLocationByIdQuery, GetLocationDto?>
{
    public async Task<GetLocationDto?> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
    {
        var location = await unitOfWork.GetReadRepository<Location>()
            .GetByIdAsync(request.LocationId, cancellationToken);

        if (location == null)
            return null;

        return new GetLocationDto
        {
            LocationId = location.Id,
            Name = location.Name,
            Address = location.Address,
            City = location.City,
            PhoneNumber = location.PhoneNumber,
            OpeningHours = location.OpeningHours,
            Latitude = location.Latitude,
            Longitude = location.Longitude,
            Description = location.Description,
            Thumbnail = location.Thumbnail
        };
    }
}