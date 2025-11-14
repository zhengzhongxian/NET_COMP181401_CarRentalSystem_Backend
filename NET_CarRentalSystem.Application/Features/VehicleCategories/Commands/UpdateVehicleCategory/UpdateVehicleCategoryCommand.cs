using MediatR;
using NET_CarRentalSystem.Application.Common.Interfaces.CQRS;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using System.ComponentModel.DataAnnotations;
using NET_CarRentalSystem.Application.Models.DTOs.VehicleCategoryDTOs.Update;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;

public class UpdateVehicleCategoryCommand : ICommand<UpdateVehicleCategoryDto?>
{
    [Required]
    public Guid Id { get; set; }

    public string? CategoryCode { get; set; }

    public int? Seat { get; set; }
}

public class UpdateVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<UpdateVehicleCategoryCommand, UpdateVehicleCategoryDto?>
{
    public async Task<UpdateVehicleCategoryDto?> Handle(
        UpdateVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var categoryToUpdate = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (categoryToUpdate == null)
        {
            return null;
        }

        if (request.CategoryCode != null)
        {
            categoryToUpdate.CategoryCode = request.CategoryCode;
        }

        if (request.Seat.HasValue)
        {
            categoryToUpdate.Seat = request.Seat.Value;
        }

        unitOfWork.GetRepository<VehicleCategory>().Update(categoryToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var updatedDto = new UpdateVehicleCategoryDto
        {
            CategoryId = categoryToUpdate.Id,
            CategoryCode = categoryToUpdate.CategoryCode,
            Seat = categoryToUpdate.Seat
        };

        return updatedDto;
    }
}
