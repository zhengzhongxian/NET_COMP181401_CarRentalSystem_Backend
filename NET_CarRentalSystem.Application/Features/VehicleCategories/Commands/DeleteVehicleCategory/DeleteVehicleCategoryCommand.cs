using MediatR;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.DeleteVehicleCategory;

public class DeleteVehicleCategoryCommand : IRequest<bool>
{
    [Required]
    public Guid Id { get; set; }
}
