using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Terms;
using NET_CarRentalSystem.Application.Models.DTOs.TermsDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class TermsProfile : Profile
{
    public TermsProfile()
    {
        CreateMap<TermsAndConditionsDto, GetTermsResponse>();
    }
}

