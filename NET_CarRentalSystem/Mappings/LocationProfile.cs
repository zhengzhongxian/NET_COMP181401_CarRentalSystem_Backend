using AutoMapper;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.LocationDTOs.Update;
using NET_CarRentalSystem.API.Models.Response.Locations;

namespace NET_CarRentalSystem.API.Mappings;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<GetLocationDto, GetLocationResponse>();
        CreateMap<UpdateLocationDto, UpdateLocationResponse>();
    }
}