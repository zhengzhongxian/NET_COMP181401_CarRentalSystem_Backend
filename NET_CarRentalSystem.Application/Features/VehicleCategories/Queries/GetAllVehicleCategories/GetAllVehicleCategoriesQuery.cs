using MediatR;
using NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Get;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetAllVehicleCategories;

public class GetAllVehicleCategoriesQuery : IRequest<List<GetVehicleCategoryDto>>
{
    
}
