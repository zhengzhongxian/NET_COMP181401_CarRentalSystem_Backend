using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Transmissions;
using NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Get;
using NET_CarRentalSystem.Application.Models.DTOs.TransmissionDTOs.Update;

namespace NET_CarRentalSystem.API.Mappings;

public class TransmissionProfile : Profile
{
    public TransmissionProfile()
    {
        CreateMap<GetTransmissionDto, GetTransmissionResponse>();
        CreateMap<UpdateTransmissionDto, UpdateTransmissionResponse>();
    }
}

