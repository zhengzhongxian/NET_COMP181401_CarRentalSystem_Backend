using MediatR;
using NET_CarRentalSystem.Application.DTOs.VehicleCategoryDTOs.Update;
using NET_CarRentalSystem.Domain.Entities;
using NET_CarRentalSystem.Domain.Interfaces.Persistence;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;
using System.ComponentModel.DataAnnotations;

namespace NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;

public class UpdateVehicleCategoryCommand : IRequest<(string, UpdateVehicleCategoryDto?)>
{
    [Required]
    public Guid Id { get; set; }

    public string? CategoryCode { get; set; }

    public int? Seat { get; set; }
}

public class UpdateVehicleCategoryCommandHandler(IUnitOfWork unitOfWork) 
    : IRequestHandler<UpdateVehicleCategoryCommand, (string, UpdateVehicleCategoryDto?)>
{
    public async Task<(string, UpdateVehicleCategoryDto?)> Handle(
        UpdateVehicleCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var categoryToUpdate = await unitOfWork.GetRepository<VehicleCategory>()
            .GetByIdAsync(request.Id, cancellationToken);

        if (categoryToUpdate == null)
        {
            return (VehicleCategoryMessage.Update.NotFound, null);
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
            CategoryId = categoryToUpdate.CategoryId,
            CategoryCode = categoryToUpdate.CategoryCode,
            Seat = categoryToUpdate.Seat
        };

        return (VehicleCategoryMessage.Update.Success, updatedDto);
    }
}
