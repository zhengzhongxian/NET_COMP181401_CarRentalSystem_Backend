using MediatR;
using NET_CarRentalSystem.Application.Common.Extensions;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationsPagedQuery;

public class GetLocationsPagedQuery : IQuery<PagedList<GetLocationDto>>
{
    public required GetLocationsPagedQueryParams RequestParams { get; set; }
}

public class GetLocationsPagedQueryHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<GetLocationsPagedQuery, PagedList<GetLocationDto>>
{
    public async Task<PagedList<GetLocationDto>> Handle(GetLocationsPagedQuery request, CancellationToken cancellationToken)
    {
        var queryParams = request.RequestParams;
        
        var query = unitOfWork.GetReadRepository<Location>()
            .GetQueryable()
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
            });
        
        return await query.ToPagedListAsync(queryParams.PageNumber, queryParams.PageSize, cancellationToken);
    }
}