using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationsPagedQuery;

public class GetLocationsPagedQuery : IQuery<PagedList<GetLocationDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetLocationsPagedQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetLocationsPagedQuery, PagedList<GetLocationDto>>
{
    public async Task<PagedList<GetLocationDto>> Handle(GetLocationsPagedQuery request, CancellationToken cancellationToken)
    {
        var locations = await unitOfWork.GetReadRepository<Location>()
            .GetAsync(cancellationToken: cancellationToken);

        var locationDtos = locations
            .OrderBy(l => l.Name)
            .Select(location => new GetLocationDto
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
            }).ToList();

        var totalCount = locationDtos.Count;
        var pagedItems = locationDtos
            .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .ToList();

        return new PagedList<GetLocationDto>(pagedItems, totalCount, request.PageNumber, request.PageSize);
    }
}