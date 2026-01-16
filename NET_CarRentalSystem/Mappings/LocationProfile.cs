using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Locations;
using NET_CarRentalSystem.API.Models.Response.Locations;
using NET_CarRentalSystem.Application.Features.Locations.Queries.GetLocationsPagedQuery;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Update;

namespace NET_CarRentalSystem.API.Mappings;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<GetLocationsPagedRequest, GetLocationsPagedQueryParams>();
        
        CreateMap<GetLocationDto, GetLocationResponse>();
        CreateMap<UpdateLocationDto, UpdateLocationResponse>();
    }
}