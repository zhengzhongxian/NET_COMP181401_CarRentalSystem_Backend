using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleProfile : Profile
{
    public VehicleProfile()
    {
        CreateMap<GetVehiclesPagedRequest, GetVehiclesPagedQueryParams>();
        CreateMap<GetVehicleDto, GetVehiclesPagedResponse>();
        CreateMap<GetVehicleDetailDto, GetVehicleDetailResponse>();
    }
}
