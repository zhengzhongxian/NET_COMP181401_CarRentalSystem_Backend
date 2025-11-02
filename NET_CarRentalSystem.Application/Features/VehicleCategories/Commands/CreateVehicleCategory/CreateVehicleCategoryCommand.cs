using MediatR;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.CreateVehicleCategory;

public class CreateVehicleCategoryCommand : IRequest<Guid>
{
    [Required]
    public string CategoryCode { get; set; }

    [Required]
    public int Seat { get; set; }
}
