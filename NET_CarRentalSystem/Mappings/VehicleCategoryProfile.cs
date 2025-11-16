using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.VehicleCategories;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Update;

namespace NET_CarRentalSystem.API.Mappings;

public class VehicleCategoryProfile : Profile
{
    public VehicleCategoryProfile()
    {
        CreateMap<GetVehicleCategoryDto, GetVehicleCategoryResponse>();
        CreateMap<UpdateVehicleCategoryDto, UpdateVehicleCategoryResponse>();
    }
}
