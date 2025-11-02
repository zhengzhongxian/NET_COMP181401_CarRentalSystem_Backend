using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.CreateVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.DeleteVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Commands.UpdateVehicleCategory;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetAllVehicleCategories;
using NET_CarRentalSystem.Application.Features.VehicleCategories.Queries.GetVehicleCategoryById;
using NET_CarRentalSystem.Shared.Constants.MessageConstants;

namespace NET_CarRentalSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VehicleCategoriesController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetVehicleCategories()
    {
        var query = new GetAllVehicleCategoriesQuery();
        var result = await mediator.Send(query);
        return Ok(new { message = VehicleCategoryMessage.Get.Success, data = result });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetVehicleCategory(Guid id)
    {
        var query = new GetVehicleCategoryByIdQuery { Id = id };
        var result = await mediator.Send(query);

        if (result == null)
        {
            return NotFound(new { message = VehicleCategoryMessage.Get.NotFound });
        }

        return Ok(new { message = VehicleCategoryMessage.Get.Success, data = result });
    }

    [HttpPost]
    public async Task<IActionResult> CreateVehicleCategory([FromBody] CreateVehicleCategoryCommand command)
    {
        var categoryId = await mediator.Send(command);
        return CreatedAtAction(
            nameof(GetVehicleCategory), 
            new { id = categoryId }, 
            new { message = VehicleCategoryMessage.Post.Success, id = categoryId });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateVehicleCategory(Guid id, [FromBody] UpdateVehicleCategoryCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        var result = await mediator.Send(command);

        if (!result)
        {
            return NotFound(new { message = VehicleCategoryMessage.Update.NotFound });
        }

        return Ok(new { message = VehicleCategoryMessage.Update.Success });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVehicleCategory(Guid id)
    {
        var command = new DeleteVehicleCategoryCommand { Id = id };
        var result = await mediator.Send(command);

        if (!result)
        {
            return NotFound(new { message = VehicleCategoryMessage.Delete.NotFound });
        }

        return Ok(new { message = VehicleCategoryMessage.Delete.Success });
    }
}
