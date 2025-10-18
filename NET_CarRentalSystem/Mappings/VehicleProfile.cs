using AutoMapper;
using NET_CarRentalSystem.API.Models.Request;
using NET_CarRentalSystem.API.Models.Response;
using NET_CarRentalSystem.Application.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleProfile : Profile
{
    public VehicleProfile()
    {
        CreateMap<GetVehiclesRequest, GetVehiclesPagedQueryParams>();
        CreateMap<GetVehicleDto, VehicleResponse>();

        CreateMap<PagedList<GetVehicleDto>, PagedResponse<VehicleResponse>>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
    }
}
