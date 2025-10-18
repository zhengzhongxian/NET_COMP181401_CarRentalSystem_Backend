using AutoMapper;
using NET_CarRentalSystem.API.Models.Request;
using NET_CarRentalSystem.API.Models.Response;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleProfile : Profile
{
    public VehicleProfile()
    {
        CreateMap<GetVehiclesRequest, GetVehiclesPagedQueryParams>();
        CreateMap<VehicleDto, VehicleResponse>();

        CreateMap<PagedList<VehicleDto>, PagedResponse<VehicleResponse>>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
    }
}
