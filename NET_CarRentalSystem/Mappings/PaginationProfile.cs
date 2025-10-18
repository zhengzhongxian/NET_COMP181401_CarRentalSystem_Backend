using AutoMapper;
using NET_CarRentalSystem.Shared.Pagination;

namespace NET_CarRentalSystem.API.Mappings;

public class PaginationProfile : Profile
{
    public PaginationProfile()
    {
        CreateMap(typeof(PagedList<>), typeof(PagedResponse<>))
                .ForMember("Items", opt => opt.MapFrom("Items"));
    }
}
