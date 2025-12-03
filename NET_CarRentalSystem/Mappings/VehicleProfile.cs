using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.Vehicles;
using NET_CarRentalSystem.API.Models.Response.Vehicles;
using NET_CarRentalSystem.Application.Features.Vehicles.Queries.GetVehiclesPagedQuery;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleAttributeDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleImageDTOs;
using NET_CarRentalSystem.Shared.Utilities;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleProfile : Profile
{
    public VehicleProfile()
    {
        CreateMap<GetVehiclesPagedRequest, GetVehiclesPagedQueryParams>();
        CreateMap<GetVehicleDto, GetVehiclesPagedResponse>();
        CreateMap<GetVehicleDetailsDto, GetVehicleDetailResponse>()
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => 
                string.IsNullOrWhiteSpace(src.ImagesJson) 
                    ? new List<GetVehicleImageDto>() 
                    : src.ImagesJson.FromJson<List<GetVehicleImageDto>>() ?? new List<GetVehicleImageDto>()))
            
            .ForMember(dest => dest.Attributes, opt => opt.MapFrom(src => 
                string.IsNullOrWhiteSpace(src.AttributesJson) 
                    ? new List<GetVehicleAttributeDto>() 
                    : src.AttributesJson.FromJson<List<GetVehicleAttributeDto>>() ?? new List<GetVehicleAttributeDto>()));
    }
}
