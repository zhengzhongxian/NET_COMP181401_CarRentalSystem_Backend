using AutoMapper;
using NET_CarRentalSystem.API.Models.Response.Payments;
using NET_CarRentalSystem.Application.DTOs.PaymentDTOs.Get;

namespace NET_CarRentalSystem.API.Mappings;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<GetPaymentMethodDto, GetPaymentMethodResponse>();
    }
}