using MediatR;
using NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Get;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetVehicleCategoryById;

public class GetVehicleCategoryByIdQuery : IRequest<GetVehicleCategoryDto?>
{
    public Guid Id { get; set; }
}
