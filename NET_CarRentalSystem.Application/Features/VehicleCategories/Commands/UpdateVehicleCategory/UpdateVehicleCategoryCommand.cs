using MediatR;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;

public class UpdateVehicleCategoryCommand : IRequest<bool>
{
    [Required]
    public Guid Id { get; set; }

    public string? CategoryCode { get; set; }

    public int? Seat { get; set; }
}
