using AutoMapper;
using NET_CarRentalSystem.API.Models.Request.RefundRequests;
using NET_CarRentalSystem.API.Models.Response.RefundRequests;
using NET_CarRentalSystem.Application.Features.RefundRequests.Queries.GetPendingRefundRequestsQuery;
using NET_CarRentalSystem.Application.Models.DTOs.RefundRequestDTOs;

namespace NET_CarRentalSystem.API.Mappings;

public class RefundRequestProfile : Profile
{
    public RefundRequestProfile()
    {
        CreateMap<GetPendingRefundRequestsRequest, GetPendingRefundRequestsQueryParams>();

        CreateMap<RefundRequestDto, GetPendingRefundRequestsResponse>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
    }
}

