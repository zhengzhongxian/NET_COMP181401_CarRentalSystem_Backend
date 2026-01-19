using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Insurances;
using NET_CarRentalSystem.Application.Models.DTOs.InsuranceDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class InsuranceProfile : Profile
{
    public InsuranceProfile()
    {
        CreateMap<InsurancePackageDto, GetInsurancePackageResponse>();
    }
}

