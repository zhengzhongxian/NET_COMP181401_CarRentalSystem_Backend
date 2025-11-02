using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Fuels;
using NET_CarRentalSystem.Application.DTOs.FuelDTOs.Update;

namespace NET_CarRentalSystem.API.Mappings;

public class FuelProfile : Profile
{
    public FuelProfile()
    {
        CreateMap<UpdateFuelDto, UpdateFuelResponse>();
    }
}