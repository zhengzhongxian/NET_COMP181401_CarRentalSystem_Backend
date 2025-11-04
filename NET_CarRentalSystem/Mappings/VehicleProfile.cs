using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleProfile : Profile
{
    public VehicleProfile()
    {
        CreateMap<GetVehiclesPagedRequest, GetVehiclesPagedQueryParams>();
        CreateMap<GetVehicleDto, GetVehiclesPagedResponse>();
    }
}
